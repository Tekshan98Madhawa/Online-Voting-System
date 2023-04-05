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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String nic = textBoxNic.Text;
            String password = textBoxPass.Text;
            String confirmPassword = textBoxCpass.Text;

            if (password == confirmPassword)
            {

                Formfrnt formfrnt = new Formfrnt();
                formfrnt.Show();
                this.Hide();
                MessageBox.Show("Registration was successfully completed !!");
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }

        }
    }
}
