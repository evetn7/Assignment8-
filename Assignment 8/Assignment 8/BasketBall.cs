using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_8
{
    public class BasketBall : Ticket
    {
        private string awayTeam;

        // private string AwayTeam;
        public BasketBall()
            : base()
        {
            //Default Constructor
        }


        public BasketBall(string awayTeam, int quantity, double cost, string name)
            : base(quantity, cost, name)
        {
            this.awayTeam = awayTeam;
        }

        //Mutators and Accessors

        public string AwayTeam
        {
            get{return awayTeam;}
            set{ this.awayTeam = value; }

        }
        
    }
}