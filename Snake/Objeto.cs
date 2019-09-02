using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Objeto
    {
        protected int x, y, ancho;

        public Objeto()
        {
            this.ancho = 10;
        }

        public bool Interseccion(Objeto o)
        {
            int difx = Math.Abs(this.x - o.x);
            int dify = Math.Abs(this.y - o.y);
            if (difx >= 0 && difx < ancho && dify >= 0 && dify < ancho)
                return true;
            else
                return false;
        }

    }
}
