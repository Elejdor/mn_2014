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
            this.SuspendLayout();
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(86, 116);
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
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nodes jump (Δx):";
            // 
            // tbJumpNodes
            // 
            this.tbJumpNodes.Location = new System.Drawing.Point(132, 32);
            this.tbJumpNodes.Name = "tbJumpNodes";
            this.tbJumpNodes.Size = new System.Drawing.Size(100, 20);
            this.tbJumpNodes.TabIndex = 4;
            this.tbJumpNodes.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of nodes:";
            // 
            // tbNodesNumber
            // 
            this.tbNodesNumber.Location = new System.Drawing.Point(132, 55);
            this.tbNodesNumber.Name = "tbNodesNumber";
            this.tbNodesNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNodesNumber.TabIndex = 6;
            this.tbNodesNumber.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Starting node (x):";
            // 
            // tbStartingNode
            // 
            this.tbStartingNode.Location = new System.Drawing.Point(132, 78);
            this.tbStartingNode.Name = "tbStartingNode";
            this.tbStartingNode.Size = new System.Drawing.Size(100, 20);
            this.tbStartingNode.TabIndex = 8;
            this.tbStartingNode.Text = "-5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 151);
            this.Controls.Add(this.tbStartingNode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNodesNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbJumpNodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbJump);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlot);
            this.Name = "Form1";
            this.Text = "Form1";
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


    }
}

