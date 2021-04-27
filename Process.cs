using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Process
{
    public int index;
    public string name;
    public int arrival;
    public int start;
    public int burst;

    public Process(int index, int arrival, int burst)
    {
        this.index = index;
        this.name = "Process " + index.ToString();
        this.arrival = arrival;
        this.burst = burst;
    }

    override public string ToString()
    {
        return this.name;
    }
}