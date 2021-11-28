using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using КурсовПроект.GlobalConstants;

namespace Kурсов_Проект
{

    public class Cinema
    {
        public List<Movie> Films = new List<Movie>();
        public int Price { get; set; }
        
        public bool BuyTicket(Movie movie, int buyTck)
        {

            if (!HaveSeats(movie, buyTck))
                 return false;
            
                
            else
            {
                movie.Tickets -= buyTck;
                Price = movie.Price * buyTck;
                return true;
            }

        }
        
        
        public virtual bool HaveSeats(Movie movie, int bTck)
        {
            if (movie.Tickets - bTck < 0)
            {
                MessageBox.Show(GlobalConstants.NotEnoughTickets);
                return false;
            }
            return true;
        }

        public virtual double TotalPrice(Movie movie, int bTck)
        {
            return (movie.Price * bTck);
        }

        public virtual double TotalPrice(Movie movie, int bTck, double popPrice, int popNumber)
        {
            return Math.Ceiling((movie.Price * bTck + popPrice * popNumber));
        }
        
        public virtual void FreePlaces() { }
    }
}