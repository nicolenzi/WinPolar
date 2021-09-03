
namespace WinPolar
{
	partial class ControlForm2
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(252, 25);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "WinPolar";
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(221, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(20, 20);
			this.panel2.TabIndex = 0;
			this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(205, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(16, 17);
			this.panel3.TabIndex = 0;
			this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(22, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Bienvenido :)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Selecciona tu resolucion (solo una);";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(15, 104);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(67, 17);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "800x600";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(14, 127);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(73, 17);
			this.checkBox2.TabIndex = 4;
			this.checkBox2.Text = "1024x768";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(14, 150);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(73, 17);
			this.checkBox3.TabIndex = 5;
			this.checkBox3.Text = "1280x720";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(14, 173);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(73, 17);
			this.checkBox4.TabIndex = 6;
			this.checkBox4.Text = "1360x768";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(14, 196);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(79, 17);
			this.checkBox5.TabIndex = 7;
			this.checkBox5.Text = "1920x1080";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// ControlForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::WinPolar.Properties.Resources.MenuPolar2561;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(256, 256);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ControlForm2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "800x60";
			this.Load += new System.EventHandler(this.ControlForm2_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
	}
}