/*
 * -------------------------------------------------------
 * BRAZIL
 * FEDERAL UNIVERSITY OF UBERLÂNDIA
 * FACULTY OF ELECTRICAL ENGINEERING
 * BIOMEDICAL ENGINEERING LABORATORY 
 * 
 * ALGORITHM ANALYSIS APPLIED DO MEAN ABSOLUTE VALUE CALCULUS
 * Developed by: Andrei Nakagawa Silva
 * Contact: andrei.ufu@gmail.com
 * -------------------------------------------------------
*/

namespace MAV_Analysis
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
            this.components = new System.ComponentModel.Container();
            this.zgEMGSignal = new ZedGraph.ZedGraphControl();
            this.zgMAV = new ZedGraph.ZedGraphControl();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.rbAlg4 = new System.Windows.Forms.RadioButton();
            this.rbAlg3 = new System.Windows.Forms.RadioButton();
            this.rbAlg2 = new System.Windows.Forms.RadioButton();
            this.rbAlg1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumbRepet = new System.Windows.Forms.TextBox();
            this.tbWindowSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zgEMGSignal
            // 
            this.zgEMGSignal.Location = new System.Drawing.Point(252, 12);
            this.zgEMGSignal.Name = "zgEMGSignal";
            this.zgEMGSignal.ScrollGrace = 0D;
            this.zgEMGSignal.ScrollMaxX = 0D;
            this.zgEMGSignal.ScrollMaxY = 0D;
            this.zgEMGSignal.ScrollMaxY2 = 0D;
            this.zgEMGSignal.ScrollMinX = 0D;
            this.zgEMGSignal.ScrollMinY = 0D;
            this.zgEMGSignal.ScrollMinY2 = 0D;
            this.zgEMGSignal.Size = new System.Drawing.Size(493, 271);
            this.zgEMGSignal.TabIndex = 0;
            // 
            // zgMAV
            // 
            this.zgMAV.Location = new System.Drawing.Point(252, 285);
            this.zgMAV.Name = "zgMAV";
            this.zgMAV.ScrollGrace = 0D;
            this.zgMAV.ScrollMaxX = 0D;
            this.zgMAV.ScrollMaxY = 0D;
            this.zgMAV.ScrollMaxY2 = 0D;
            this.zgMAV.ScrollMinX = 0D;
            this.zgMAV.ScrollMinY = 0D;
            this.zgMAV.ScrollMinY2 = 0D;
            this.zgMAV.Size = new System.Drawing.Size(493, 271);
            this.zgMAV.TabIndex = 2;
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(12, 175);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(201, 381);
            this.lbLog.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbWindowSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumbRepet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Controls.Add(this.rbAlg4);
            this.groupBox1.Controls.Add(this.rbAlg3);
            this.groupBox1.Controls.Add(this.rbAlg2);
            this.groupBox1.Controls.Add(this.rbAlg1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the Algorithm";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(9, 119);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rbAlg4
            // 
            this.rbAlg4.AutoSize = true;
            this.rbAlg4.Location = new System.Drawing.Point(101, 43);
            this.rbAlg4.Name = "rbAlg4";
            this.rbAlg4.Size = new System.Drawing.Size(77, 17);
            this.rbAlg4.TabIndex = 3;
            this.rbAlg4.TabStop = true;
            this.rbAlg4.Text = "Algorithm 4";
            this.rbAlg4.UseVisualStyleBackColor = true;
            // 
            // rbAlg3
            // 
            this.rbAlg3.AutoSize = true;
            this.rbAlg3.Location = new System.Drawing.Point(101, 20);
            this.rbAlg3.Name = "rbAlg3";
            this.rbAlg3.Size = new System.Drawing.Size(77, 17);
            this.rbAlg3.TabIndex = 2;
            this.rbAlg3.TabStop = true;
            this.rbAlg3.Text = "Algorithm 3";
            this.rbAlg3.UseVisualStyleBackColor = true;
            // 
            // rbAlg2
            // 
            this.rbAlg2.AutoSize = true;
            this.rbAlg2.Location = new System.Drawing.Point(7, 43);
            this.rbAlg2.Name = "rbAlg2";
            this.rbAlg2.Size = new System.Drawing.Size(77, 17);
            this.rbAlg2.TabIndex = 1;
            this.rbAlg2.TabStop = true;
            this.rbAlg2.Text = "Algorithm 2";
            this.rbAlg2.UseVisualStyleBackColor = true;
            // 
            // rbAlg1
            // 
            this.rbAlg1.AutoSize = true;
            this.rbAlg1.Location = new System.Drawing.Point(7, 20);
            this.rbAlg1.Name = "rbAlg1";
            this.rbAlg1.Size = new System.Drawing.Size(77, 17);
            this.rbAlg1.TabIndex = 0;
            this.rbAlg1.TabStop = true;
            this.rbAlg1.Text = "Algorithm 1";
            this.rbAlg1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numb. Repetitions";
            // 
            // tbNumbRepet
            // 
            this.tbNumbRepet.Location = new System.Drawing.Point(101, 95);
            this.tbNumbRepet.Name = "tbNumbRepet";
            this.tbNumbRepet.Size = new System.Drawing.Size(100, 20);
            this.tbNumbRepet.TabIndex = 7;
            // 
            // tbWindowSize
            // 
            this.tbWindowSize.Location = new System.Drawing.Point(101, 69);
            this.tbWindowSize.Name = "tbWindowSize";
            this.tbWindowSize.Size = new System.Drawing.Size(100, 20);
            this.tbWindowSize.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Window size";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.zgMAV);
            this.Controls.Add(this.zgEMGSignal);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MAV Analysis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zgEMGSignal;
        private ZedGraph.ZedGraphControl zgMAV;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RadioButton rbAlg4;
        private System.Windows.Forms.RadioButton rbAlg3;
        private System.Windows.Forms.RadioButton rbAlg2;
        private System.Windows.Forms.RadioButton rbAlg1;
        private System.Windows.Forms.TextBox tbNumbRepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWindowSize;
        private System.Windows.Forms.Label label2;
    }
}

