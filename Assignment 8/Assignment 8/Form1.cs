using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8
{
    public partial class OnCampusTickets : Form
    {
        //string userInput;
        

        public OnCampusTickets()
        {
            InitializeComponent();
            
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            //Do nothing
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //Do nothing
        }

        private void musicalButton_Click(object sender, EventArgs e)
        {


            txtChosenEvent.Text = "Wicked";

        }
        

        private void txtcustomerName_TextChanged(object sender, EventArgs e)
        {

            //Do nothing

        }

        private void txtChosenEvent_TextChanged(object sender, EventArgs e)
        {
            //Do nothing
        }

        private void basketButton_Click(object sender, EventArgs e)
        {

            txtChosenEvent.Text = "Home Basketball Game";
           

        }

        private void playbutton_Click(object sender, EventArgs e)
        {


            txtChosenEvent.Text = "Romeo & Juliet Play";
            


        }

        private void CostLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Produces Cost for Musical
            if (txtChosenEvent.Text == "Wicked" && txtQuantity.Text != null)
            {
            
                Musicals wickedMusical = new Musicals(txtChosenEvent.Text, Convert.ToInt32(txtQuantity.Text), 10.00, txtcustomerName.Text);
                MessageBox.Show("Congrats " + wickedMusical.Name + "!\nYou bought " + wickedMusical.Quantity + " Ticket(s) for " + wickedMusical.MusicalName + "!\n\nTotalCost: $" + wickedMusical.FinalCost);
              
            }
            //Produces Cost for Play
            else if (txtChosenEvent.Text == "Romeo & Juliet Play")
            {
                Play Romeo = new Play(txtChosenEvent.Text, Convert.ToInt32(txtQuantity.Text), 12.00, txtcustomerName.Text);
                MessageBox.Show("Congrats " + Romeo.Name + "!\nYou bought " + Romeo.Quantity + " Ticket(s) for " + Romeo.RjPlay + "!\n\nTotalCost: $" + Romeo.FinalCost);
            }
            else if (txtChosenEvent.Text == "Home Basketball Game")
            {
                BasketBall HomeTeam = new BasketBall(txtChosenEvent.Text, Convert.ToInt32(txtQuantity.Text), 7.00, txtcustomerName.Text);
                MessageBox.Show("Congrats " + HomeTeam.Name + "!\nYou bought " + HomeTeam.Quantity + " Ticket(s) for " + HomeTeam.AwayTeam + "!\n\nTotalCost: $" + HomeTeam.FinalCost);
            }
            else
            {
                //Error Message
                MessageBox.Show("Error!\nPlease re-enter purchase information.");
            }
        }
    }
}
