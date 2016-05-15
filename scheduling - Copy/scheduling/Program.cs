using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace scheduling
{
    public static class Program
    {
        public static List<process> processes = new List<process>();
        public static List<process> enteredProcesses = new List<process>();
        public static List<process> sortedProcesses = new List<process>();
        public static  List<process> RoundProcesses =new List<process>();
        public static List<process> countingList = new List<process>();
        public static float now;
        public static int numberOfProcesses;
        public static int processCounter;
        public static int timeSlice;
        public static float Tat;
        public static float Wt;
        public static int  numOfproc = 0;
        private static Form1 myform;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            now = 0;
            myform = new Form1();
            myform.Show();
        }


        public static void addprocROW()
        {
            for (int i = 0; i < numberOfProcesses; i++)
            {
                myform.procTable.Rows.Add();
            }
        }

        public static void addProcess()
        {
            for (int i = 0; i < numberOfProcesses; i++)
            {
                var row = myform.procTable.Rows[i];
                processes.Add(new process(row.Cells[0].Value.ToString(), float.Parse(row.Cells[1].Value.ToString()),
                    float.Parse(row.Cells[2].Value.ToString())));
            }
            processCounter = numberOfProcesses;
        }


        public static void display(string name, float time, bool k)
        {
            if (k)
                myform.logBox.Items.Add("process " + name + " started at" + time);
            else
            {
                myform.logBox.Items.Add("process " + name + " finished at" + time);
            }
        }

        public static void displaySecond(string name, float time, bool k)
        {
            if (k)
                myform.logBox.Items.Add("process " + name + " took cpu at" + time);
            else
            {
                myform.logBox.Items.Add("process " + name + " finished at" + time);
            }
        }


        public static void FCFS()
        {
            sortedProcesses = processes.OrderBy(o => o.enteringTime).ToList();


            while (sortedProcesses.Count != 0)
            {
                if (sortedProcesses.First().enteringTime < now)
                {
                    display(sortedProcesses.First().name, now, true);
                    now = now + sortedProcesses.First().serviceTime;
                    display(sortedProcesses.First().name, now, false);
                    sortedProcesses.First().exitTime = now;
                    countingList.Add(sortedProcesses.First());
                    sortedProcesses.RemoveAt(0);
                }
                else
                {
                    display(sortedProcesses.First().name, sortedProcesses.First().enteringTime, true);
                    now = sortedProcesses.First().enteringTime + sortedProcesses.First().serviceTime;
                    display(sortedProcesses.First().name, now, false);
                    sortedProcesses[0].exitTime = now;
                    countingList.Add(sortedProcesses.First());
                    sortedProcesses.RemoveAt(0);
                }
            }

            
        }

        public static void SJF()
        {
            bool flag = false;

            sortedProcesses = processes.OrderBy(o => o.serviceTime).ToList();


            while (processCounter != 0)
            {
                flag = false;

                sortedProcesses = sortedProcesses.OrderBy(o => o.serviceTime).ToList();


                for (int i = 0; i < sortedProcesses.Count; i++)
                {
                    if (sortedProcesses[i].enteringTime < now)
                    {
                        display(sortedProcesses[i].name, now, true);
                        //     myform.logBox.Items.Add("process " + sortedProcesses[i].name + "started at" + now);                   
                        now = now + sortedProcesses[i].serviceTime;
                        display(sortedProcesses[i].name, now, false);
                        //    myform.logBox.Items.Add("process " + sortedProcesses[i].name + "finished at" + now);                   

                        flag = true;
                        sortedProcesses[i].exitTime = now;
                        countingList.Add(sortedProcesses[i]);
                        sortedProcesses.RemoveAt(i);
                        processCounter--;
                        break;
                    }
                }

                if (!flag)
                {
                    sortedProcesses = sortedProcesses.OrderBy(o => o.enteringTime).ToList();
                    display(sortedProcesses.First().name, sortedProcesses.First().enteringTime, true);
                    //     myform.logBox.Items.Add("process " + sortedProcesses.First().name + "started at" + sortedProcesses.First().enteringTime);

                    now = sortedProcesses.First().enteringTime + sortedProcesses.First().serviceTime;

                    display(sortedProcesses.First().name, now, false);
                    //      myform.logBox.Items.Add("process " + sortedProcesses.First().name + "finished at" + now);                   
                    sortedProcesses[0].exitTime = now;
                    countingList.Add(sortedProcesses.First());
                    sortedProcesses.RemoveAt(0);
                    processCounter--;
                }
            }
        }

        public static void HRN()
        {
            bool flag = false;
      

            while (processCounter != 0)
            {
                flag = false;

                foreach (var process in sortedProcesses)
                {
                    process.calculateR();
                   
                }

                sortedProcesses = sortedProcesses.OrderByDescending(o => o.RValue).ToList();


                for (int i = 0; i < sortedProcesses.Count; i++)
                {
                    if (sortedProcesses[i].enteringTime < now)
                    {
                        display(sortedProcesses[i].name, now, true);
                        //    myform.logBox.Items.Add("process " + sortedProcesses[i].name + "started at" + now);
                        now = now + sortedProcesses[i].serviceTime;
                        display(sortedProcesses[i].name, now, false);
                        //     myform.logBox.Items.Add("process " + sortedProcesses[i].name + "finished at" + now);

                        flag = true;
                        sortedProcesses[i].exitTime = now;
                        countingList.Add(sortedProcesses[i]);
                        sortedProcesses.RemoveAt(i);
                        processCounter--;
                        break;
                    }
                }

                if (!flag)
                {
                    sortedProcesses = sortedProcesses.OrderBy(o => o.enteringTime).ToList();
                    display(sortedProcesses.First().name, sortedProcesses.First().enteringTime, true);
                    //   myform.logBox.Items.Add("process " + sortedProcesses.First().name + "started at" + sortedProcesses.First().enteringTime);

                    now = sortedProcesses.First().enteringTime + sortedProcesses.First().serviceTime;
                    display(sortedProcesses.First().name, now, false);

                    //         myform.logBox.Items.Add("process " + sortedProcesses.First().name + "finished at" + now);
                    sortedProcesses[0].exitTime = now;
                    countingList.Add(sortedProcesses.First());
                    sortedProcesses.RemoveAt(0);
                    processCounter--;
                }
            }
        }

        public static void SRT()
        {
            bool flag;
     


            if (sortedProcesses.Count > 0)
            {
                flag = false;
          


                sortedProcesses = sortedProcesses.OrderBy(o => o.remainingTime).ToList();


                for (int i = 0; i < sortedProcesses.Count; i++)
                {
                    if (sortedProcesses[i].enteringTime <= now)
                    {
                        //flag = true;
                        displaySecond(sortedProcesses[i].name, now, true);
                        //    myform.logBox.Items.Add("process " + sortedProcesses[i].name + "started at" + now);
                        foreach (var process in sortedProcesses)
                        {
                            if (now < process.enteringTime &&
                                process.enteringTime < now + sortedProcesses[i].remainingTime)
                            {
                                sortedProcesses[i].changeRemainingTime(process.enteringTime - now);
                                now = process.enteringTime;
                                SRT();
                            }
                        }
                        if (sortedProcesses.Count <= 0)
                            return;
                        now = now + sortedProcesses[i].remainingTime;
                        displaySecond(sortedProcesses[i].name, now, false);
                        sortedProcesses[i].exitTime = now;
                        countingList.Add(sortedProcesses[i]);
                        sortedProcesses.RemoveAt(i);
                        SRT();
                    }
                }

                if(sortedProcesses.Count <= 0)
                    return;
                   sortedProcesses = sortedProcesses.OrderBy(o => o.enteringTime).ToList();
                    now = sortedProcesses.First().enteringTime;
                    SRT(); 
                }
            
            }

        public static void RR()
        {
            
         

            sortedProcesses = sortedProcesses.OrderBy(o => o.serviceTime).ToList();

            while (processCounter != 0)
            {

                if (RoundProcesses.Count <= 0)
                {
                    sortedProcesses = sortedProcesses.OrderBy(o => o.enteringTime).ToList();
                    RoundProcesses.Add(sortedProcesses.First());                   
                    now += sortedProcesses.First().enteringTime;
                    sortedProcesses.RemoveAt(0);                  
                }

                while(RoundProcesses.Count!=0)
                {

                    
                    displaySecond(RoundProcesses.First().name, now, true);
                    

                    if (RoundProcesses.First().remainingTime > timeSlice)
                    {
                        now += timeSlice;
                        RoundProcesses.First().remainingTime -= timeSlice;
                        checkForNewComers();
                        RoundProcesses.Add(RoundProcesses.First());
                        RoundProcesses.RemoveAt(0);

                    }
                    else
                    {
                        now += RoundProcesses.First().remainingTime;
                        checkForNewComers();
                        displaySecond(RoundProcesses.First().name, now, false);
                        RoundProcesses.First().exitTime = now;
                        countingList.Add(RoundProcesses.First());
                        RoundProcesses.RemoveAt(0);
                        processCounter--;
                        
                    }
                }
            }
        }

        public static void checkForNewComers()
        {
            //iterate backward to modify the ls=ist while iterating
            sortedProcesses = sortedProcesses.OrderByDescending(o => o.enteringTime).ToList();
            for (int i = sortedProcesses.Count - 1; i >= 0; i--)
            {
                if (sortedProcesses[i].enteringTime <= now)
                {
                    Debug.WriteLine(sortedProcesses[i].name);
                    RoundProcesses.Add(sortedProcesses[i]);
                    sortedProcesses.RemoveAt(i);
                }
            }
        }

        public static void init()
        {
            sortedProcesses = processes.OrderBy(o => o.enteringTime).ToList();
        }

        public static void calculateTimes()
        {
            Tat = 0;
            foreach (var process in countingList)
            {
                Tat += (process.exitTime - process.enteringTime);
                Wt += ((process.exitTime - process.enteringTime) - process.serviceTime);
            }
            Tat /= numberOfProcesses;
            Wt /= numberOfProcesses;
            myform.wtLbl.Text = Wt.ToString();
            myform.tatLbl.Text = Tat.ToString();
            
        }
    }
}

