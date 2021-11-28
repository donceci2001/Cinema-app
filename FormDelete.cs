using КурсовПроект.GlobalConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kурсов_Проект
{
    public partial class FormDelete : Form
    {
        private List<Order> Orders  = new List<Order>();
        protected int currentNumber;
        protected string currentUniCode;
        
        public List<Movie> Films = new List<Movie>();

        protected FormOrders FourthForm { get; set; }
        public FormDelete(int phone, string unicode, FormOrders fourth)
        {
            InitializeComponent();
            currentNumber = phone;
            currentUniCode = unicode;
            FourthForm = fourth;
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Orders = DataBase.LoadOrders();
            bool valid1 = int.TryParse(textBoxPhone.Text, out _);
            if (!valid1)
            {
                MessageBox.Show(GlobalConstants.NotEnteredRealNumbers);
                return;
            }
            if (int.Parse(textBoxPhone.Text) != currentNumber || textBoxUniCode.Text != currentUniCode)
            {
                MessageBox.Show(GlobalConstants.NotExsitingOrder);
                return;
            }
            else
            {
                for (int i = 0; i < Orders.Count; i++)
                {
                    if(int.Parse(textBoxPhone.Text) == Orders[i].Phone 
                        && textBoxUniCode.Text == Orders[i].Unicode)
                    {
                        var orders = DataBase.LoadOrders();
                        List<Cinema> cinemas = new List<Cinema>{new Cheap2D(GlobalConstants.PopCornPrice)
                      , new Premium3D(GlobalConstants.Glasses3D, GlobalConstants.PriceGlasses3D)
                      , new Room4D(GlobalConstants.Glasses4D, GlobalConstants.PriceGlasses4D, GlobalConstants.PopCornPrice)};
                    foreach (var order in orders)
                        {
                            foreach (var cinema in cinemas)
                            {
                                foreach (var film in cinema.Films)
                                {
                                    if (order.FilmName == film.Name)
                                    {
                                        film.Tickets += order.Tickets;
                                    }

                                }
                            }
                        }
                        Orders.RemoveAt(i);
                        DataBase.Save(Orders);
                        MessageBox.Show(GlobalConstants.DeletedOrder);
                        FourthForm.RefreshList();
                        this.Close();
                        break;
                    }
                }

            }
               
        }
    }
}
