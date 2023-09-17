using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Medidas
{
    class Celsius
    {
        private double resultado;
        private double temperatura;

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

        public double Kelvin(double entradaKelvin)
        {
            resultado = entradaKelvin + 273.15;
            return resultado;
        }

        public double Fahrenheit(double entradaFahrenheit)
        {
            resultado = (entradaFahrenheit * 1.8) + 32;
            return resultado;
        }
    }
}
