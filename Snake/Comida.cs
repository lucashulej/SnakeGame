using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Comida : Objeto
    {
        public Comida()
        {
            this.x = this.PosicionAleatoria(78);
            this.y = this.PosicionAleatoria(39);
        }

        public int PosicionAleatoria(int n)
        {
            Random random = new Random();
            int retorno = random.Next(0, n) * 10;
            return retorno;
        }

        public void Colocar()
        {
            this.x = this.PosicionAleatoria(78);
            this.y = this.PosicionAleatoria(39);
        }


        public void Dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.DarkSeaGreen), this.x, this.y, this.ancho, this.ancho);

        }
    }

}
