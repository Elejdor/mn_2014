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
            this.label3 = new System.Windows.Forms.Label();
            this.tbNodesNumber = new System.Windows.Forms.TextBox();
            this.panelChebyshev = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.tbBegin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbChebyshev = new System.Windows.Forms.RadioButton();
            this.rbEquiv = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbfLn = new System.Windows.Forms.RadioButton();
            this.rbfSpline3 = new System.Windows.Forms.RadioButton();
            this.rbfSpline2 = new System.Windows.Forms.RadioButton();
            this.rbfSpline1 = new System.Windows.Forms.RadioButton();
            this.rbfSin = new System.Windows.Forms.RadioButton();
            this.rbfExp = new System.Windows.Forms.RadioButton();
            this.rbfPoly = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChebyshev.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(291, 79);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(177, 37);
            this.btnPlot.TabIndex = 0;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interpolation jump (Δx):";
            // 
            // tbJump
            // 
            this.tbJump.Location = new System.Drawing.Point(132, 76);
            this.tbJump.Name = "tbJump";
            this.tbJump.Size = new System.Drawing.Size(100, 20);
            this.tbJump.TabIndex = 2;
            this.tbJump.Text = "0,1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of nodes:";
            // 
            // tbNodesNumber
            // 
            this.tbNodesNumber.Location = new System.Drawing.Point(132, 100);
            this.tbNodesNumber.Name = "tbNodesNumber";
            this.tbNodesNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNodesNumber.TabIndex = 6;
            this.tbNodesNumber.Text = "10";
            // 
            // panelChebyshev
            // 
            this.panelChebyshev.Controls.Add(this.label5);
            this.panelChebyshev.Controls.Add(this.tbEnd);
            this.panelChebyshev.Controls.Add(this.tbBegin);
            this.panelChebyshev.Controls.Add(this.label6);
            this.panelChebyshev.Location = new System.Drawing.Point(291, 12);
            this.panelChebyshev.Name = "panelChebyshev";
            this.panelChebyshev.Size = new System.Drawing.Size(177, 52);
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
            this.tbBegin.Text = "-5";
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
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose nodes generation method";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbfLn);
            this.groupBox2.Controls.Add(this.rbfSpline3);
            this.groupBox2.Controls.Add(this.rbfSpline2);
            this.groupBox2.Controls.Add(this.rbfSpline1);
            this.groupBox2.Controls.Add(this.rbfSin);
            this.groupBox2.Controls.Add(this.rbfExp);
            this.groupBox2.Controls.Add(this.rbfPoly);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 96);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose function";
            // 
            // rbfLn
            // 
            this.rbfLn.AutoSize = true;
            this.rbfLn.Location = new System.Drawing.Point(261, 19);
            this.rbfLn.Name = "rbfLn";
            this.rbfLn.Size = new System.Drawing.Size(70, 17);
            this.rbfLn.TabIndex = 6;
            this.rbfLn.Text = "f(x) = ln(x)";
            this.rbfLn.UseVisualStyleBackColor = true;
            this.rbfLn.CheckedChanged += new System.EventHandler(this.rbfLn_CheckedChanged);
            // 
            // rbfSpline3
            // 
            this.rbfSpline3.AutoSize = true;
            this.rbfSpline3.Location = new System.Drawing.Point(6, 60);
            this.rbfSpline3.Name = "rbfSpline3";
            this.rbfSpline3.Size = new System.Drawing.Size(122, 17);
            this.rbfSpline3.TabIndex = 5;
            this.rbfSpline3.Text = "f(x) = sin(x^2 - 2x - 1)";
            this.rbfSpline3.UseVisualStyleBackColor = true;
            this.rbfSpline3.CheckedChanged += new System.EventHandler(this.rbfSpline3_CheckedChanged);
            // 
            // rbfSpline2
            // 
            this.rbfSpline2.AutoSize = true;
            this.rbfSpline2.Location = new System.Drawing.Point(261, 60);
            this.rbfSpline2.Name = "rbfSpline2";
            this.rbfSpline2.Size = new System.Drawing.Size(89, 17);
            this.rbfSpline2.TabIndex = 4;
            this.rbfSpline2.Text = "f(x) = sin(ln(x))";
            this.rbfSpline2.UseVisualStyleBackColor = true;
            this.rbfSpline2.CheckedChanged += new System.EventHandler(this.rbfSpline2_CheckedChanged);
            // 
            // rbfSpline1
            // 
            this.rbfSpline1.AutoSize = true;
            this.rbfSpline1.Location = new System.Drawing.Point(139, 60);
            this.rbfSpline1.Name = "rbfSpline1";
            this.rbfSpline1.Size = new System.Drawing.Size(87, 17);
            this.rbfSpline1.TabIndex = 3;
            this.rbfSpline1.Text = "f(x) = sin(3^x)";
            this.rbfSpline1.UseVisualStyleBackColor = true;
            this.rbfSpline1.CheckedChanged += new System.EventHandler(this.rbfSpline1_CheckedChanged);
            // 
            // rbfSin
            // 
            this.rbfSin.AutoSize = true;
            this.rbfSin.Location = new System.Drawing.Point(394, 19);
            this.rbfSin.Name = "rbfSin";
            this.rbfSin.Size = new System.Drawing.Size(75, 17);
            this.rbfSin.TabIndex = 2;
            this.rbfSin.Text = "f(x) = sin(x)";
            this.rbfSin.UseVisualStyleBackColor = true;
            this.rbfSin.CheckedChanged += new System.EventHandler(this.rbfSin_CheckedChanged);
            // 
            // rbfExp
            // 
            this.rbfExp.AutoSize = true;
            this.rbfExp.Location = new System.Drawing.Point(139, 19);
            this.rbfExp.Name = "rbfExp";
            this.rbfExp.Size = new System.Drawing.Size(68, 17);
            this.rbfExp.TabIndex = 1;
            this.rbfExp.Text = "f(x) = 3^x";
            this.rbfExp.UseVisualStyleBackColor = true;
            this.rbfExp.CheckedChanged += new System.EventHandler(this.rbfExp_CheckedChanged);
            // 
            // rbfPoly
            // 
            this.rbfPoly.AutoSize = true;
            this.rbfPoly.Checked = true;
            this.rbfPoly.Location = new System.Drawing.Point(6, 19);
            this.rbfPoly.Name = "rbfPoly";
            this.rbfPoly.Size = new System.Drawing.Size(103, 17);
            this.rbfPoly.TabIndex = 0;
            this.rbfPoly.TabStop = true;
            this.rbfPoly.Text = "f(x) = x^2 - 2x - 1";
            this.rbfPoly.UseVisualStyleBackColor = true;
            this.rbfPoly.CheckedChanged += new System.EventHandler(this.rbfPoly_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelChebyshev);
            this.panel1.Controls.Add(this.btnPlot);
            this.panel1.Controls.Add(this.tbJump);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNodesNumber);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 135);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 264);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Metody Numeryczne, Zadanie 3, Łukasz Nizik & Justyna Janiak";
            this.panelChebyshev.ResumeLayout(false);
            this.panelChebyshev.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJump;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNodesNumber;
        private System.Windows.Forms.Panel panelChebyshev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.TextBox tbBegin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChebyshev;
        private System.Windows.Forms.RadioButton rbEquiv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbfSpline3;
        private System.Windows.Forms.RadioButton rbfSpline2;
        private System.Windows.Forms.RadioButton rbfSpline1;
        private System.Windows.Forms.RadioButton rbfSin;
        private System.Windows.Forms.RadioButton rbfExp;
        private System.Windows.Forms.RadioButton rbfPoly;
        private System.Windows.Forms.RadioButton rbfLn;


    }
}

