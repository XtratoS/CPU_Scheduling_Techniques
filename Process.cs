using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Process
{
    public int index;
    public string name;
    public decimal arrival;
    public decimal start;
    public decimal burst;
    public decimal remaining;
    public int priority;
    public decimal end;

    public Process(int index, decimal arrival, decimal burst)
    {
        this.index = index;
        this.name = "Process " + index.ToString();
        this.arrival = arrival;
        this.burst = burst;
        this.remaining = burst;
        this.priority = 1;
    }

    public Process(int index, decimal arrival, decimal burst, decimal remaining)
    {
        this.index = index;
        this.name = "Process " + index.ToString();
        this.arrival = arrival;
        this.burst = burst;
        this.remaining = remaining;
    }

    public Process(Process another)
    {
        this.index = another.index;
        this.name = another.name;
        this.arrival = another.arrival;
        this.start = another.start;
        this.burst = another.burst;
        this.remaining = another.remaining;
        this.priority = another.priority;
        this.end = another.end;
    }

    override public string ToString()
    {
        return this.name;
    }
}