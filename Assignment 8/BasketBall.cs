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
        
        
        public BasketBall(string awayTeam, int quantity, double cost)
            : base()
        {
            this.AwayTeam = AwayTeam;
        }

        //Mutators and Accessors
        
        public string AwayTeam
        {
            get
            {
                return awayTeam;
            }
            set
            {
                this.AwayTeam = AwayTeam;
            }
           
        }
        
    }
}