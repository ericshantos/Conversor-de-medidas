using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Medidas
{
    class Fahrenheit
    {
        private double resultado;

        public double Resultado
        {
            get
            {
                return resultado;
            }
            set
            {
                resultado = value;
            }
        }

        public double Celsius(double entradaCelsius)
        {
            resultado = (entradaCelsius - 32) * 5/9;
            return resultado;
        }

        public double Kelvin(double entradaKelvin)
        {
            resultado = (entradaKelvin -32) * 5/9 + 273.15;
            return resultado;
        }
    }
}
