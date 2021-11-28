using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using КурсовПроект.GlobalConstants;

namespace Kурсов_Проект
{
    public partial class FormInformation : Form
    {
        public List<Order> Orders  = new List<Order>();
        Order currentOrder = new Order();
        private double Total;

        public FormInformation(double totalCost, Order current)
        {
            currentOrder = current;
            InitializeComponent();
            labelTotalCost.Text = totalCost + "$";
            Total = totalCost;
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxPhone.Text) || string.IsNullOrEmpty(textBoxName.Text)) 
               return;

            currentOrder.Unicode = Guid.NewGuid().ToString().Substring(0, 8);
            currentOrder.PersonName = textBoxName.Text;
            bool valid = int.TryParse(textBoxPhone.Text, out _);
            if (valid)
                currentOrder.Phone = int.Parse(textBoxPhone.Text);
            else
            {
                MessageBox.Show(GlobalConstants.NotEnteredRealNumbers);
                return;
            }
            currentOrder.TotalValue = Total;
            MessageBox.Show(GlobalConstants.SuccessfulPayment);
            this.Hide();
            var fourthForm = new FormOrders(currentOrder);
            fourthForm.ShowDialog();
            this.Close();

        }

        private void buttonChangeOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            var secondForm = new FormBuyTickets();
            secondForm.ShowDialog();

            this.Close();
        }
    }
}
