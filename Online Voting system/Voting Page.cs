using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Voting_system
{
    public partial class Voting_Page : Form
    {
        public Voting_Page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Voting_Info vi = new Voting_Info(this);
            vi.ShowDialog();


                /*if (radioButtonYes.Checked == true)
                {
                    MessageBox.Show("Your voting has been recorded .\nThank you for joining with us .");
                }
                else if (radioButtonNo.Checked == true)
                {
                    MessageBox.Show("Your voting can not be recorded right now. \nPlease check your selections.");
                }*/
               
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
