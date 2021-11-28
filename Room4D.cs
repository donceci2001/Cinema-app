using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using КурсовПроект.GlobalConstants;

namespace Kурсов_Проект
{
    public class Room4D: Cinema
    {
        private int glasses4D;
        private double popcornPrice4D;
        private double glassesPrice4D;
        public int Glasses4D
        {
            get
            {
                return this.glasses4D;
            }
            set
            {
                this.glasses4D = value;
            }
        }
        public double PopcornPrice4D
        {
            get
            {
                return this.popcornPrice4D;
            }
            set
            {
                this.popcornPrice4D = value;
            }
        }
        public double GlassesPrice4D
        {
            get
            {
                return this.glassesPrice4D;
            }
            set
            {
                this.glassesPrice4D = value;
            }
        }

        public Room4D(int glasses4D, double priceGlasses4D, double popcorn4D)
        {
            Glasses4D = glasses4D;
            GlassesPrice4D = priceGlasses4D;
            PopcornPrice4D = popcorn4D;
            Films.Add(new Movie("Jumanji", GlobalConstants.Tickets, 15));
            Films.Add(new Movie("Godzilla", GlobalConstants.Tickets, 13));
            Films.Add(new Movie("Fly high", GlobalConstants.Tickets, 14));
            Films.Add(new Movie("Ultimate disaster", GlobalConstants.Tickets, 15));
        }

        public override bool HaveSeats(Movie movie, int ticketCount)
        {
            Glasses4D -= ticketCount;
            if (movie.Tickets - ticketCount < 0)
            {
                MessageBox.Show(GlobalConstants.NotEnoughTickets);
                return false;
            }
            if (ticketCount > Glasses4D)
            {
                MessageBox.Show(GlobalConstants.NotEnoughGlasses);
                return false;
            }

            return true;
        }
        public override double TotalPrice(Movie movie, int bTck, double popPrice, int popNumber)
        {
            return Math.Ceiling((movie.Price + glassesPrice4D) * bTck + popPrice * popNumber);
        }
        public override void FreePlaces()
        {
            int freePlaces = 0;
            foreach (var film in Films)
            {
                freePlaces += film.Tickets;
            }
            if(Glasses4D < freePlaces)
            {
                MessageBox.Show("Number of free places in 4D cinema " + Glasses4D);
            }
            else
            {
                MessageBox.Show("Number of free places in 4D cinema " + freePlaces);

            }
        }
    }
}
