using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Graphics g;
        Cola cabeza;
        Comida comida;
        int dirx = 0;
        int diry = 0;
        bool ejex = true;
        bool ejey = true;
        int cuadro = 10;
        int puntos = 0;

        public Form1()
        {
            InitializeComponent();

            g = canvas.CreateGraphics();
            cabeza = new Cola(10, 10);
            comida = new Comida();

        }

        public void Movimiento()
        {
            cabeza.SetCordenadas(cabeza.GetX() + dirx, cabeza.GetY() + diry);
        }

        private void Bucle_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            cabeza.Dibujar(g);
            comida.Dibujar(g);
            this.Movimiento();
            if(cabeza.Interseccion(comida))
            {
                comida.Colocar();
                cabeza.Meter();
                puntos++;
                this.lblPuntos.Text = puntos.ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ejex) // SI X ES TRUE PUEDO MOVER EL Y
            {
                if (e.KeyCode == Keys.Up) //ARRIBA
                {
                    this.diry = -cuadro;
                    this.dirx = 0;
                    this.ejex = false;
                    this.ejey = true;
                }

                if (e.KeyCode == Keys.Down) //ABAJO
                {
                    this.diry = cuadro;
                    this.dirx = 0;
                    this.ejex = false;
                    this.ejey = true;
                }
            }

            if (this.ejey) // SI Y ES TRUE PUEDO MOVER EL X
            {
                if (e.KeyCode == Keys.Right) //DERECHA
                {
                    this.diry = 0;
                    this.dirx = cuadro;
                    this.ejex = true;
                    this.ejey = false;

                }

                if (e.KeyCode == Keys.Left) //IZQUIERDA
                {
                    this.diry = 0;
                    this.dirx = -cuadro;
                    this.ejex = true;
                    this.ejey = false;
                }
            }
        }
    }
}
