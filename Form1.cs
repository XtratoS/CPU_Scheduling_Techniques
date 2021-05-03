using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Sheduler_Take_2
{
    public partial class Form1 : Form
    {
        public static int PROCESS_WIDTH_PIXELS = 40;
        ProcessList processList = new ProcessList();
        public Form1()
        {
            InitializeComponent();
            updateUI();
        }

        public void renderProcess(Process process)
        {
            System.Windows.Forms.Button newBtn = new System.Windows.Forms.Button();
            newBtn.Height = 70;
            newBtn.Width = Convert.ToInt32(process.burst * PROCESS_WIDTH_PIXELS);
            newBtn.Margin = new System.Windows.Forms.Padding(0);
            newBtn.Text = process.name;
            newBtn.BackColor = Color.DarkOrange;
            newBtn.Click += (sender, e) => { processBtnClickHandler(sender, e, process, newBtn); };

            System.Windows.Forms.Control processContainer = this.Controls.Find("processContainer", true)[0];
            processContainer.Controls.Add(newBtn);
            
            if (newBtn.Location.X / PROCESS_WIDTH_PIXELS < process.arrival)
            {
                newBtn.Margin = new Padding(Convert.ToInt32(process.arrival * PROCESS_WIDTH_PIXELS - newBtn.Location.X), 0, 0, 0);
            }
        }

        public void processBtnClickHandler(
            object sender,
            System.EventArgs e,
            Process p,
            System.Windows.Forms.Button b
        )
        {
            deleteProcessBtn.Enabled = true;
            saveChangesBtn.Enabled = true;
            arrivalTimeBox.Enabled = true;
            burstTimeBox.Enabled = true;
            processList.selectedProcessIndex = p.index;
            processIndexLabel.Text = processList.getSelectedProcess().index.ToString();
            arrivalTimeBox.Text = processList.getSelectedProcess().arrival.ToString();
            burstTimeBox.Text = processList.getSelectedProcess().burst.ToString();
        }

        public void clearProcessContainer()
        {
            this.Controls.Find("processContainer", true)[0].Controls.Clear();
        }

        public void updateUI()
        {
            if (processList.processes.Count == 0)
            {
                deleteProcessBtn.Enabled = false;
                saveChangesBtn.Enabled = false;
                arrivalTimeBox.Enabled = false;
                burstTimeBox.Enabled = false;
            } else
            {
                deleteProcessBtn.Enabled = true;
                saveChangesBtn.Enabled = true;
                arrivalTimeBox.Enabled = true;
                burstTimeBox.Enabled = true;
                Process selectedProcess = processList.getSelectedProcess();
                processIndexLabel.Text = selectedProcess.index.ToString();
                arrivalTimeBox.Text = selectedProcess.arrival.ToString();
                burstTimeBox.Text = selectedProcess.burst.ToString();
            }
            numberOfProcesses.Text = processList.processes.Count.ToString();

            Process[] processArray;
            switch (mainTabs.SelectedTab.Name)
            {
                case "fcfs":
                    processArray = processList.useFCFS();
                    break;
                case "sjf":
                    processArray = processList.useSJF();
                    break;
                case "pr":
                    processArray = processList.useFCFS();
                    break;
                case "rr":
                    processArray = processList.useRR(Decimal.Parse(quantumTimeBox.Text));
                    break;
                default:
                    processArray = processList.useFCFS();
                    break;
            }
            clearProcessContainer();
            foreach (Process p in processArray)
            {
                renderProcess(p);
            }
            waitingTime.Text = Math.Round(processList.extraData["avg-waiting"], 2).ToString("G29");
        }

        private void addNewProcessBtn_Click(object sender, EventArgs e)
        {
            Process addedProcess = processList.Add(new Process(0, 0, 2));
            processList.selectedProcessIndex = processList.processes.IndexOf(addedProcess);
            updateUI();
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            Process selectedProcess = processList.getSelectedProcess();
            bool tA = Decimal.TryParse(arrivalTimeBox.Text, out selectedProcess.arrival);
            bool tB = Decimal.TryParse(burstTimeBox.Text, out selectedProcess.burst);
            if (tA && tB && selectedProcess.arrival >= 0 && selectedProcess.burst > 0)
            {
                updateUI();
            } else {
                MessageBox.Show("Something went wrong, make sure that arrival time >= 0 and burst time > 0", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            processList.processes[
                processList.processes.IndexOf(
                    processList.getSelectedProcess()
                )
            ] = new Process(
                selectedProcess.index,
                selectedProcess.arrival,
                selectedProcess.burst
            );
        }

        private void deleteProcessBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are about to delete " + processList.getSelectedProcess(), "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                processList.removeSelectedProcess();
                updateUI();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainTabs.MouseClick += (sender2, e2) =>
            {
                infoBox1.Parent = mainTabs.TabPages[mainTabs.SelectedIndex];
                addNewProcessBtn.Parent = mainTabs.TabPages[mainTabs.SelectedIndex];
                modifyProcessGroup.Parent = mainTabs.TabPages[mainTabs.SelectedIndex];
                updateUI();
            };
        }

        private void quantumTimeBox_TextChanged(object sender, EventArgs e)
        {
            quantumTimeConfirmBtn.Enabled = true;
        }

        private void quantumTimeConfirmBtn_Click(object sender, EventArgs e)
        {
            decimal quantumTime;
            if (Decimal.TryParse(quantumTimeBox.Text, out quantumTime) == false || quantumTime <= 0)
            {
                MessageBox.Show("Quantum Time must be a positive decimal value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                updateUI();
                quantumTimeConfirmBtn.Enabled = false;
            }
        }

        private void preemptive_CheckedChanged(object sender, EventArgs e)
        {
            processList.extraData["preemptive"] = preemptive.Checked ? 1 : 0;
            updateUI();
        }
    }
}
