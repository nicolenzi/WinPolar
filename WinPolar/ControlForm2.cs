using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPolar
{
	public partial class ControlForm2 : Form
	{
		public ControlForm2()
		{
			InitializeComponent();
		}
		bool val = false;

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			val = true;
		}
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (val == true) { this.Location = Cursor.Position; }
		}
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			val = false;
		}

		private void panel2_MouseClick(object sender, MouseEventArgs e)
		{
			this.Close();
		}

		private void panel3_MouseClick(object sender, MouseEventArgs e)
		{
			
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void ControlForm2_Load(object sender, EventArgs e)
		{

		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{

		}

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
