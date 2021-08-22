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
	public partial class MascotaPolar : Form
	{

		int contador = 0;//contador de segundos
		int valAle;//valor aleatorio de animacion
		int valAle2;
		Random r = new Random();//inicializacion de nuemro aleatorio
		int segA; //segundos adicionales que se nesecitan para que la transicion concluya correctamente
		public MascotaPolar()
		{
			InitializeComponent();
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			this.BackColor = Color.LimeGreen;
			this.TransparencyKey = Color.LimeGreen;

			timer1.Enabled = true;
			valAle = r.Next(8, 14); //primera animacion
			valAle2 = r.Next(25, 35);
			segA = 3;	
			
		}
		private void timer1_Tick(object sender, EventArgs e)// tick del timer(contador)
		{
			contador++;
			label1.Text = contador.ToString();
			Analizador();

		}
		private void Analizador()
		{
			if(contador == valAle) { pictureBox1.Visible = false; pictureBox2.Visible = true; }//cuando contador = valale, se activa trans. de pic1 y pic2
			if(contador == (valAle + segA)) { pictureBox2.Visible = false; pictureBox3.Visible = true;}
			
			if (contador == valAle2) { pictureBox3.Visible = false; pictureBox4.Visible = true; }// incorporacion de valAle2
			if(contador == (valAle2 + (segA-2))) { pictureBox4.Visible = false; pictureBox1.Visible = true; }//se le resta dos segundos a segA porque no concide la animacion
		}



		private bool val;
		void Mover()
		{
			this.Location = Cursor.Position;
		}

		//PictureBox1(Default Idle)
		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			val = false;
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{

			val = true;
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (val == true)
			{
				Mover();
			}

		}

		//PictureBox2(Ponerse Lentes)

		private void pictureBox2_MouseUp(object sender, MouseEventArgs e) // de picture 
		{
			val = false;
		}

		private void pictureBox2_MouseDown(object sender, MouseEventArgs e) //?
		{
			val = true;
		}

		private void pictureBox2_MouseMove(object sender, MouseEventArgs e) //?
		{
			if (val == true)
			{
				Mover();
			}
		}


		//PictureBox3(lentes idle)

		private void pictureBox3_MouseUp(object sender, MouseEventArgs e)//mover imagen mouseup
		{
			val = false;
		}

		private void pictureBox3_MouseDown(object sender, MouseEventArgs e)// mover imagen mousedown
		{
			val = true;
		}

		private void pictureBox3_MouseMove(object sender, MouseEventArgs e)//mover imagen mouse move
		{
			if (val == true)
			{
				Mover();
			}
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)// menu contextual de salir
		{
			this.Close();

		}

		private void cambiarPoseToolStripMenuItem_Click(object sender, EventArgs e)//menu contextual cambiar pose
		{}
		private void lentesToolStripMenuItem_Click(object sender, EventArgs e)
		{

			pictureBox2.Visible = true; pictureBox3.Visible = false; pictureBox4.Visible = false ;

		}

		private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false;
		}

		private void reiniciarTimerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			contador = 0;
		}
	}

}
