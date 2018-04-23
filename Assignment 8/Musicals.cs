using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_8
{
    public class Musicals : Ticket
    {
        string musicalName;
       // string theaterLocation;

        public Musicals()
            : base()
        {
            //Default Constructor
        }

        public Musicals(string musicalName, int quantity, double cost)
            : base(quantity, cost)
        {
            this.musicalName = musicalName;
         
        }

        public string MusicalName
        {
            get { return musicalName; }
            set { this.musicalName = "Wicked"; } 
        }
      
    }
    
}