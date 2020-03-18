namespace TilesetFixer
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.nud_HorizontalSpacing = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nud_width = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.nud_height = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.nud_VerticalSpacing = new System.Windows.Forms.NumericUpDown();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nud_HorizontalSpacing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_width)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_VerticalSpacing)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Original Tileset:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(296, 20);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(317, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Browse..";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(317, 62);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Browse..";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(15, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(296, 20);
			this.textBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Output Folder:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(15, 191);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(376, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Fixe Tileset";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(15, 168);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(127, 17);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "Add Suffix to fixed file";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// nud_HorisontalSpacing
			// 
			this.nud_HorizontalSpacing.Location = new System.Drawing.Point(15, 142);
			this.nud_HorizontalSpacing.Name = "nud_HorisontalSpacing";
			this.nud_HorizontalSpacing.Size = new System.Drawing.Size(69, 20);
			this.nud_HorizontalSpacing.TabIndex = 8;
			this.nud_HorizontalSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(136, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Vertical Tiles spacing:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Tiles width:";
			// 
			// nud_width
			// 
			this.nud_width.Location = new System.Drawing.Point(15, 103);
			this.nud_width.Name = "nud_width";
			this.nud_width.Size = new System.Drawing.Size(71, 20);
			this.nud_width.TabIndex = 10;
			this.nud_width.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(136, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Tiles height:";
			// 
			// nud_height
			// 
			this.nud_height.Location = new System.Drawing.Point(139, 103);
			this.nud_height.Name = "nud_height";
			this.nud_height.Size = new System.Drawing.Size(71, 20);
			this.nud_height.TabIndex = 12;
			this.nud_height.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 126);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Horizontal Tiles spacing:";
			// 
			// nud_VerticalSpacing
			// 
			this.nud_VerticalSpacing.Location = new System.Drawing.Point(141, 142);
			this.nud_VerticalSpacing.Name = "nud_VerticalSpacing";
			this.nud_VerticalSpacing.Size = new System.Drawing.Size(69, 20);
			this.nud_VerticalSpacing.TabIndex = 14;
			this.nud_VerticalSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 228);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nud_VerticalSpacing);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nud_height);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nud_width);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nud_HorizontalSpacing);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Tileset Fixer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
			((System.ComponentModel.ISupportInitialize)(this.nud_HorizontalSpacing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_width)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_VerticalSpacing)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.NumericUpDown nud_HorizontalSpacing;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nud_width;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nud_height;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nud_VerticalSpacing;
		private System.Windows.Forms.Timer timer1;
	}
}

