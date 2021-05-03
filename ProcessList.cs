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
    public IDictionary<string, decimal> extraData;

    public ProcessList()
    {
        this.extraData = new Dictionary<string, decimal>();
        this.extraData["avg-waiting"] = 0;
        this.extraData["preemptive"] = 0;
        this.processes = new List<Process>();
        this.processes.Add(new Process(0, 0, 5));
        this.processes.Add(new Process(1, 1, 3));
        this.processes.Add(new Process(2, 2, 1));
        this.processes.Add(new Process(3, 3, 2));
        this.processes.Add(new Process(4, 4, 3));
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
        decimal totalWaitingTime = 0;

        foreach (Process process in this.processes)
        {
            totalWaitingTime = currTime - process.arrival;
            process.start = currTime;
            currTime += process.burst;
        }

        this.extraData["avg-waiting"] = totalWaitingTime / this.processes.Count;

        Process[] processArray = this.processes.ToArray();

        Array.Sort(processArray, new ProcessComparer());

        return processArray;
    }

    public Process[] useSJF()
    {
        if (this.extraData["preemptive"] == 0)
        {
            return this.useNonPreemptiveSJF();
        }
        else
        {
            return this.usePreemptiveSJF();
        }
    }

    public Process[] usePreemptiveSJF()
    {
        List<decimal> arrival_times = new List<decimal>();
        foreach(Process p in this.processes)
        {
            arrival_times.Add(p.arrival);
        }
        arrival_times.Sort();
        List<Process> processList = this.processes.ConvertAll(p => new Process(p));
        List<Process> currentProcesses;
        List<Process> outputP = new List<Process>();
        decimal currentTime = 0;

        while(processList.Count() > 0)
        {
            currentProcesses = processList.FindAll(p => p.arrival <= currentTime);
            currentProcesses.Sort((a, b) => {
                int c1 = a.remaining.CompareTo(b.remaining);
                return c1 != 0 ? c1 : a.index.CompareTo(b.index);
            });
            Process currProcess = currentProcesses[0];
            decimal nextArrivalTime = arrival_times.Find(t => t > currentTime);
            decimal processEndTime = currProcess.remaining + currentTime;

            decimal nextStoppageTime = nextArrivalTime > 0 && nextArrivalTime < processEndTime ? nextArrivalTime : processEndTime;
            decimal roundTime = nextStoppageTime - currentTime;

            outputP.Add(new Process(currProcess.index, currentTime, roundTime));
            processList[processList.IndexOf(currProcess)].remaining -= roundTime;
            currentTime = nextStoppageTime;

            processList = processList.FindAll(p => p.remaining > 0);
        }

        return outputP.ToArray();
    }

    public Process[] useNonPreemptiveSJF()
    {
        List<Process> processList = this.processes.ConvertAll(p => new Process(p));
        processList.Sort((a, b) => {
            int c1 = a.arrival.CompareTo(b.arrival);
            return c1 != 0 ? c1 : a.burst.CompareTo(b.burst);
        });

        List<Process> output = new List<Process>();
        List<Process> current;
        decimal currentTime = 0;
        decimal averageWaitingTime = 0;
        decimal currentProcessWaitingTime;
        int counter = 0;
        while (processList.Count() > 0)
        {
            current = processList.FindAll(p => p.arrival <= currentTime);
            current.Sort((a, b) => {
                return a.burst.CompareTo(b.burst);
            });
            currentProcessWaitingTime = currentTime - current[0].arrival;
            averageWaitingTime = (averageWaitingTime * counter + currentProcessWaitingTime) / ++counter;
            currentTime += current[0].burst;
            output.Add(new Process(current[0]));
            processList[processList.IndexOf(current[0])].remaining = 0;
            processList = processList.FindAll(p => p.remaining > 0);
        }

        this.extraData["avg-waiting"] = averageWaitingTime;
        return output.ToArray();
    }

    public Process[] useRR(decimal quantumTime)
    {
        List<Process> processList = this.processes.ConvertAll(p=>new Process(p));
        processList.Sort((a, b) => {
            int c1 = a.arrival.CompareTo(b.arrival);
            return c1 != 0 ? c1 : a.index.CompareTo(b.index);
        });

        Queue<Process> processQueue = new Queue<Process>();
        decimal currTime = 0;

        Dictionary<int, decimal> finishTimes = new Dictionary<int, decimal>();

        while (processList.Count > 0)
        {
            Process firstProcess = processList[0];
            decimal roundTime = firstProcess.remaining > quantumTime ? quantumTime : firstProcess.remaining;

            processQueue.Enqueue(new Process(firstProcess.index, currTime, roundTime));
            processList[0].priority++;
            processList[0].remaining -= roundTime;
            if (processList[0].remaining <= 0)
            {
                finishTimes[processList[0].index] = currTime + roundTime;
            }
            processList[0].arrival = currTime + roundTime;
            currTime += roundTime;

            processList.Sort((a, b) => {
                int c1 = a.arrival.CompareTo(b.arrival);
                int c2 = a.priority.CompareTo(b.priority);
                int c3 = a.index.CompareTo(b.index);
                return c1 != 0 ? c1 : (c2 != 0 ? c2 : c3);
            });

            processList = processList.FindAll(p => p.remaining > 0);
        }

        Process[] processArray = processQueue.ToArray();

        this.calculateRRParameters(finishTimes);
        return processArray;
    }

    public void calculateRRParameters(Dictionary<int, decimal> finishTimes)
    {
        foreach(int key in finishTimes.Keys)
        {
            for(int i=0; i<this.processes.Count; i++)
            {
                if (this.processes[i].index == key)
                {
                    this.processes[i].end = finishTimes[key];
                }
            }
        }
        decimal averageWaitingTime = 0;
        int counter = 0;
        foreach(Process p in this.processes)
        {
            decimal currW = p.end - p.arrival - p.burst;
            averageWaitingTime = (averageWaitingTime * counter + currW) / ++counter;
        }
        this.extraData["avg-waiting"] = averageWaitingTime;
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