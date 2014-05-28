namespace HermiteAprox2
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
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNodes = new System.Windows.Forms.Label();
            this.cbDecission = new System.Windows.Forms.CheckBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.cbNodes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(72, 46);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(100, 20);
            this.tbFrom.TabIndex = 0;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(178, 46);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(100, 20);
            this.tbTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Przedział:";
            // 
            // cbFunction
            // 
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Items.AddRange(new object[] {
            "5x - 1",
            "|x|"});
            this.cbFunction.Location = new System.Drawing.Point(72, 12);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(206, 21);
            this.cbFunction.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funkcja";
            // 
            // lbNodes
            // 
            this.lbNodes.AutoSize = true;
            this.lbNodes.Location = new System.Drawing.Point(13, 124);
            this.lbNodes.Name = "lbNodes";
            this.lbNodes.Size = new System.Drawing.Size(101, 13);
            this.lbNodes.TabIndex = 6;
            this.lbNodes.Text = "Stopien wielomianu:";
            // 
            // cbDecission
            // 
            this.cbDecission.AutoSize = true;
            this.cbDecission.Location = new System.Drawing.Point(119, 98);
            this.cbDecission.Name = "cbDecission";
            this.cbDecission.Size = new System.Drawing.Size(109, 17);
            this.cbDecission.TabIndex = 8;
            this.cbDecission.Text = "czy ustalony błąd";
            this.cbDecission.UseVisualStyleBackColor = true;
            this.cbDecission.CheckedChanged += new System.EventHandler(this.cbDecission_CheckedChanged);
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(86, 162);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 9;
            this.btnPlot.Text = "Rysuj";
            this.btnPlot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // cbNodes
            // 
            this.cbNodes.FormattingEnabled = true;
            this.cbNodes.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cbNodes.Location = new System.Drawing.Point(86, 71);
            this.cbNodes.Name = "cbNodes";
            this.cbNodes.Size = new System.Drawing.Size(121, 21);
            this.cbNodes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ilość węzłów:";
            // 
            // tbStop
            // 
            this.tbStop.Location = new System.Drawing.Point(119, 121);
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(100, 20);
            this.tbStop.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.tbStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNodes);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.cbDecission);
            this.Controls.Add(this.lbNodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFunction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNodes;
        private System.Windows.Forms.CheckBox cbDecission;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.ComboBox cbNodes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStop;
    }
}

