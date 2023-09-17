using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Medidas
{
    internal class Kelvin
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
            resultado = entradaCelsius - 273.15;
            return resultado;
        }

        public double Fahrenheit(double entradaFahrenheit)
        {
            resultado = (entradaFahrenheit - 273.15) * 9/5 +32;
            return resultado;
        }
    }
}
