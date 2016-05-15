using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lamport
{
    public class process
    {
        public bool alreadyStarted;

        public process(string name,float entering,float service )
        {
            Name = name;
            EnteringTime = entering;
            timeNeeded = service;
            alreadyStarted = false;
        }
        public float EnteringTime { get; set; }
        public string Name { get; set; }
        public float timeNeeded { get; set; }

        public void run(int processNum)
        {
            Thread thread = new Thread(() => Program.lamport.lam(processNum, timeNeeded));
            thread.Start();
        }

    }
}
