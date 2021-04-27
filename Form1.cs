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
            processList.selectedProcessIndex = processList.processes.IndexOf(p);
            processIndexLabel.Text = processList.getSelectedProcess().index.ToString();
            arrivalTimeBox.Text = p.arrival.ToString();
            burstTimeBox.Text = p.burst.ToString();
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
            numberOfProcessesText.Text = processList.processes.Count.ToString();

            Process[] processArray;
            switch (mainTabs.SelectedTab.Name)
            {
                case "fcfs":
                    processArray = processList.useFCFS();
                    break;
                case "sjf":
                    processArray = processList.useFCFS();
                    break;
                case "pr":
                    processArray = processList.useFCFS();
                    break;
                case "rr":
                    processArray = processList.useFCFS();
                    break;
                default:
                    processArray = processList.useFCFS();
                    break;
            }
            clearProcessContainer();
            foreach(Process p in processArray)
            {
                renderProcess(p);
            }
        }

        private void addNewProcessBtn_Click(object sender, EventArgs e)
        {
            Process addedProcess = processList.Add(0, 2);
            processList.selectedProcessIndex = processList.processes.IndexOf(addedProcess);
            updateUI();
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            Process selectedProcess = processList.getSelectedProcess();
            bool tA = Decimal.TryParse(arrivalTimeBox.Text, out selectedProcess.arrival);
            bool tB = Decimal.TryParse(burstTimeBox.Text, out selectedProcess.burst);
            if (tA && tB)
            {
                updateUI();
            } else {
                MessageBox.Show("Arrival and Burst Time must be decimal values", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
