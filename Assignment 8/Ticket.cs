using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_8
{
    public abstract class Ticket
    {

        private int quantity;
        private double cost;
        //private DateTime date;
        //private DateTime time;

        public Ticket()
        {
            //Defualt Constructor
        }

        public int Quantity
        {
            get { return quantity; }
            set { this.quantity = quantity; }
        }
        public double Cost
        {
            get { return cost; }
            set { this.cost = cost; }
        }

        public Ticket(int quantity, double cost)
        {
            this.quantity = quantity;
            this.cost = cost;

        }

    }
}