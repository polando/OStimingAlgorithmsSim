using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DekkerProject
{
    public partial class FormAddProc : Form
    {

        private FormMain fm;

        public FormAddProc(FormMain f)
        {
            InitializeComponent();
            for (int i = 0; i < Program.numberOfResources.Length; i++)
            {
                procDV.Rows.Add(Program.firstStageResourcesList[i][0], Program.firstStageResourcesList[i][0].Name);
            }

            fm = f;

        }

        private void addProcBtn_Click(object sender, EventArgs e)
        {
            List<float> tempTime;
            List<resource> tempResources;
            string s;
            float enterTime;
      
                tempTime = new List<float>();
                tempResources = new List<resource>();
    
                s = procName.Text;
          
                enterTime = float.Parse(enteringTimeField.Text);


            

                for (int j = 0; j < Program.numberOfResources.Length; j++)
                {

                    tempTime.Add(float.Parse(procDV.Rows[j].Cells[2].Value.ToString()));
                    tempResources.Add((resource)procDV.Rows[j].Cells[0].Value);

                }

               Program.processes.Add(new Process(enterTime, s, tempResources, tempTime));

            MessageBox.Show("process created");

            fm.processDGV.Rows.Add( Program.processes.Last().Name,Program.processes.Last().timeConsumptionSum);
         
           

        }


        private void moveUp()
        {
            if (procDV.RowCount > 0)
            {
                if (procDV.SelectedRows.Count > 0)
                {
                    int rowCount = procDV.Rows.Count;
                    int index = procDV.SelectedCells[0].OwningRow.Index;

                    if (index == 0)
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = procDV.Rows;

                    DataGridViewRow prevRow = rows[index - 1];
                    rows.Remove(prevRow);
                    prevRow.Frozen = false;
                    rows.Insert(index,prevRow);
                    procDV.ClearSelection();
                    procDV.Rows[index - 1].Selected = true;
                }
            }
        }

        private void moveDown()
        {
            if (procDV.RowCount > 0)
            {
                if (procDV.SelectedRows.Count > 0)
                {
                    int rowCount = procDV.Rows.Count;
                    int index = procDV.SelectedCells[0].OwningRow.Index;

                    if (index == (rowCount-2))
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = procDV.Rows;

                    DataGridViewRow prevRow = rows[index + 1];
                    rows.Remove(prevRow);
                    prevRow.Frozen = false;
                    rows.Insert(index, prevRow);
                    procDV.ClearSelection();
                    procDV.Rows[index + 1].Selected = true;
                }
            }

        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            moveDown();
            
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            moveUp();
        }

       
       
    }
}
