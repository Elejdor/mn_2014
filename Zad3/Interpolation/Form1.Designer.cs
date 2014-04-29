namespace Interpolation
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
            this.btnPlot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJump = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJumpNodes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNodesNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStartingNode = new System.Windows.Forms.TextBox();
            this.panelEqui = new System.Windows.Forms.Panel();
            this.panelChebyshev = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.tbBegin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEquiv = new System.Windows.Forms.RadioButton();
            this.rbChebyshev = new System.Windows.Forms.RadioButton();
            this.panelEqui.SuspendLayout();
            this.panelChebyshev.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(204, 187);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 0;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interpolation jump (Δx):";
            // 
            // tbJump
            // 
            this.tbJump.Location = new System.Drawing.Point(132, 6);
            this.tbJump.Name = "tbJump";
            this.tbJump.Size = new System.Drawing.Size(100, 20);
            this.tbJump.TabIndex = 2;
            this.tbJump.Text = "0,1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nodes jump (Δx):";
            // 
            // tbJumpNodes
            // 
            this.tbJumpNodes.Location = new System.Drawing.Point(96, 6);
            this.tbJumpNodes.Name = "tbJumpNodes";
            this.tbJumpNodes.Size = new System.Drawing.Size(100, 20);
            this.tbJumpNodes.TabIndex = 4;
            this.tbJumpNodes.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of nodes:";
            // 
            // tbNodesNumber
            // 
            this.tbNodesNumber.Location = new System.Drawing.Point(132, 30);
            this.tbNodesNumber.Name = "tbNodesNumber";
            this.tbNodesNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNodesNumber.TabIndex = 6;
            this.tbNodesNumber.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Starting node (x):";
            // 
            // tbStartingNode
            // 
            this.tbStartingNode.Location = new System.Drawing.Point(96, 28);
            this.tbStartingNode.Name = "tbStartingNode";
            this.tbStartingNode.Size = new System.Drawing.Size(100, 20);
            this.tbStartingNode.TabIndex = 8;
            this.tbStartingNode.Text = "-5";
            // 
            // panelEqui
            // 
            this.panelEqui.Controls.Add(this.label2);
            this.panelEqui.Controls.Add(this.tbStartingNode);
            this.panelEqui.Controls.Add(this.tbJumpNodes);
            this.panelEqui.Controls.Add(this.label4);
            this.panelEqui.Enabled = false;
            this.panelEqui.Location = new System.Drawing.Point(16, 106);
            this.panelEqui.Name = "panelEqui";
            this.panelEqui.Size = new System.Drawing.Size(217, 66);
            this.panelEqui.TabIndex = 9;
            // 
            // panelChebyshev
            // 
            this.panelChebyshev.Controls.Add(this.label5);
            this.panelChebyshev.Controls.Add(this.tbEnd);
            this.panelChebyshev.Controls.Add(this.tbBegin);
            this.panelChebyshev.Controls.Add(this.label6);
            this.panelChebyshev.Location = new System.Drawing.Point(263, 106);
            this.panelChebyshev.Name = "panelChebyshev";
            this.panelChebyshev.Size = new System.Drawing.Size(177, 66);
            this.panelChebyshev.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Beginning:";
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(65, 28);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(100, 20);
            this.tbEnd.TabIndex = 8;
            this.tbEnd.Text = "5";
            // 
            // tbBegin
            // 
            this.tbBegin.Location = new System.Drawing.Point(65, 6);
            this.tbBegin.Name = "tbBegin";
            this.tbBegin.Size = new System.Drawing.Size(100, 20);
            this.tbBegin.TabIndex = 4;
            this.tbBegin.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "End:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChebyshev);
            this.groupBox1.Controls.Add(this.rbEquiv);
            this.groupBox1.Location = new System.Drawing.Point(148, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose nodes generation method";
            // 
            // rbEquiv
            // 
            this.rbEquiv.AutoSize = true;
            this.rbEquiv.Location = new System.Drawing.Point(8, 19);
            this.rbEquiv.Name = "rbEquiv";
            this.rbEquiv.Size = new System.Drawing.Size(76, 17);
            this.rbEquiv.TabIndex = 0;
            this.rbEquiv.Text = "equidistant";
            this.rbEquiv.UseVisualStyleBackColor = true;
            this.rbEquiv.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbChebyshev
            // 
            this.rbChebyshev.AutoSize = true;
            this.rbChebyshev.Checked = true;
            this.rbChebyshev.Location = new System.Drawing.Point(133, 19);
            this.rbChebyshev.Name = "rbChebyshev";
            this.rbChebyshev.Size = new System.Drawing.Size(78, 17);
            this.rbChebyshev.TabIndex = 1;
            this.rbChebyshev.TabStop = true;
            this.rbChebyshev.Text = "Chevyshev";
            this.rbChebyshev.UseVisualStyleBackColor = true;
            this.rbChebyshev.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelChebyshev);
            this.Controls.Add(this.panelEqui);
            this.Controls.Add(this.tbJump);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNodesNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelEqui.ResumeLayout(false);
            this.panelEqui.PerformLayout();
            this.panelChebyshev.ResumeLayout(false);
            this.panelChebyshev.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJump;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJumpNodes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNodesNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStartingNode;
        private System.Windows.Forms.Panel panelEqui;
        private System.Windows.Forms.Panel panelChebyshev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.TextBox tbBegin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChebyshev;
        private System.Windows.Forms.RadioButton rbEquiv;


    }
}

