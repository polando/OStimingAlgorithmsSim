using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace DekkerProject
{
     public  static class Program
    {

        public static int[] numberOfResources;
        public static int[] numberOfProcesses;
        public static List<List<resource>> firstStageResourcesList = new List<List<resource>>();
        public static List<Process> processes = new List<Process>();
        private static System.Threading.Timer tick;
        private static DateTime clockStart;
        private static  FormMain fm;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            
          FormMain a =new FormMain();
            a.Show();
        }



        public static void timing()
        {
            clockStart = DateTime.Now;
            tick = new System.Threading.Timer(timerMethod, null, 1000, 1000);
            

        }

         public static void getForm(FormMain f)
         {
             fm = f;
         }

         private static void timerMethod(object state)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                if ((processes[i].EnteringTime < (DateTime.Now - clockStart).TotalSeconds) && !processes[i].alreadyStarted)
                {
                    fm.runDGV.Rows.Add("process "+i+" enetered");
                 //   Console.WriteLine("process" + i + "entered");
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
