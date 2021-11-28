using КурсовПроект.GlobalConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Kурсов_Проект
{
    public partial class FormBuyTickets : Form
    {

        public Order CurrentOrder = new Order();

        Cinema cinema = new Cinema();

        public FormBuyTickets()
        {
            InitializeComponent();
            cinema = new Cheap2D(GlobalConstants.PopCornPrice);
            foreach (var film in cinema.Films)
            {
                comboBoxMovie2D.Items.Add(film);
            }
            cinema = new Premium3D(GlobalConstants.Glasses3D, GlobalConstants.PriceGlasses3D);
            foreach (var film in cinema.Films)
            {
                comboBoxMovie3D.Items.Add(film);
            }
            cinema = new Room4D(GlobalConstants.Glasses4D, GlobalConstants.PriceGlasses4D, GlobalConstants.PopCornPrice);
            foreach (var film in cinema.Films)
            {
                comboBox4D.Items.Add(film);
            }

        }


        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            bool successful;
            double totalCost;
            if (numericUpDownTickets.Value < 1)
                return;

            if ((comboBoxMovie2D.SelectedItem == null && comboBoxMovie2D.Visible)
                || (comboBoxMovie3D.SelectedItem == null && comboBoxMovie3D.Visible)
                || (comboBox4D.SelectedItem == null && comboBox4D.Visible))
                return;

            var movie = new Movie();
            if (comboBoxMovie2D.Visible && comboBoxMovie2D.Text != "")
            {
                cinema = new Cheap2D(GlobalConstants.PopCornPrice);
                movie = (Movie)comboBoxMovie2D.SelectedItem;
            }

            if (comboBoxMovie3D.Visible && comboBoxMovie3D.Text != "")
            {
                cinema = new Premium3D(GlobalConstants.Glasses3D, GlobalConstants.PriceGlasses3D);
                movie = (Movie)comboBoxMovie3D.SelectedItem;
            }

            if (comboBox4D.Visible && comboBox4D.Text != "")
            {
                cinema = new Room4D(GlobalConstants.Glasses4D, GlobalConstants.PriceGlasses4D, GlobalConstants.PopCornPrice);
                movie = (Movie)comboBox4D.SelectedItem;
            }

            var orders = DataBase.LoadOrders();
            foreach (var order in orders)
            {
                foreach (var item in cinema.Films)
                {
                    if (order.FilmName == item.Name)
                    {
                        item.Tickets -= order.Tickets;
                    }

                }
            }
            var currentFilm = cinema.Films
                .Where(c => c.Name == movie.Name)
                .FirstOrDefault();

            var tickets = (int)numericUpDownTickets.Value;
            successful = cinema.BuyTicket(currentFilm, tickets);
            totalCost = cinema.TotalPrice(currentFilm, tickets, GlobalConstants.PopCornPrice, (int)numericUpDownPopcorn.Value);
            CurrentOrder.FilmName = currentFilm.ToString();
            CurrentOrder.Tickets = (int)numericUpDownTickets.Value;

            
            if (successful)
            {
                this.Hide();
                var thirdForm = new FormInformation(totalCost, CurrentOrder);
                thirdForm.ShowDialog();

                this.Close();
            }


        }

        private void radioButtonCheap_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMovie2D.Visible = true;
            comboBoxMovie3D.Visible = false;
            comboBox4D.Visible = false;
            labelPopcorn.Visible = true;
            numericUpDownPopcorn.Visible = true;

        }

        private void radioButtonPremium_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMovie2D.Visible = false;
            comboBoxMovie3D.Visible = true;
            comboBox4D.Visible = false;
            labelPopcorn.Visible = false;
            numericUpDownPopcorn.Visible = false;

        }

        private void radioButton4D_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMovie2D.Visible = false;
            comboBoxMovie3D.Visible = false;
            comboBox4D.Visible = true;
            labelPopcorn.Visible = true;
            numericUpDownPopcorn.Visible = true;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var firstForm = new FormInitialPage();
            firstForm.ShowDialog();

            this.Close();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            var emptySeats = new List<Cinema>();
            List<Cinema> cinemas = new List<Cinema> {new Cheap2D(GlobalConstants.PopCornPrice)
                      , new Premium3D(GlobalConstants.Glasses3D,GlobalConstants.PriceGlasses3D)
                      , new Room4D(GlobalConstants.Glasses4D,GlobalConstants.PriceGlasses4D,GlobalConstants.PopCornPrice)};
            int count = 0;
            var orders = DataBase.LoadOrders();
            foreach (var order in orders)
            {
                foreach (var cinema in cinemas)
                {
                    foreach (var film in cinema.Films)
                    {
                        if (order.FilmName == film.Name)
                        {
                            film.Tickets -= order.Tickets;

                        }

                    }

                    emptySeats.Add(cinema);
                }
            }
            foreach (var cinema in emptySeats)
            {
                ++count;
                if (count > 3)
                    break;
                cinema.FreePlaces();
            }


        }
    }
}
