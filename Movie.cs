using System;
using System.Collections.Generic;
using System.Text;

namespace Kурсов_Проект
{
    public class Movie
    {
        private string name;
        private int tickets;
        private int price;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
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
        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public Movie()
        {

        }
        public Movie(string title, int tickets, int price)
        {
            Name = title;
            Tickets = tickets;
            Price = price;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
