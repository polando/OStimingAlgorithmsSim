using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int algorithm;

        private void start_Click(object sender, EventArgs e)
        {
            Program.addProcess();
            Program.init();
            if(algorithm==0)
                Program.SJF();
            else if(algorithm==1)
                Program.FCFS();
            else if(algorithm==2)
                Program.HRN();
            else if (algorithm == 3)
                Program.SRT();
            else if(algorithm==4)
            {
                Program.RR();
            }
            else
            {
                MessageBox.Show("an algorithm must be selected");
            }

            
            Program.calculateTimes();
            
        }

        private void addProcessBtn_Click(object sender, EventArgs e)
        {
            Program.numberOfProcesses = Convert.ToInt32(addProcessBox.Text);
            Program.addprocROW();
        }

        private void SJFBtn_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = 0;
        }

        private void FCFCBtn_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = 1;
        }

        private void HRNBtn_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = 2;
        }

        private void SRTBtn_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = 3;
        }

        private void RRBtn_CheckedChanged(object sender, EventArgs e)
        {
           
            timeSliceBTn.Enabled=true;

            algorithm = 4;

        }

        private void timeSliceBTn_Click(object sender, EventArgs e)
        {
            Program.timeSlice = Convert.ToInt32(TStxt.Text);
        }
          
     

    }
}
