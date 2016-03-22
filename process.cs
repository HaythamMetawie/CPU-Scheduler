using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class process
{
    private string name;
    private int priority;
    private double burst, arrivaltime, departure;
    //private void* prev, next;

    public void setBurst(double b)
    {
        burst = b;
    }
    public void setPriority(int p)
    {
        priority = p;
    }
    public void setArrival(double a)
    {
        arrivaltime = a;
    }
    public void setName(string n)
    {
        name = n;
    }
    /*public unsafe void setPrev(void* pr)
    {
        prev = pr;
    }
    public unsafe void setNext(void* n)
    {
        next = n;
    }*/
    public double getBurst()
    {
        return burst;
    }
    public int getPriority()
    {
        return priority;
    }
    public double getArrival()
    {
        return arrivaltime;
    }
    public string getName()
    {
        return name;
    }
   /* public unsafe void* getPrev()
    {
        return prev;
    }
    public unsafe void* getNext()
    {
        return next;
    }*/
    public process(string n, double b, double a)
    {
        name = n;
        burst = b;
        arrivaltime = a;
        priority = 0;
        departure = 0;
    }
    public process(string n, double b, double a, int p)
    {
        name = n;
        burst = b;
        arrivaltime = a;
        priority = p;
        departure = 0;
    }

};
