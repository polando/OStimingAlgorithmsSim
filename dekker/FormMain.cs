using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace DekkerProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            DataGridView.CheckForIllegalCrossThreadCalls = false;

        }

        

        private void resourceCreate_Click(object sender, EventArgs e)
        {
            Program.numberOfResources = new int[Convert.ToInt32(numericUpDown1.Text)];

            for (int i = 0; i < Program.numberOfResources.Length; i++)
            {
                
                dvResource.Rows.Add("R" + i);
                
            }

            MessageBox.Show("resources Created");

            inf.Enabled = true;
            saveRes.Enabled = true;
        }

       

        private void saveRes_Click(object sender, EventArgs e)
        {
            bool res=true;

         /*   foreach (DataGridViewRow r in dvResource.Rows)
            {

                for (int j = 0; j < r.Cells.Count; j++)
                {
                    if (r.Cells[j].Value == null || r.Cells[j].Value == DBNull.Value ||
                        String.IsNullOrWhiteSpace(r.Cells[j].Value.ToString()))
                    {
                        res = false;
                    }


                }
            }*/

            if (dvResource.Rows[0].Cells[1].Value!=null)
                save();

            else
            {

                MessageBox.Show("All amount values must be filled");
            }



        }


        private void save()
        {
            for (int i = 0; i < Program.numberOfResources.Length; i++)
            {
                Program.firstStageResourcesList.Add(new List<resource>());

                Program.numberOfResources[i] = Convert.ToInt32(dvResource.Rows[i].Cells[1].Value.ToString());
                Console.WriteLine("res" + Program.numberOfResources[i]);

                for (int j = 0; j < Program.numberOfResources[i]; j++)
                {
                    Console.WriteLine("createResourceFrom Type " + i);

                    Program.firstStageResourcesList[i].Add(new resource(i, "R" + i + j, this));

                }

            }
            addProcessBtn.Enabled = true;
            MessageBox.Show("amounts Saved");
        }

        private void addProcessBtn_Click(object sender, EventArgs e)
        {   
     
            FormAddProc fap=new FormAddProc(this);
            fap.ShowDialog();
           
        }


        private void fillgrid(object sender, EventArgs e)
        {
            fillProcessGrid();
        }

        public void fillProcessGrid()
        {
            if (Program.numberOfProcesses != null)
            {
                foreach (var process in Program.processes)
                {
                    processDGV.Rows.Add(process.Name, process.timeConsumptionSum);
                }
            }

        }

        private void runBtn_Click(object sender, EventArgs e)
        {
          //  runLabel.Show();
            MessageBox.Show("started");
            Thread.Sleep(300);
            Program.getForm(this);
            Program.timing();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "this app is created By Milad Qasemi , in case you found issues or need help feel free to contact me , cpt.m.qasemi@gmail.com  ");
        }

      

       

        

      

    }
}
