using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace mainProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lamportBtn_Click(object sender, EventArgs e)
        {
            lamport.Program.Main();
            
        }

        private void schedualBtn_Click(object sender, EventArgs e)
        {
            scheduling.Program.Main();
        }

        private void dekkerBtn_Click(object sender, EventArgs e)
        {
            DekkerProject.Program.Main();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "this program is created By Milad Qasemi in case of issues email me cpt.m.qasemi@gmail.com");
        }


    }
}
