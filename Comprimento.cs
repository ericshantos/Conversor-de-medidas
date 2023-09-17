using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Medidas
{
    class Comprimento
    {
        private int unidadeInicial;
        private int unidadeFinal;
        private double resultado;
        private double conversao;

        public double Conversao
        {
            get
            {
                return conversao;
            }
            set
            {
                conversao = value;
            }
        }

        public int UnidadeInicial
        {
            get
            {
                return unidadeInicial;
            }
            set
            {
                unidadeInicial = value;
            }
        }

        public int UnidadeFinal
        {
            get
            {
                return unidadeFinal;
            }
            set
            {
                unidadeFinal = value;
            }
        }

        public double Conversor(double valor)
        {
            double expoente = Math.Abs(unidadeInicial - unidadeFinal);

            if (unidadeInicial < unidadeFinal)
            {
                resultado = valor / Math.Pow(10, expoente);
            }
            else if (unidadeInicial > unidadeFinal)
            {
                resultado = valor * Math.Pow(10, expoente);
            }

            return resultado;
        }
    }
}
