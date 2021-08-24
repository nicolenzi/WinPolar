
namespace WinPolar
{
	partial class MascotaPolar
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MascotaPolar));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cambiarPoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reiniciarTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarPoseToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(148, 70);
			// 
			// cambiarPoseToolStripMenuItem
			// 
			this.cambiarPoseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.lentesToolStripMenuItem});
			this.cambiarPoseToolStripMenuItem.Name = "cambiarPoseToolStripMenuItem";
			this.cambiarPoseToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.cambiarPoseToolStripMenuItem.Text = "Cambiar pose";
			this.cambiarPoseToolStripMenuItem.Click += new System.EventHandler(this.cambiarPoseToolStripMenuItem_Click);
			// 
			// defaultToolStripMenuItem
			// 
			this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
			this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.defaultToolStripMenuItem.Text = "Default";
			this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
			// 
			// lentesToolStripMenuItem
			// 
			this.lentesToolStripMenuItem.Name = "lentesToolStripMenuItem";
			this.lentesToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.lentesToolStripMenuItem.Text = "Lentes";
			this.lentesToolStripMenuItem.Click += new System.EventHandler(this.lentesToolStripMenuItem_Click);
			// 
			// timerToolStripMenuItem
			// 
			this.timerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarTimerToolStripMenuItem});
			this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
			this.timerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.timerToolStripMenuItem.Text = "Timer";
			// 
			// reiniciarTimerToolStripMenuItem
			// 
			this.reiniciarTimerToolStripMenuItem.Name = "reiniciarTimerToolStripMenuItem";
			this.reiniciarTimerToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.reiniciarTimerToolStripMenuItem.Text = "Reiniciar";
			this.reiniciarTimerToolStripMenuItem.Click += new System.EventHandler(this.reiniciarTimerToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.ContextMenuStrip = this.contextMenuStrip1;
			this.pictureBox3.Image = global::WinPolar.Properties.Resources.PolarLentesIdle;
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(112, 130);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
			this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
			this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
			// 
			// pictureBox2
			// 
			this.pictureBox2.ContextMenuStrip = this.contextMenuStrip1;
			this.pictureBox2.Image = global::WinPolar.Properties.Resources.porlarLentesAccion;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(112, 130);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
			this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
			this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WinPolar.Properties.Resources.porlar128p;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(121, 130);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1f";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(115, 130);
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			// 
			// MascotaPolar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(112, 142);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(1250, 615);
			this.Name = "MascotaPolar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Polar";
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cambiarPoseToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lentesToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reiniciarTimerToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox4;
	}
}

