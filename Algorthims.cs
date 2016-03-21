using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms 
{
    class Algorithms
    {
        private float waitingtime, turnaround;
        private int NumOfProcesses;
        public float getWaitingtime()
        {
            return waitingtime;
        }
        public float Waitingtime(float turnaround, int burst)
        {
            return waitingtime = (turnaround - burst) / NumOfProcesses;
        }
        public void FCFS()
        {
            LinkedList<process> Processes = new LinkedList<process>();
            process [] p = new process[NumOfProcesses];
            int[] Burst = new int[NumOfProcesses];
            float[] Arrival = new float[NumOfProcesses];
            Console.WriteLine("Enter Number of Processes:");
            NumOfProcesses = Console.Read();
            for (int i = 0; i < NumOfProcesses; i++)
            {
                Console.WriteLine("Enter Arrival Time of Process", i + 1, ":");
                Arrival[i] = Console.Read();
                Console.WriteLine("Enter Burst Time of Process", i+1,":");
                Burst [i]  = Console.Read();
                p[i] = new process(Burst[i], Arrival[i]);
            }
            for (int i = 0; i < NumOfProcesses; i++) //sorting processes according to arrival time (need to be checked)
            {
                if (Arrival[i] < Arrival[i + 1])
                { Processes.AddFirst(p[i]);}
            }


        }

    };
}
