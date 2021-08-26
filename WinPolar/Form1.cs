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
			Animacion1();
			this.BackColor = Color.LimeGreen;
			this.TransparencyKey = Color.LimeGreen;

			timer1.Enabled = true;
			valAle = r.Next(8, 14); //primera animacion
			valAle2 = r.Next(25, 35);
			segA = 3;

			
			
		}
		private void timer1_Tick(object sender, EventArgs e)// Timer(contador)
		{
			contador++;
			label1.Text = contador.ToString();
			Analizador();

		}
		private void Analizador()
		{
			if(contador == valAle) { Animacion2(); }//cuando contador = valale, se activa trans. de pic1 y pic2
			if(contador == (valAle + segA)) { Animacion3(); }
			
			if (contador == valAle2) { Animacion4(); }// incorporacion de valAle2
			if(contador == (valAle2 + (segA-2))) { Animacion1(); }//se le resta dos segundos a segA porque no concide la animacion
			if (contador == 60) {contador = 1;}
		}



		private bool val;
		void Mover()// metodo para mover imagenes
		{ //la posicion actual va a ser igual a la posicion del mouse mas el acomodo 
			this.Location = Cursor.Position + new Size(-60,-60);
		}

		//PictureBox1(Default Idle)
		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)// al levantar el mouse
		{val = false;}
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)// al mantener pulsado mouse(click izq)
		{val = true;}
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)// al mover el mouse
		{ if (val == true) { Mover(); } }

		//PictureBox2(Ponerse Lentes)
		private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
		{val = false;}
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
		{val = true;}
		private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
		{ if (val == true) {Mover();} }

		//PictureBox3(lentes idle)
		private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
		{val = false;}
		private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
		{val = true;}
		private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
		{if (val == true){Mover();}}

		//pictureBox4(sacarse lentes)
		private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
		{ val = false; }
		private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
		{ val = true; }
		private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
		{ if (val == true) { Mover(); } }


		private void salirToolStripMenuItem_Click(object sender, EventArgs e)// menu contextual de salir
		{
			this.Close();
		}

		private void lentesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			contador = 0;
			if(contador == 0) { Animacion3();timer1.Enabled = false; }
			
			
		}

		private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
		{
			contador = 0;
			if(contador == 0) { Animacion1();timer1.Enabled = false; }
		}

		private void reiniciarTimerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			contador = 0;
			Animacion1();
			timer1.Enabled = true;
			
		}
		public void Animacion1() //p1=t,p2=f,p3=f,p4=f;
		{pictureBox1.Visible= true;pictureBox2.Visible= false;pictureBox3.Visible= false;pictureBox4.Visible= false;}
		public void Animacion2() //p1=f,p2=t,p3=f,p4=f;
		{pictureBox1.Visible= false;pictureBox2.Visible= true;pictureBox3.Visible= false;pictureBox4.Visible= false;}
		public void Animacion3() //p1=f,p2=f,p3=t,p4=f;
		{pictureBox1.Visible= false;pictureBox2.Visible= false;pictureBox3.Visible= true;pictureBox4.Visible= false;}
		public void Animacion4() //p1=f,p2=f,p3=f,p4=t;
		{pictureBox1.Visible= false;pictureBox2.Visible= false;pictureBox3.Visible= false;pictureBox4.Visible= true;}

		private void verOcultarTimerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			label1.Visible = true;
		}

		private void oultarTimerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			label1.Visible = false;
		}
	}

}
