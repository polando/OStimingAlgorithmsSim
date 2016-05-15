using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace DekkerProject
{
    public class resource
    {

        public Boolean[] terminate = new Boolean[50];
        public int turn;
        public int[] locks = new int[50];
        public int numberInLine;
        private FormMain Fm;


        public int Type { get; set; }
        public string Name { get; set; }




        public resource(int type, string name,FormMain fm)
        {
            Array.Clear(locks,0,locks.Length);
            Type = type;
            Name = name;
            Fm = fm;

            for (int i = 0; i < terminate.Length; i++)
            {
                terminate[i] = true;
            }
            numberInLine = 0;

        }




        public bool check(int i)
        {

            for (int j = 0; j < locks.Length; j++)
                if (locks[j] == 1 && j != i)
                    return true;
            return false;

        }


        public void dekker(int i, resource res, float time)
        {
            numberInLine++;
            terminate[i] = false;
            locks[i] = 1;
            turn = i;

            while (check(i))
            {

                locks[i] = 0;
                while (turn != i)
                {
                 
                    Fm.runDGV.Rows.Add("Process "+ i +" Is in BusyWait");
                    Thread.Sleep(1000);
                }//do nothing

                locks[i] = 1;

            }



            Fm.runDGV.Rows.Add("process " + /*Program.processes[i].Name*/i + " entered crtical section of " + res.Name + " in " + DateTime.Now.ToString("h:mm:ss tt"));
            Console.WriteLine("process " + i + " entered crtical section of " + res.Name + " in " + DateTime.Now.ToString("h:mm:ss tt"));

            Thread.Sleep((int)time * 1000);
            Fm.runDGV.Rows.Add("process " + /*Program.processes[i].Name*/i + " left crtical section of " + res.Name + " in " + DateTime.Now.ToString("h:mm:ss tt"));
            Console.WriteLine("process " + i + " left crtical section of " + res.Name + " in " + DateTime.Now.ToString("h:mm:ss tt"));


            locks[i] = 0;

            for (int f = 0; f < 10; f++)
            {
                if ((terminate[f] == false) && (f != i))
                {
                    turn = f;
                    break;

                }

            }
            terminate[i] = true;
            Program.processes[i].goNext(i);
            numberInLine--;

        }

        public void displayAttributes()
        {
            Console.WriteLine("name : " + Name);
            Console.WriteLine("Type : " + Type);
        }

    }
}
