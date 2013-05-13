namespace VAX_Simulator
{
    partial class MainWindow
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.rdFifo = new System.Windows.Forms.RadioButton();
            this.rdLru = new System.Windows.Forms.RadioButton();
            this.rdOpt = new System.Windows.Forms.RadioButton();
            this.rd10 = new System.Windows.Forms.RadioButton();
            this.rd100 = new System.Windows.Forms.RadioButton();
            this.rd50 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(339, 673);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(399, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Comenzar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Location = new System.Drawing.Point(92, 27);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(876, 536);
            this.txtOutput.TabIndex = 1;
            // 
            // rdFifo
            // 
            this.rdFifo.AutoSize = true;
            this.rdFifo.Location = new System.Drawing.Point(350, 589);
            this.rdFifo.Name = "rdFifo";
            this.rdFifo.Size = new System.Drawing.Size(122, 21);
            this.rdFifo.TabIndex = 2;
            this.rdFifo.TabStop = true;
            this.rdFifo.Text = "First in first out";
            this.rdFifo.UseVisualStyleBackColor = true;
            // 
            // rdLru
            // 
            this.rdLru.AutoSize = true;
            this.rdLru.Location = new System.Drawing.Point(484, 589);
            this.rdLru.Name = "rdLru";
            this.rdLru.Size = new System.Drawing.Size(137, 21);
            this.rdLru.TabIndex = 3;
            this.rdLru.TabStop = true;
            this.rdLru.Text = "Less Recent Use";
            this.rdLru.UseVisualStyleBackColor = true;
            // 
            // rdOpt
            // 
            this.rdOpt.AutoSize = true;
            this.rdOpt.Location = new System.Drawing.Point(627, 589);
            this.rdOpt.Name = "rdOpt";
            this.rdOpt.Size = new System.Drawing.Size(74, 21);
            this.rdOpt.TabIndex = 4;
            this.rdOpt.TabStop = true;
            this.rdOpt.Text = "Optimo";
            this.rdOpt.UseVisualStyleBackColor = true;
            // 
            // rd10
            // 
            this.rd10.AutoSize = true;
            this.rd10.Location = new System.Drawing.Point(12, 11);
            this.rd10.Name = "rd10";
            this.rd10.Size = new System.Drawing.Size(96, 21);
            this.rd10.TabIndex = 5;
            this.rd10.TabStop = true;
            this.rd10.Text = "10 Frames";
            this.rd10.UseVisualStyleBackColor = true;
            // 
            // rd100
            // 
            this.rd100.AutoSize = true;
            this.rd100.Location = new System.Drawing.Point(288, 11);
            this.rd100.Name = "rd100";
            this.rd100.Size = new System.Drawing.Size(104, 21);
            this.rd100.TabIndex = 6;
            this.rd100.TabStop = true;
            this.rd100.Text = "100 Frames";
            this.rd100.UseVisualStyleBackColor = true;
            // 
            // rd50
            // 
            this.rd50.AutoSize = true;
            this.rd50.Location = new System.Drawing.Point(146, 11);
            this.rd50.Name = "rd50";
            this.rd50.Size = new System.Drawing.Size(96, 21);
            this.rd50.TabIndex = 7;
            this.rd50.TabStop = true;
            this.rd50.Text = "50 Frames";
            this.rd50.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd10);
            this.panel1.Controls.Add(this.rd100);
            this.panel1.Controls.Add(this.rd50);
            this.panel1.Location = new System.Drawing.Point(339, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 51);
            this.panel1.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdOpt);
            this.Controls.Add(this.rdLru);
            this.Controls.Add(this.rdFifo);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnStart);
            this.Name = "MainWindow";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.RadioButton rdFifo;
        private System.Windows.Forms.RadioButton rdLru;
        private System.Windows.Forms.RadioButton rdOpt;
        private System.Windows.Forms.RadioButton rd10;
        private System.Windows.Forms.RadioButton rd100;
        private System.Windows.Forms.RadioButton rd50;
        private System.Windows.Forms.Panel panel1;
    }
}

