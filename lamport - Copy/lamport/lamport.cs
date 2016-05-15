using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lamport
{
    public  class lamport
    {
        public void lam(int pid,float time) // thread ID
        {
            Program.entered[pid] = true;
            int max = 0;
            //  for (int n : ticket) { if (n > max) { max = n; } } // find max in the array
            max = Program.turns.Max();
            Program.turns[pid] = 1 + max;
            Program.entered[pid] = false;
            for (int i = 0; i < Program.turns.Count; ++i)
            {
                if (i != pid)
                {
                    while (Program.entered[i])
                    {
                        Thread.Yield();
                    } // wait while other thread picks a ticket
                    while (Program.turns[i] != 0 &&
                           (Program.turns[pid] > Program.turns[i] || (Program.turns[pid] == Program.turns[i] && pid > i)))
                    {
                        Thread.Yield();
                    }
                }
            }
            
            Program.myForm.log.Rows.Add("process " + /*Program.processes[i].Name*/pid + " entered crtical section of "  + DateTime.Now.ToString("h:mm:ss tt"));
//Console.WriteLine("process " + pid + " entered crtical section of " + " in " + DateTime.Now.ToString("h:mm:ss tt"));

            Thread.Sleep((int)time * 1000);
            Program.myForm.log.Rows.Add("process " + /*Program.processes[i].Name*/pid + " left crtical section of " + DateTime.Now.ToString("h:mm:ss tt"));
   //         Console.WriteLine("process " + pid + " left crtical section of " + DateTime.Now.ToString("h:mm:ss tt"));
           
            Program.turns[pid] = 0;
        }


      
    }
}
