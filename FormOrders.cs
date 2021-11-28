using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using КурсовПроект.GlobalConstants;

namespace Kурсов_Проект
{
    public partial class FormOrders : Form
    {
        protected bool madeOrder;
        public FormOrders()
        {
            madeOrder = false;
           InitializeComponent();
           RefreshList();
            
        }
        public FormOrders(Order current)
        {
            if (current == null)
                return;
            
            CurrentOrder = current;
            madeOrder = true;

            InitializeComponent();
            labelPersonName.Text = "Person name: " + CurrentOrder.PersonName;
            labelFilmName.Text = "Film name: " + CurrentOrder.FilmName;
            labelPhone.Text = "Phone: " + CurrentOrder.Phone;
            labelUniCode.Text = "UniCode: " + CurrentOrder.Unicode;
            labelTickets.Text = "Number of tickets: " + CurrentOrder.Tickets;
            labelTotalCost.Text = "Total value: " + CurrentOrder.TotalValue + "$";
            DataBase.SaveOrder(CurrentOrder);

            RefreshList();

            
        }
        public List<Order> Orders { get; set; } = new List<Order>();
        public Order CurrentOrder;
        
        public int phone;
        public string unicode;
        
        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var list = (ListBox)sender;
            var order = (Order)list.SelectedItem;
            labelPersonName.Text = "Person name: " + order.PersonName;
            labelFilmName.Text = "Film name: " + order.FilmName;
            labelPhone.Text = "Phone: " + order.Phone;
            labelUniCode.Text = "UniCode: " + order.Unicode;
            labelTickets.Text = "Number of tickets: " + order.Tickets;
            labelTotalCost.Text = "Total value: " + order.TotalValue + "$";
            phone = order.Phone;
            unicode = order.Unicode;
           
        }
        private void listBoxOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonDelete.Visible = true;
        }

        private void listBoxOrders_MouseClick(object sender, MouseEventArgs e)
        {
            buttonDelete.Visible = false;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalConstants.ProcessOfDeletingOrder);
            buttonDelete.Visible = false;
            madeOrder = false;
            
            var fifthForm = new FormDelete(phone, unicode, this);
            fifthForm.ShowDialog();

        }

        public void RefreshList()
        {
            Orders = DataBase.LoadOrders();

            listBoxOrders.Items.Clear();
            if (Orders != null)
            {
                foreach (var item in Orders)
                {
                    listBoxOrders.Items.Add(item);
                }

                if(Orders.Count != 0)
                {
                    double averagePrice = Orders
                        .Average(x => x.TotalValue);
                    labelAveragePrice.Text = Math.Round(averagePrice, 2).ToString() + "$";

                    var mostWatchedMovie = Orders
                                        .GroupBy(o => o.FilmName)
                                        .OrderByDescending(o => o.Count())
                                        .Take(1)
                                        .Select(o => o.Key).FirstOrDefault();
                    labelMostWatchedFilm.Text = mostWatchedMovie;
                }
                
            }
            if (!madeOrder)
            {
                if (listBoxOrders.Items.Count > 0)
                   listBoxOrders.SelectedIndex = 0;
            }
            


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var firstForm = new FormInitialPage();
            firstForm.ShowDialog();

            this.Close();
        }
    }
}
