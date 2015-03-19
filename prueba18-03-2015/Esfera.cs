using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba18_03_2015
{
    class Esfera : figura
    {
        private double radio;
        private static double PI = 3.1416;

        public Esfera(double radio)
        {
            this.radio = radio;
        }

        override public void calcularArea()
        {
            this.area = 4 * PI * radio * radio;
        }

        override public void calcularVolumen()
        {
            this.volumen = (4 / 3) * PI * radio * radio * radio;
        }

        override public void pintar()
        {

        }
    }
}
