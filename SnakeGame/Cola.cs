using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Cola : Objeto
    {
        Cola siguiente;
        public Cola(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.siguiente = null;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public void Dibujar(Graphics g)
        {
            if (siguiente != null)
                siguiente.Dibujar(g);

            g.FillRectangle(new SolidBrush(Color.Red), this.x, this.y, this.ancho, this.ancho);
        }

        public void SetCordenadas(int x, int y)
        {
            if (siguiente != null)
            {
                siguiente.SetCordenadas(this.x, this.y);
            }
            this.x = x;
            this.y = y;
        }

        public void Meter()
        {
            if (siguiente == null)
            {
                siguiente = new Cola(this.x, this.y);
            }
            else
            {
                siguiente.Meter();
            }
        }

        public Cola ObtenerSiguiente()
        {
            return siguiente;
        }
    }
}
