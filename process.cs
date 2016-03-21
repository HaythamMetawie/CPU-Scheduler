using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class process
{

    private int burst, priority;
    private float arrivaltime, departure;
    private void* prev, next;

    public void setBurst(int b)
    {
        burst = b;
    }
    public void setPriority(int p)
    {
        priority = p;
    }
    public void setArrival(int a)
    {
        arrivaltime = a;
    }
    public unsafe void setPrev(void* pr)
    {
        prev = pr;
    }
    public unsafe void setNext(void* n)
    {
        next = n;
    }
    public int getBurst()
    {
        return burst;
    }
    public int getPriority()
    {
        return priority;
    }
    public float getArrival()
    {
        return arrivaltime;
    }
    public unsafe void* getPrev()
    {
        return prev;
    }
    public unsafe void* getNext()
    {
        return next;
    }
    public process(int b, float a)
    {
        burst = b;
        arrivaltime = a;
        priority = 0;
        departure = 0;
    }
    public process(int b, float a, int p)
    {
        burst = b;
        arrivaltime = a;
        priority = p;
        departure = 0;
        //setting values of pointers

    }

};
