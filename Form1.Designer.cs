
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
            this.modifyProcessGroup = new System.Windows.Forms.GroupBox();
            this.deleteProcessBtn = new System.Windows.Forms.Button();
            this.processIndexLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfProcessesText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewProcessBtn = new System.Windows.Forms.Button();
            this.sjf = new System.Windows.Forms.TabPage();
            this.pr = new System.Windows.Forms.TabPage();
            this.rr = new System.Windows.Forms.TabPage();
            this.processContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.arrivalTimeBox = new System.Windows.Forms.TextBox();
            this.burstTimeBox = new System.Windows.Forms.TextBox();
            this.mainTabs.SuspendLayout();
            this.fcfs.SuspendLayout();
            this.modifyProcessGroup.SuspendLayout();
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
            this.fcfs.Controls.Add(this.modifyProcessGroup);
            this.fcfs.Controls.Add(this.numberOfProcessesText);
            this.fcfs.Controls.Add(this.label1);
            this.fcfs.Controls.Add(this.addNewProcessBtn);
            this.fcfs.Location = new System.Drawing.Point(4, 22);
            this.fcfs.Name = "fcfs";
            this.fcfs.Padding = new System.Windows.Forms.Padding(3);
            this.fcfs.Size = new System.Drawing.Size(768, 295);
            this.fcfs.TabIndex = 0;
            this.fcfs.Text = "First Come First Served";
            this.fcfs.UseVisualStyleBackColor = true;
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
            // deleteProcessBtn
            // 
            this.deleteProcessBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteProcessBtn.Enabled = false;
            this.deleteProcessBtn.Location = new System.Drawing.Point(447, 10);
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
            this.saveChangesBtn.Location = new System.Drawing.Point(562, 10);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(190, 119);
            this.saveChangesBtn.TabIndex = 4;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = false;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Burst Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arrival Time";
            // 
            // numberOfProcessesText
            // 
            this.numberOfProcessesText.Enabled = false;
            this.numberOfProcessesText.Location = new System.Drawing.Point(143, 18);
            this.numberOfProcessesText.Name = "numberOfProcessesText";
            this.numberOfProcessesText.Size = new System.Drawing.Size(39, 20);
            this.numberOfProcessesText.TabIndex = 2;
            this.numberOfProcessesText.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Processes";
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
            this.sjf.Location = new System.Drawing.Point(4, 22);
            this.sjf.Name = "sjf";
            this.sjf.Padding = new System.Windows.Forms.Padding(3);
            this.sjf.Size = new System.Drawing.Size(768, 295);
            this.sjf.TabIndex = 1;
            this.sjf.Text = "Shortest Job First";
            this.sjf.UseVisualStyleBackColor = true;
            // 
            // pr
            // 
            this.pr.Location = new System.Drawing.Point(4, 22);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(768, 295);
            this.pr.TabIndex = 2;
            this.pr.Text = "Priority";
            this.pr.UseVisualStyleBackColor = true;
            // 
            // rr
            // 
            this.rr.Location = new System.Drawing.Point(4, 22);
            this.rr.Name = "rr";
            this.rr.Size = new System.Drawing.Size(768, 295);
            this.rr.TabIndex = 3;
            this.rr.Text = "Round-Robin";
            this.rr.UseVisualStyleBackColor = true;
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
            // arrivalTimeBox
            // 
            this.arrivalTimeBox.Location = new System.Drawing.Point(134, 44);
            this.arrivalTimeBox.Name = "arrivalTimeBox";
            this.arrivalTimeBox.Size = new System.Drawing.Size(64, 20);
            this.arrivalTimeBox.TabIndex = 8;
            // 
            // burstTimeBox
            // 
            this.burstTimeBox.Location = new System.Drawing.Point(134, 84);
            this.burstTimeBox.Name = "burstTimeBox";
            this.burstTimeBox.Size = new System.Drawing.Size(64, 20);
            this.burstTimeBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.processContainer);
            this.Controls.Add(this.mainTabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainTabs.ResumeLayout(false);
            this.fcfs.ResumeLayout(false);
            this.fcfs.PerformLayout();
            this.modifyProcessGroup.ResumeLayout(false);
            this.modifyProcessGroup.PerformLayout();
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
        private System.Windows.Forms.TextBox numberOfProcessesText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewProcessBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Label processIndexLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteProcessBtn;
        private System.Windows.Forms.TextBox burstTimeBox;
        private System.Windows.Forms.TextBox arrivalTimeBox;
    }
}

