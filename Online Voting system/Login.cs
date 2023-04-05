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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonlgin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="980581144V" && textBox2.Text == "Tek@1998")
            {
                MessageBox.Show("Login process is completed.\nWelcome to the voting panel.");
                Voting_Page voting_Page = new Voting_Page();
                voting_Page.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect !!");
            }
            
        }
    }
}
