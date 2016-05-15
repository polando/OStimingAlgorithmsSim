using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduling
{
    public class process
    {
        public float enteringTime { get; set; }
        public float serviceTime { get; set; }
        public string name { get; set; }
        public float remainingTime { get; set; }
        public float exitTime { get; set; }
        public float RValue { get; set; }
  
        public process(string Name,float EnteringTime,float ServiceTime) 
        {
            remainingTime = ServiceTime;
            name = Name;
            enteringTime = EnteringTime;
            serviceTime = ServiceTime;
        }

        public void calculateR()
        {
            RValue = ((Program.now - this.enteringTime) + serviceTime)/serviceTime;
        }

        public void changeRemainingTime(float changeValue)
        {
            remainingTime = remainingTime - changeValue;
        }
    }
}
