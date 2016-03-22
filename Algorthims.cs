using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms 
{
    class Algorithms
    {
        private double waitingtime, turnaround;
        private int NumOfProcesses;
        public double getWaitingtime()
        {
            return waitingtime;
        }
        public void FCFS()
        {
            LinkedList<process> processes = new LinkedList<process>();
            LinkedList<process> sorted_processes = new LinkedList<process>();
            double[] Burst = new double[NumOfProcesses];
            process[] p = new process[NumOfProcesses];
            double[] Arrival = new double[NumOfProcesses];
            Console.WriteLine("Enter Number of Processes:");
            NumOfProcesses = Console.Read();
            for (int i = 0; i < NumOfProcesses; i++)
            {
                Console.WriteLine("Enter Arrival Time of Process", i + 1, ":");
                Arrival[i] = Console.Read();
                Console.WriteLine("Enter Burst Time of Process", i + 1, ":");
                Burst[i] = Console.Read();
                p[i] = new process(Burst[i], Arrival[i]);
            }
        }
        
        public double find_minimum(double[] a, int n)
        {
            double minimum = a[0]; int index = 0;
            for (int i = 1; i < n; i++)
            {
                if (minimum > a[i]) { index = i;  minimum = a[i]; }
            }
            return minimum = a[index];
        } 
       /* public void sort(int n) // sorting linked list according to arrival time and put it in new one.
        {

            public void sort (int n-1) { 
                        find_minimum(Arrival[],NumOfProcesses); 
                        processes.
        }

        }*/
        

    };
}
