namespace Integration
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
            this.lPanel = new System.Windows.Forms.Panel();
            this.rPanel = new System.Windows.Forms.Panel();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.tbSimA = new System.Windows.Forms.TextBox();
            this.tbSimB = new System.Windows.Forms.TextBox();
            this.tbBladObliczen = new System.Windows.Forms.TextBox();
            this.tbLim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSimpsonResult = new System.Windows.Forms.Label();
            this.lbHerLagResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboNodes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimpsounCount = new System.Windows.Forms.Button();
            this.btnHerCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHermit = new System.Windows.Forms.RadioButton();
            this.rbLag = new System.Windows.Forms.RadioButton();
            this.lPanel.SuspendLayout();
            this.rPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lPanel
            // 
            this.lPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lPanel.Controls.Add(this.btnSimpsounCount);
            this.lPanel.Controls.Add(this.lbSimpsonResult);
            this.lPanel.Controls.Add(this.label4);
            this.lPanel.Controls.Add(this.label3);
            this.lPanel.Controls.Add(this.label2);
            this.lPanel.Controls.Add(this.label1);
            this.lPanel.Controls.Add(this.tbBladObliczen);
            this.lPanel.Controls.Add(this.tbSimB);
            this.lPanel.Controls.Add(this.tbSimA);
            this.lPanel.Location = new System.Drawing.Point(12, 64);
            this.lPanel.Name = "lPanel";
            this.lPanel.Size = new System.Drawing.Size(295, 255);
            this.lPanel.TabIndex = 0;
            // 
            // rPanel
            // 
            this.rPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rPanel.Controls.Add(this.groupBox1);
            this.rPanel.Controls.Add(this.btnHerCount);
            this.rPanel.Controls.Add(this.label6);
            this.rPanel.Controls.Add(this.comboNodes);
            this.rPanel.Controls.Add(this.label9);
            this.rPanel.Controls.Add(this.lbHerLagResult);
            this.rPanel.Controls.Add(this.label5);
            this.rPanel.Controls.Add(this.tbLim);
            this.rPanel.Location = new System.Drawing.Point(326, 64);
            this.rPanel.Name = "rPanel";
            this.rPanel.Size = new System.Drawing.Size(295, 255);
            this.rPanel.TabIndex = 1;
            // 
            // cbFunction
            // 
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Location = new System.Drawing.Point(190, 22);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(259, 21);
            this.cbFunction.TabIndex = 0;
            // 
            // tbSimA
            // 
            this.tbSimA.Location = new System.Drawing.Point(139, 15);
            this.tbSimA.Name = "tbSimA";
            this.tbSimA.Size = new System.Drawing.Size(100, 20);
            this.tbSimA.TabIndex = 0;
            // 
            // tbSimB
            // 
            this.tbSimB.Location = new System.Drawing.Point(139, 52);
            this.tbSimB.Name = "tbSimB";
            this.tbSimB.Size = new System.Drawing.Size(100, 20);
            this.tbSimB.TabIndex = 1;
            // 
            // tbBladObliczen
            // 
            this.tbBladObliczen.Location = new System.Drawing.Point(139, 90);
            this.tbBladObliczen.Name = "tbBladObliczen";
            this.tbBladObliczen.Size = new System.Drawing.Size(100, 20);
            this.tbBladObliczen.TabIndex = 2;
            // 
            // tbLim
            // 
            this.tbLim.Location = new System.Drawing.Point(136, 72);
            this.tbLim.Name = "tbLim";
            this.tbLim.Size = new System.Drawing.Size(100, 20);
            this.tbLim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Początek przedziału";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Koniec przedziału";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Żądany błąd obliczeń";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wynik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wartość granicy";
            // 
            // lbSimpsonResult
            // 
            this.lbSimpsonResult.AutoSize = true;
            this.lbSimpsonResult.Location = new System.Drawing.Point(136, 207);
            this.lbSimpsonResult.Name = "lbSimpsonResult";
            this.lbSimpsonResult.Size = new System.Drawing.Size(13, 13);
            this.lbSimpsonResult.TabIndex = 10;
            this.lbSimpsonResult.Text = "0";
            // 
            // lbHerLagResult
            // 
            this.lbHerLagResult.AutoSize = true;
            this.lbHerLagResult.Location = new System.Drawing.Point(163, 207);
            this.lbHerLagResult.Name = "lbHerLagResult";
            this.lbHerLagResult.Size = new System.Drawing.Size(13, 13);
            this.lbHerLagResult.TabIndex = 11;
            this.lbHerLagResult.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Wynik";
            // 
            // comboNodes
            // 
            this.comboNodes.FormattingEnabled = true;
            this.comboNodes.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboNodes.Location = new System.Drawing.Point(136, 104);
            this.comboNodes.Name = "comboNodes";
            this.comboNodes.Size = new System.Drawing.Size(100, 21);
            this.comboNodes.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Liczba węzłów";
            // 
            // btnSimpsounCount
            // 
            this.btnSimpsounCount.Location = new System.Drawing.Point(74, 142);
            this.btnSimpsounCount.Name = "btnSimpsounCount";
            this.btnSimpsounCount.Size = new System.Drawing.Size(75, 23);
            this.btnSimpsounCount.TabIndex = 14;
            this.btnSimpsounCount.Text = "Licz";
            this.btnSimpsounCount.UseVisualStyleBackColor = true;
            this.btnSimpsounCount.Click += new System.EventHandler(this.btnSimpsounCount_Click);
            // 
            // btnHerCount
            // 
            this.btnHerCount.Location = new System.Drawing.Point(113, 142);
            this.btnHerCount.Name = "btnHerCount";
            this.btnHerCount.Size = new System.Drawing.Size(75, 23);
            this.btnHerCount.TabIndex = 15;
            this.btnHerCount.Text = "Licz";
            this.btnHerCount.UseVisualStyleBackColor = true;
            this.btnHerCount.Click += new System.EventHandler(this.btnHerCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLag);
            this.groupBox1.Controls.Add(this.rbHermit);
            this.groupBox1.Location = new System.Drawing.Point(28, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 63);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metoda";
            // 
            // rbHermit
            // 
            this.rbHermit.AutoSize = true;
            this.rbHermit.Checked = true;
            this.rbHermit.Location = new System.Drawing.Point(15, 19);
            this.rbHermit.Name = "rbHermit";
            this.rbHermit.Size = new System.Drawing.Size(61, 17);
            this.rbHermit.TabIndex = 0;
            this.rbHermit.TabStop = true;
            this.rbHermit.Text = "Hermite";
            this.rbHermit.UseVisualStyleBackColor = true;
            // 
            // rbLag
            // 
            this.rbLag.AutoSize = true;
            this.rbLag.Location = new System.Drawing.Point(153, 19);
            this.rbLag.Name = "rbLag";
            this.rbLag.Size = new System.Drawing.Size(67, 17);
            this.rbLag.TabIndex = 1;
            this.rbLag.Text = "Laguerre";
            this.rbLag.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 348);
            this.Controls.Add(this.rPanel);
            this.Controls.Add(this.lPanel);
            this.Controls.Add(this.cbFunction);
            this.Name = "Form1";
            this.Text = "Metody numeryczne, zad. 4 - Całkowanie numeryczne";
            this.lPanel.ResumeLayout(false);
            this.lPanel.PerformLayout();
            this.rPanel.ResumeLayout(false);
            this.rPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lPanel;
        private System.Windows.Forms.TextBox tbBladObliczen;
        private System.Windows.Forms.TextBox tbSimB;
        private System.Windows.Forms.TextBox tbSimA;
        private System.Windows.Forms.Panel rPanel;
        private System.Windows.Forms.TextBox tbLim;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Button btnSimpsounCount;
        private System.Windows.Forms.Label lbSimpsonResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLag;
        private System.Windows.Forms.RadioButton rbHermit;
        private System.Windows.Forms.Button btnHerCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboNodes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbHerLagResult;
        private System.Windows.Forms.Label label5;
    }
}

