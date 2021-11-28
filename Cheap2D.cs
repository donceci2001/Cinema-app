using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using КурсовПроект.GlobalConstants;

namespace Kурсов_Проект
{
    
     public  class Cheap2D:Cinema
    {
        private double popcornPrice;
        public double PopcornPrice
        {
            get
            {
                return this.popcornPrice;
            }
            set
            {
                this.popcornPrice = value;
            }
        }
        
        public Cheap2D(double popPrice)
        {
            PopcornPrice = popPrice;
            Films.Add(new Movie("Gladiator", GlobalConstants.Tickets, 6));
            Films.Add(new Movie("Kingsman", GlobalConstants.Tickets, 7));
            Films.Add(new Movie("Borat", GlobalConstants.Tickets, 8));
            Films.Add(new Movie("Titanic", GlobalConstants.Tickets, 6));

        }
        public override double TotalPrice(Movie movie, int bTck, double popPrice, int popNumber)
        {
            return Math.Ceiling((movie.Price * bTck + popPrice * popNumber));
        }
        public override void  FreePlaces()
        {
            int freePlaces = 0; 
            foreach (var film in Films)
            {
                freePlaces += film.Tickets;
            }
            MessageBox.Show("Number of free places in 2D cinema " + freePlaces);
        }
    }
}
