namespace Lab1
{
	partial class FormLab1
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
			this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.MethodsBox = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Correlation = new System.Windows.Forms.Label();
			this.CountNumbers = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.CountNumbers2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCalc = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.MValue = new System.Windows.Forms.Label();
			this.DValue = new System.Windows.Forms.Label();
			this.Seed = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.MethodsBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// zedGraphControl1
			// 
			this.zedGraphControl1.Location = new System.Drawing.Point(328, 12);
			this.zedGraphControl1.Name = "zedGraphControl1";
			this.zedGraphControl1.ScrollGrace = 0D;
			this.zedGraphControl1.ScrollMaxX = 0D;
			this.zedGraphControl1.ScrollMaxY = 0D;
			this.zedGraphControl1.ScrollMaxY2 = 0D;
			this.zedGraphControl1.ScrollMinX = 0D;
			this.zedGraphControl1.ScrollMinY = 0D;
			this.zedGraphControl1.ScrollMinY2 = 0D;
			this.zedGraphControl1.Size = new System.Drawing.Size(542, 420);
			this.zedGraphControl1.TabIndex = 0;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(103, 17);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Middle of square";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// MethodsBox
			// 
			this.MethodsBox.Controls.Add(this.radioButton2);
			this.MethodsBox.Controls.Add(this.radioButton1);
			this.MethodsBox.Location = new System.Drawing.Point(12, 12);
			this.MethodsBox.Name = "MethodsBox";
			this.MethodsBox.Size = new System.Drawing.Size(310, 72);
			this.MethodsBox.TabIndex = 2;
			this.MethodsBox.TabStop = false;
			this.MethodsBox.Text = "Methods";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 42);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(147, 17);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Multiplicative congruential";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Correlation);
			this.groupBox1.Controls.Add(this.CountNumbers);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 101);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Testingtesting independence";
			// 
			// Correlation
			// 
			this.Correlation.AutoSize = true;
			this.Correlation.Location = new System.Drawing.Point(15, 50);
			this.Correlation.Name = "Correlation";
			this.Correlation.Size = new System.Drawing.Size(69, 13);
			this.Correlation.TabIndex = 4;
			this.Correlation.Text = "Correlation = ";
			// 
			// CountNumbers
			// 
			this.CountNumbers.Location = new System.Drawing.Point(88, 19);
			this.CountNumbers.Name = "CountNumbers";
			this.CountNumbers.Size = new System.Drawing.Size(216, 20);
			this.CountNumbers.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Count numbers";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.DValue);
			this.groupBox2.Controls.Add(this.MValue);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.CountNumbers2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(12, 197);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(310, 124);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Testing uniformity";
			// 
			// CountNumbers2
			// 
			this.CountNumbers2.Location = new System.Drawing.Point(88, 23);
			this.CountNumbers2.Name = "CountNumbers2";
			this.CountNumbers2.Size = new System.Drawing.Size(216, 20);
			this.CountNumbers2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Count numbers";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(160, 327);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(241, 327);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(75, 23);
			this.btnCalc.TabIndex = 6;
			this.btnCalc.Text = "Calc";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(88, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(216, 20);
			this.textBox1.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Num of section";
			// 
			// MValue
			// 
			this.MValue.AutoSize = true;
			this.MValue.Location = new System.Drawing.Point(56, 75);
			this.MValue.Name = "MValue";
			this.MValue.Size = new System.Drawing.Size(28, 13);
			this.MValue.TabIndex = 5;
			this.MValue.Text = "M = ";
			// 
			// DValue
			// 
			this.DValue.AutoSize = true;
			this.DValue.Location = new System.Drawing.Point(57, 98);
			this.DValue.Name = "DValue";
			this.DValue.Size = new System.Drawing.Size(27, 13);
			this.DValue.TabIndex = 9;
			this.DValue.Text = "D = ";
			// 
			// Seed
			// 
			this.Seed.Location = new System.Drawing.Point(68, 330);
			this.Seed.Name = "Seed";
			this.Seed.Size = new System.Drawing.Size(86, 20);
			this.Seed.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 333);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Seed";
			// 
			// FormLab1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 444);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Seed);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.MethodsBox);
			this.Controls.Add(this.zedGraphControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormLab1";
			this.Text = "MM.Lab1 Safonov Anatoly 052002";
			this.MethodsBox.ResumeLayout(false);
			this.MethodsBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ZedGraph.ZedGraphControl zedGraphControl1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox MethodsBox;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label Correlation;
		private System.Windows.Forms.TextBox CountNumbers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CountNumbers2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.Label DValue;
		private System.Windows.Forms.Label MValue;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox Seed;
		private System.Windows.Forms.Label label3;
	}
}

