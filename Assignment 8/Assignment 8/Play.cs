using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_8
{
    public class Play : Ticket
    {
        private string rjPlay;

        // private string AwayTeam;
        public Play()
            : base()
        {
            //Default Constructor
        }


        public Play(string rjPlay, int quantity, double cost, string name)
            : base(quantity, cost, name)
        {
            this.rjPlay = rjPlay;
        }

        //Mutators and Accessors

        public string RjPlay
        {
            get { return rjPlay; }
            set { this.rjPlay = value; }

        }
    }
}