using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kурсов_Проект
{
    public partial class FormInitialPage : Form
    {
        
        public FormInitialPage()
        {
            InitializeComponent();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fourthForm = new FormOrders();
            fourthForm.ShowDialog();
            this.Close();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var secondForm = new FormBuyTickets();
            secondForm.ShowDialog();

            this.Close();
        }
    }
}
