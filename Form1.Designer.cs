
namespace CPU_Sheduler_Take_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.fcfs = new System.Windows.Forms.TabPage();
            this.infoBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.waitingTime = new System.Windows.Forms.TextBox();
            this.numberOfProcesses = new System.Windows.Forms.TextBox();
            this.modifyProcessGroup = new System.Windows.Forms.GroupBox();
            this.burstTimeBox = new System.Windows.Forms.TextBox();
            this.arrivalTimeBox = new System.Windows.Forms.TextBox();
            this.deleteProcessBtn = new System.Windows.Forms.Button();
            this.processIndexLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewProcessBtn = new System.Windows.Forms.Button();
            this.sjf = new System.Windows.Forms.TabPage();
            this.preemption = new System.Windows.Forms.GroupBox();
            this.preemptive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pr = new System.Windows.Forms.TabPage();
            this.rr = new System.Windows.Forms.TabPage();
            this.RRModBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantumTimeConfirmBtn = new System.Windows.Forms.Button();
            this.quantumTimeBox = new System.Windows.Forms.TextBox();
            this.processContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.priority = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.NumericUpDown();
            this.mainTabs.SuspendLayout();
            this.fcfs.SuspendLayout();
            this.infoBox1.SuspendLayout();
            this.modifyProcessGroup.SuspendLayout();
            this.sjf.SuspendLayout();
            this.preemption.SuspendLayout();
            this.pr.SuspendLayout();
            this.rr.SuspendLayout();
            this.RRModBox.SuspendLayout();
            this.priority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.fcfs);
            this.mainTabs.Controls.Add(this.sjf);
            this.mainTabs.Controls.Add(this.pr);
            this.mainTabs.Controls.Add(this.rr);
            this.mainTabs.Location = new System.Drawing.Point(12, 12);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(776, 321);
            this.mainTabs.TabIndex = 0;
            // 
            // fcfs
            // 
            this.fcfs.Controls.Add(this.infoBox1);
            this.fcfs.Controls.Add(this.modifyProcessGroup);
            this.fcfs.Controls.Add(this.addNewProcessBtn);
            this.fcfs.Location = new System.Drawing.Point(4, 22);
            this.fcfs.Name = "fcfs";
            this.fcfs.Padding = new System.Windows.Forms.Padding(3);
            this.fcfs.Size = new System.Drawing.Size(768, 295);
            this.fcfs.TabIndex = 0;
            this.fcfs.Text = "First Come First Served";
            this.fcfs.UseVisualStyleBackColor = true;
            // 
            // infoBox1
            // 
            this.infoBox1.Controls.Add(this.label6);
            this.infoBox1.Controls.Add(this.label1);
            this.infoBox1.Controls.Add(this.waitingTime);
            this.infoBox1.Controls.Add(this.numberOfProcesses);
            this.infoBox1.Location = new System.Drawing.Point(6, 6);
            this.infoBox1.Name = "infoBox1";
            this.infoBox1.Size = new System.Drawing.Size(213, 71);
            this.infoBox1.TabIndex = 16;
            this.infoBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Average Waiting Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Processes";
            // 
            // waitingTime
            // 
            this.waitingTime.Enabled = false;
            this.waitingTime.Location = new System.Drawing.Point(155, 39);
            this.waitingTime.Name = "waitingTime";
            this.waitingTime.Size = new System.Drawing.Size(39, 20);
            this.waitingTime.TabIndex = 15;
            // 
            // numberOfProcesses
            // 
            this.numberOfProcesses.Enabled = false;
            this.numberOfProcesses.Location = new System.Drawing.Point(155, 13);
            this.numberOfProcesses.Name = "numberOfProcesses";
            this.numberOfProcesses.Size = new System.Drawing.Size(39, 20);
            this.numberOfProcesses.TabIndex = 2;
            this.numberOfProcesses.Text = "0";
            // 
            // modifyProcessGroup
            // 
            this.modifyProcessGroup.Controls.Add(this.burstTimeBox);
            this.modifyProcessGroup.Controls.Add(this.arrivalTimeBox);
            this.modifyProcessGroup.Controls.Add(this.deleteProcessBtn);
            this.modifyProcessGroup.Controls.Add(this.processIndexLabel);
            this.modifyProcessGroup.Controls.Add(this.label4);
            this.modifyProcessGroup.Controls.Add(this.saveChangesBtn);
            this.modifyProcessGroup.Controls.Add(this.label3);
            this.modifyProcessGroup.Controls.Add(this.label2);
            this.modifyProcessGroup.Location = new System.Drawing.Point(6, 154);
            this.modifyProcessGroup.Name = "modifyProcessGroup";
            this.modifyProcessGroup.Size = new System.Drawing.Size(756, 135);
            this.modifyProcessGroup.TabIndex = 3;
            this.modifyProcessGroup.TabStop = false;
            this.modifyProcessGroup.Text = "Modify Process";
            // 
            // burstTimeBox
            // 
            this.burstTimeBox.Enabled = false;
            this.burstTimeBox.Location = new System.Drawing.Point(134, 70);
            this.burstTimeBox.Name = "burstTimeBox";
            this.burstTimeBox.Size = new System.Drawing.Size(64, 20);
            this.burstTimeBox.TabIndex = 9;
            // 
            // arrivalTimeBox
            // 
            this.arrivalTimeBox.Enabled = false;
            this.arrivalTimeBox.Location = new System.Drawing.Point(134, 36);
            this.arrivalTimeBox.Name = "arrivalTimeBox";
            this.arrivalTimeBox.Size = new System.Drawing.Size(64, 20);
            this.arrivalTimeBox.TabIndex = 8;
            // 
            // deleteProcessBtn
            // 
            this.deleteProcessBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteProcessBtn.Enabled = false;
            this.deleteProcessBtn.Location = new System.Drawing.Point(641, 10);
            this.deleteProcessBtn.Name = "deleteProcessBtn";
            this.deleteProcessBtn.Size = new System.Drawing.Size(109, 119);
            this.deleteProcessBtn.TabIndex = 7;
            this.deleteProcessBtn.Text = "Delete Process";
            this.deleteProcessBtn.UseVisualStyleBackColor = false;
            this.deleteProcessBtn.Click += new System.EventHandler(this.deleteProcessBtn_Click);
            // 
            // processIndexLabel
            // 
            this.processIndexLabel.AutoSize = true;
            this.processIndexLabel.Location = new System.Drawing.Point(255, 0);
            this.processIndexLabel.Name = "processIndexLabel";
            this.processIndexLabel.Size = new System.Drawing.Size(13, 13);
            this.processIndexLabel.TabIndex = 6;
            this.processIndexLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Now Modifying Process #";
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.saveChangesBtn.Enabled = false;
            this.saveChangesBtn.Location = new System.Drawing.Point(398, 10);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(162, 119);
            this.saveChangesBtn.TabIndex = 4;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = false;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Burst Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arrival Time";
            // 
            // addNewProcessBtn
            // 
            this.addNewProcessBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.addNewProcessBtn.Location = new System.Drawing.Point(572, 6);
            this.addNewProcessBtn.Name = "addNewProcessBtn";
            this.addNewProcessBtn.Size = new System.Drawing.Size(190, 42);
            this.addNewProcessBtn.TabIndex = 0;
            this.addNewProcessBtn.Text = "Add New Process";
            this.addNewProcessBtn.UseVisualStyleBackColor = false;
            this.addNewProcessBtn.Click += new System.EventHandler(this.addNewProcessBtn_Click);
            // 
            // sjf
            // 
            this.sjf.Controls.Add(this.preemption);
            this.sjf.Location = new System.Drawing.Point(4, 22);
            this.sjf.Name = "sjf";
            this.sjf.Padding = new System.Windows.Forms.Padding(3);
            this.sjf.Size = new System.Drawing.Size(768, 295);
            this.sjf.TabIndex = 1;
            this.sjf.Text = "Shortest Job First";
            this.sjf.UseVisualStyleBackColor = true;
            // 
            // preemption
            // 
            this.preemption.Controls.Add(this.preemptive);
            this.preemption.Controls.Add(this.label7);
            this.preemption.Location = new System.Drawing.Point(6, 90);
            this.preemption.Name = "preemption";
            this.preemption.Size = new System.Drawing.Size(213, 41);
            this.preemption.TabIndex = 18;
            this.preemption.TabStop = false;
            // 
            // preemptive
            // 
            this.preemptive.AutoSize = true;
            this.preemptive.Location = new System.Drawing.Point(127, 15);
            this.preemptive.Name = "preemptive";
            this.preemptive.Size = new System.Drawing.Size(79, 17);
            this.preemptive.TabIndex = 19;
            this.preemptive.Text = "Preemptive";
            this.preemptive.UseVisualStyleBackColor = true;
            this.preemptive.CheckedChanged += new System.EventHandler(this.preemptive_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Preemptive";
            // 
            // pr
            // 
            this.pr.Controls.Add(this.priority);
            this.pr.Location = new System.Drawing.Point(4, 22);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(768, 295);
            this.pr.TabIndex = 2;
            this.pr.Text = "Priority";
            this.pr.UseVisualStyleBackColor = true;
            // 
            // rr
            // 
            this.rr.Controls.Add(this.RRModBox);
            this.rr.Location = new System.Drawing.Point(4, 22);
            this.rr.Name = "rr";
            this.rr.Size = new System.Drawing.Size(768, 295);
            this.rr.TabIndex = 3;
            this.rr.Text = "Round-Robin";
            this.rr.UseVisualStyleBackColor = true;
            // 
            // RRModBox
            // 
            this.RRModBox.Controls.Add(this.label5);
            this.RRModBox.Controls.Add(this.quantumTimeConfirmBtn);
            this.RRModBox.Controls.Add(this.quantumTimeBox);
            this.RRModBox.Location = new System.Drawing.Point(6, 90);
            this.RRModBox.Name = "RRModBox";
            this.RRModBox.Size = new System.Drawing.Size(323, 41);
            this.RRModBox.TabIndex = 17;
            this.RRModBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantum Time";
            // 
            // quantumTimeConfirmBtn
            // 
            this.quantumTimeConfirmBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.quantumTimeConfirmBtn.Enabled = false;
            this.quantumTimeConfirmBtn.Location = new System.Drawing.Point(242, 9);
            this.quantumTimeConfirmBtn.Name = "quantumTimeConfirmBtn";
            this.quantumTimeConfirmBtn.Size = new System.Drawing.Size(75, 27);
            this.quantumTimeConfirmBtn.TabIndex = 13;
            this.quantumTimeConfirmBtn.Text = "Confirm";
            this.quantumTimeConfirmBtn.UseVisualStyleBackColor = false;
            this.quantumTimeConfirmBtn.Click += new System.EventHandler(this.quantumTimeConfirmBtn_Click);
            // 
            // quantumTimeBox
            // 
            this.quantumTimeBox.Location = new System.Drawing.Point(155, 13);
            this.quantumTimeBox.Name = "quantumTimeBox";
            this.quantumTimeBox.Size = new System.Drawing.Size(39, 20);
            this.quantumTimeBox.TabIndex = 11;
            this.quantumTimeBox.Text = "2";
            this.quantumTimeBox.TextChanged += new System.EventHandler(this.quantumTimeBox_TextChanged);
            // 
            // processContainer
            // 
            this.processContainer.AutoScroll = true;
            this.processContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.processContainer.BackColor = System.Drawing.Color.White;
            this.processContainer.Location = new System.Drawing.Point(16, 339);
            this.processContainer.Name = "processContainer";
            this.processContainer.Size = new System.Drawing.Size(768, 99);
            this.processContainer.TabIndex = 1;
            this.processContainer.WrapContents = false;
            // 
            // priority
            // 
            this.priority.Controls.Add(this.label8);
            this.priority.Controls.Add(this.priorityBox);
            this.priority.Location = new System.Drawing.Point(6, 96);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(200, 33);
            this.priority.TabIndex = 20;
            this.priority.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Priority";
            // 
            // priorityBox
            // 
            this.priorityBox.Location = new System.Drawing.Point(128, 9);
            this.priorityBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(56, 20);
            this.priorityBox.TabIndex = 17;
            this.priorityBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.processContainer);
            this.Controls.Add(this.mainTabs);
            this.Name = "Form1";
            this.Text = "CPU Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabs.ResumeLayout(false);
            this.fcfs.ResumeLayout(false);
            this.infoBox1.ResumeLayout(false);
            this.infoBox1.PerformLayout();
            this.modifyProcessGroup.ResumeLayout(false);
            this.modifyProcessGroup.PerformLayout();
            this.sjf.ResumeLayout(false);
            this.preemption.ResumeLayout(false);
            this.preemption.PerformLayout();
            this.pr.ResumeLayout(false);
            this.rr.ResumeLayout(false);
            this.RRModBox.ResumeLayout(false);
            this.RRModBox.PerformLayout();
            this.priority.ResumeLayout(false);
            this.priority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage fcfs;
        private System.Windows.Forms.TabPage sjf;
        private System.Windows.Forms.TabPage pr;
        private System.Windows.Forms.TabPage rr;
        private System.Windows.Forms.FlowLayoutPanel processContainer;
        private System.Windows.Forms.GroupBox modifyProcessGroup;
        private System.Windows.Forms.TextBox numberOfProcesses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewProcessBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Label processIndexLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox burstTimeBox;
        private System.Windows.Forms.TextBox arrivalTimeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantumTimeBox;
        private System.Windows.Forms.Button quantumTimeConfirmBtn;
        private System.Windows.Forms.GroupBox infoBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox waitingTime;
        private System.Windows.Forms.GroupBox RRModBox;
        private System.Windows.Forms.Button deleteProcessBtn;
        private System.Windows.Forms.GroupBox preemption;
        private System.Windows.Forms.CheckBox preemptive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox priority;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown priorityBox;
    }
}

