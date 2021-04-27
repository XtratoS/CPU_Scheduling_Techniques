using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;

class ProcessList
{
    public List<Process> processes;
    public int processIndex;
    public int selectedProcessIndex;

    public ProcessList()
    {
        this.processes = new List<Process>();
        this.processIndex = 0;
    }

    public void removeSelectedProcess()
    {
        this.processes.RemoveAt(this.selectedProcessIndex);
        this.selectedProcessIndex = 0;
    }
    public Process getSelectedProcess()
    {
        return this.processes[this.selectedProcessIndex];
    }

    public Process Add(int arrival, int burst)
    {
        Process process = new Process(this.processIndex++, arrival, burst);
        this.processes.Add(process);
        return process;
    }

    public Process Add(Process p)
    {
        Process x = new Process(this.processIndex++, p.arrival, p.burst);
        this.processes.Add(x);
        return x;
    }

    public Process getAt(int index)
    {
        return index >= 0 ? this.processes[index] : null;
    }

    public int toComparisonValue(int v)
    {
        return v > 0 ? 1 : (v < 0 ? -1 : 0);
    }

    class ProcessComparer : IComparer<Process>
    {
        public int Compare(Process x, Process y)
        {
            if (x.arrival < y.arrival) return -1;
            else if (x.arrival > y.arrival) return 1;
            else return int.Parse(Regex.Replace(x.name, "[^0-9]", "")) -
                    int.Parse(Regex.Replace(y.name, "[^0-9]", ""));
        }
    }
    public Process[] useFCFS()
    {
        decimal currTime = 0;

        foreach (Process process in this.processes)
        {
            process.start = currTime;
            currTime += process.burst;
        }

        Process[] processArray = this.processes.ToArray();

        Array.Sort(processArray, new ProcessComparer());

        return processArray;
    }

    public Process[] useRR(decimal quantumTime)
    {
        List<Process> processList = this.processes.ConvertAll(p=>new Process(p));
        decimal currTime = 0;
        List<Process> currentProcesses = new List<Process>();
        while (processList.Count > 0)
        {
            for (int i = 0; i < processList.Count; i++)
            {
                Process p = processList[i];
                if (p.arrival <= currTime)
                {
                    decimal processBurstTime = p.remaining >= quantumTime ? quantumTime : p.remaining;
                    processList[i].remaining -= processBurstTime;
                    currentProcesses.Add(
                        new Process(p.index, currTime, processBurstTime)
                    );
                    currTime += processBurstTime;
                }
            }
            //foreach (Process p in processList){Console.WriteLine("{0} {1} {2}", p.index, p.name, p.remaining);}
            processList = processList.FindAll(p => p.remaining > 0);
        }

        Process[] processArray = currentProcesses.ToArray();
        Array.Sort(processArray, new ProcessComparer());

        return processArray;
    }

    override public string ToString()
    {
        string outString = "";
        foreach (Process p in this.processes)
        {
            outString += p.ToString() + '\n';
        }
        return outString;
    }
}