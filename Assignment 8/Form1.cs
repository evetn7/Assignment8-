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
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void musicalButton_Click(object sender, EventArgs e)
        {


            Musicals mName = new Musicals();
            CostLabel.Text = mName.Name;
            txtChosenEvent.Text = mName.MusicalName;
            
        }
        

        private void txtcustomerName_TextChanged(object sender, EventArgs e)
        {

           

        }

        private void txtChosenEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void basketButton_Click(object sender, EventArgs e)
        {
           
                txtChosenEvent.Text = String.Format("Basketball").ToString();

            

        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            

                txtChosenEvent.Text = String.Format("Romeo & Juliet Play").ToString();

            
        }

        private void CostLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
