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

        //Pass through a string variable, "name" to the base class
        public Musicals(string musicalName, int quantity, double cost, string name)
            : base(quantity, cost, name)
        {
            this.musicalName = musicalName;
        }

        //Adjusted Setter in Property to equal value so it'll work.
        public string MusicalName
        {
            get { return musicalName; }
            set { this.musicalName = value; }
        }

    }
    
}