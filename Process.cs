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

    public Process(int index, decimal arrival, decimal burst)
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