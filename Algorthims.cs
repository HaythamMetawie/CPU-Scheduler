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
        //private int NumOfProcesses;
        public double CalcWaitingTime(LinkedList<process> p)
        {
            process[] pp = new process[p.Count];
            p.CopyTo(pp, 0);
            double waiting = 0;
            double[] wait = new double[p.Count];
            wait[0] = 0;
            for (int i = 1; i < p.Count; i++)
            {
                wait[i] = pp[i - 1].getBurst() - pp[i].getArrival();
                waiting += wait [i];
            }
            return (waiting/p.Count);
        }
        public double FCFS(List<process> p)
        {
            LinkedList<process> sorted_processes = new LinkedList<process>();
            List<process> SortedList = p.OrderBy(a => a.getArrival()).ToList();
            foreach (var item in SortedList) //copying arranged list in linked list
            {
                sorted_processes.AddLast(item);
            }
          return waitingtime = CalcWaitingTime(sorted_processes);

        }
            /*double[] Burst = new double[NumOfProcesses];
            process[] p = new process[NumOfProcesses];
            double[] Arrival = new double[NumOfProcesses];
            Console.WriteLine("Enter Number of Processes:");
            NumOfProcesses = Console.Read();*/
           /* for (int i = 0; i < NumOfProcesses; i++)
            {
                Console.WriteLine("Enter Arrival Time of Process", i + 1, ":");
                Arrival[i] = Console.Read();
                Console.WriteLine("Enter Burst Time of Process", i + 1, ":");
                Burst[i] = Console.Read();
                p[i] = new process(Burst[i], Arrival[i]);
            }*/
        
        
       /* public double find_minimum(double[] a, int n)
        {
            double minimum = a[0]; int index = 0;
            for (int i = 1; i < n; i++)
            {
                if (minimum > a[i]) { index = i;  minimum = a[i]; }
            }
            return minimum = a[index];
        } */
      
        

    };
}
