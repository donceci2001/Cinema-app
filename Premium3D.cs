using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using КурсовПроект.GlobalConstants;

namespace Kурсов_Проект
{
    
     public  class Premium3D :Cinema
    {
        private int glasses3D;
        private double priceGlasses;
        public int Glasses3D
        {
            get
            {
                return this.glasses3D;
            }
            set
            {
                
                this.glasses3D = value;
            }
        }
        public double PriceGlasses
        {
            get
            {
                return this.priceGlasses;
            }
            set
            {
                this.priceGlasses = value;
            }
        }

        public Premium3D(int glasses, double pricegls) 
        {
            Glasses3D = glasses;
            PriceGlasses = pricegls;
            Films.Add(new Movie("Fast and Furious", GlobalConstants.Tickets, 10));
            Films.Add(new Movie("Need for speed", GlobalConstants.Tickets, 9));
            Films.Add(new Movie("Жигули", GlobalConstants.Tickets, 11));  
        }
        
        public override bool HaveSeats(Movie movie, int ticketCount)
        {
            Glasses3D -= ticketCount;
            if (movie.Tickets - ticketCount < 0)
            {
                MessageBox.Show(GlobalConstants.NotEnoughTickets);
                return false;
            }
            if (ticketCount > Glasses3D)
            {
                MessageBox.Show(GlobalConstants.NotEnoughGlasses);
                return false;
            }

            return true;
        }
        
        public override double TotalPrice(Movie movie, int ticketCount)
        {
            return Math.Ceiling((movie.Price + PriceGlasses )* ticketCount);
        }

        public override void FreePlaces()
        {
            int freePlaces = 0; ;
            foreach (var film in Films)
            {
                freePlaces += film.Tickets;
            }
            if (Glasses3D < freePlaces)
            {
                MessageBox.Show("Number of free places in 3D cinema " + Glasses3D);
            }
            else
            {
                MessageBox.Show("Number of free places in 3D cinema " + freePlaces);

            }
        }
    }
}
