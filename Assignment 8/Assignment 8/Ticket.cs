using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_8
{
    public abstract class Ticket
    {

        private int quantity;
        private double costPerTicket;
        //added string for Customer Name & Final Cost
        private string name;
        private double finalCost;
        //private DateTime date;
        //private DateTime time;

        public Ticket()
        {
            //Defualt Constructor
        }

        //Moved Overloaded Constructor & added string variable name in list of arguments & Change cost to costPerTicket
        public Ticket(int quantity, double costPerTicket, string name)
        {
            this.quantity = quantity;
            this.costPerTicket = costPerTicket;
            this.name = name;
            finalCost = costPerTicket * quantity;
        }


        //For properties changed Set statements to equal "value" in order to make it work & added Name and FinalCost Properties & changed Cost to CostPerTicket
        public int Quantity
        {
            get { return quantity; }
            set { this.quantity = value; }
        }
        public double CostPerTicket
        {
            get { return costPerTicket; }
            set { this.costPerTicket = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public double FinalCost
        {
            get { return finalCost; }
            set { this.finalCost = value; }
        }

    }
}