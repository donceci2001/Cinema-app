using System;
using System.Collections.Generic;
using System.Text;

namespace Kурсов_Проект
{
    [Serializable]
    public class Order
    {
        private string personName;
        private int phone;
        private string filmName;
        private int tickets;
        private double totalValue;
        private string unicode;
        public string PersonName 
        {
            get
            {
                return this.personName;
            }
            set
            {
                this.personName = value;
            }
        }
        public int Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }
        public string FilmName
        {
            get
            {
                return this.filmName;
            }
            set
            {
                this.filmName = value;
            }
        }

        public int Tickets
        {
            get
            {
                return this.tickets;
            }
            set
            {
                this.tickets = value;
            }
        }
        public double TotalValue
        {
            get
            {
                return this.totalValue;
            }
            set
            {
                this.totalValue = value;
            }
        }

        public string Unicode
        {
            get
            {
                return this.unicode;
            }
            set
            {
                this.unicode = value;
            }
        }
        public override string ToString()
        {
            return PersonName ;
        }      
    }
}
