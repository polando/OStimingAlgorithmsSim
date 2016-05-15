using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Program.numberOfProcesses=Convert.ToInt32(nOftext.Text);
            for (int i = 0; i <Program.numberOfProcesses;  i++)
            {
                DGV.Rows.Add("P" + i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.numberOfProcesses; i++)
            {
                Program.processes.Add(new process(DGV.Rows[i].Cells[0].Value.ToString(), float.Parse(DGV.Rows[i].Cells[1].Value.ToString()), float.Parse(DGV.Rows[i].Cells[2].Value.ToString())));
                Program.entered.Add(false);
                Program.turns.Add(0);
            }
            Thread.Sleep(300);
            Program.timing();
        }

    }
}
