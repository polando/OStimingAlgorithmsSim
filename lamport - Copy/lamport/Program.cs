using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamport
{
     public static class Program
    {
        public  static  List<int> turns=new List<int>();
        public static List<bool> entered = new List<bool>();
        public static List<process> processes = new List<process>();
        public static int numberOfProcesses;
        public static System.Threading.Timer tick;
        public static DateTime clockStart;
        public static lamport lamport =new lamport();
        public static Form1 myForm;
            /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            myForm =new Form1();
            myForm.Show();   
        }

        public static void timing()
        {
            clockStart = DateTime.Now;
            tick = new System.Threading.Timer(timerMethod, null, 1000, 1000);

        }

        public static void timerMethod(object state)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                if ((processes[i].EnteringTime < (DateTime.Now - clockStart).TotalSeconds) && !processes[i].alreadyStarted)
                {
                    myForm.log.Rows.Add("process " + i + " enetered");
                    run(i);
                    processes[i].alreadyStarted = true;
                    break;

                }
            }

        }

        public static void run(int n)
        {
            processes[n].run(n);

        }
       
    }
}
