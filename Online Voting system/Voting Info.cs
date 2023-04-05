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
    
    public partial class Voting_Info : Form
    {
        Voting_Page vp;
        public Voting_Info(Voting_Page voting_Page)
        {
            InitializeComponent();
            //this.voting_page = voting_page;
            this.vp = voting_Page;
        }

        private void Voting_Info_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = v1.
        }
    }
}
