using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avesEjercicio
{
    public partial class Form1 : Form
    {
        int valor = 0;
        public Form1()
        {
            InitializeComponent();
        }
        int x, y;
        int x1, y2;
        int tiempojuego = 0;
        int puntosImagen1 = 0;
        int punTotales1 = 0;
        int punTotales2 = 0;
        public void InicializaTiempo()
        {
            tiempojuego = 60;
            lbTiempo.Text = "Tiempo " + tiempojuego.ToString();
            tiempoEjecucion.Start();
            picBoxAve1.Visible = true;
            picBoxAve2.Visible = true;
            lbPuntosImagen1.Visible = false;
            lbPuntosImagen2.Visible = false;
            puntosImagen1 = 0;
            lbPuntos.Text = "Total Puntos: " + puntosImagen1.ToString();
            punTotales1 = 0;
            lbPuntosImagen1.Text="PUNTOS IMAGEN 1: " + punTotales1.ToString();
            punTotales2 = 0;
            lbPuntosImagen2.Text = "PUNTOS IMAGEN 1: " + punTotales2.ToString();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void picBoxAve1_Click(object sender, EventArgs e)
        {
          
            puntosImagen1++;
            lbPuntos.Text = "Total Puntos: " + puntosImagen1.ToString();

            punTotales1++;
            lbPuntosImagen1.Text = "PUNTOS IMAGEN 1: " + punTotales1.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Visible = false;
            tiempo.Start();
            InicializaTiempo();
            timer2.Start();

        }

        private void picBoxAve2_Click(object sender, EventArgs e)
        {
            puntosImagen1++;
            lbPuntos.Text = "Total Puntos: " + puntosImagen1.ToString();
            tiempojuego +=1;
            lbTiempo.Text = "Tiempo " + tiempojuego.ToString();


            punTotales2++;
            lbPuntosImagen2.Text = "PUNTOS IMAGEN 2: " + punTotales2.ToString();

        }

        private void lbPuntos_Click(object sender, EventArgs e)
        {
           

        }

        private void tiempoEjecucion_Tick(object sender, EventArgs e)
        {
            tiempojuego--;
            lbTiempo.Text = "Tiempo " + tiempojuego.ToString();


            if (tiempojuego < 61 && tiempojuego >= 51)
            {
                picBoxAve1.Visible = true;
                picBoxAve2.Visible = false;

            }
            if (tiempojuego <= 50 && tiempojuego >= 45)
            {
                picBoxAve1.Visible = false;
                picBoxAve2.Visible = true;
             
            }
            if (tiempojuego <= 44  && tiempojuego >= 35)
            {
                picBoxAve1.Visible = true;
                picBoxAve2.Visible = false;
              
            }
            if (tiempojuego <= 34 && tiempojuego >= 30)
            {
                picBoxAve1.Visible = false;
                picBoxAve2.Visible = true;
              
            }
            if (tiempojuego <= 29 && tiempojuego >= 20 )
            {
                picBoxAve1.Visible = true;
                picBoxAve2.Visible = false;
              
            }
            if (tiempojuego <= 19 && tiempojuego >= 15)
            {
                picBoxAve1.Visible = false;
                picBoxAve2.Visible = true;

            }

            if (tiempojuego <= 14 && tiempojuego >= 5)
            {
                picBoxAve1.Visible = true;
                picBoxAve2.Visible = false;
            }

            if (tiempojuego <= 5 )
            {
                picBoxAve1.Visible = false;
                picBoxAve2.Visible = true;

            }
            if (tiempojuego <=0)
            {
                tiempoEjecucion.Stop();
                tiempo.Stop();
                timer2.Stop();
                picBoxAve1.Visible = false;
                picBoxAve2.Visible = false;
                btnIniciar.Visible = true;
                lbPuntosImagen1.Visible = true;
                lbPuntosImagen2.Visible = true;
            }
        }

        private void lbTiempo_Click(object sender, EventArgs e)
        {
            
                
                }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random pos2 = new Random();
            x1 = pos2.Next(30, 600);
            y2 = pos2.Next(30, 600);

            picBoxAve2.Location = new Point(x1, y2);
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            Random pos = new Random();
            x = pos.Next(20, 600);
            y = pos.Next(20, 600);

            picBoxAve1.Location = new Point(x, y);
           


        }
    }
}
