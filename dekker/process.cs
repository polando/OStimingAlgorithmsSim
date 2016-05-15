using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;


namespace DekkerProject
{
    public class Process
    {
        public float EnteringTime { get; set; }
        public String Name { get; set; }
        public float timeConsumptionSum;
        public List<resource> neededResource = new List<resource>();
        public List<float> neededResourceTime = new List<float>();
        public int next;
        public bool alreadyStarted;

        public Process(float enteringTime, String name, List<resource> lr, List<float> tc)
        {
            Name = name;
            EnteringTime = enteringTime;
            neededResource = lr;
            neededResourceTime = tc;
            serviceTime();
            next = 0;

        }

        public void serviceTime()
        {
            timeConsumptionSum = 0f;
            foreach (var t in neededResourceTime)
            {
                timeConsumptionSum = timeConsumptionSum + t;

            }

        }



        public void goNext(int i)
        {
            next++;
            if (next < neededResource.Count)
                run(i);
        }







        public void run(int processNum)
        {
            int indexI = 0;
            int indexJ = 0;
            int min = 0;
            int minIndex = 0;
            for (indexI = 0; indexI < Program.numberOfResources.Length; indexI++)
            {
                //find the resource we need 

                if (neededResource[next] == Program.firstStageResourcesList[indexI][0])
                {

                    for (indexJ = 0; indexJ < Program.firstStageResourcesList[indexI].Count(); indexJ++)
                    {
                        //choosing the resource that got the minumem process running

                        if (min > Program.firstStageResourcesList[indexI][indexJ].numberInLine)
                        {
                            min = Program.firstStageResourcesList[indexI][indexJ].numberInLine;
                            minIndex = indexJ;
                        }


                    }

                    break;

                }
            }

            Thread thread = new Thread(() => Program.firstStageResourcesList[indexI][minIndex].dekker(processNum, Program.firstStageResourcesList[indexI][minIndex], neededResourceTime[next]));
            thread.Start();

        }








        public void displayAttributes()
        {
           
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("needed time :");
            /* foreach (float time in timeConsumption)
             {
                 Console.Write(time + " ");
             }*/
            Console.WriteLine();
            Console.WriteLine("entering time :" + EnteringTime);
            Console.WriteLine("-------");
        }
    }
}
