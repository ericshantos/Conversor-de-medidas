using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Medidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selecionar = comboBox1.SelectedItem.ToString();

            if (comboBox1.SelectedIndex >= 0)
            {
                comboBox2.Enabled = true;
                textBoxC2.Enabled = true;
            }

            // adiciona os itens na comboBox2 de acordo com o item selecionado pelo usuário na comboBox1.

            switch (selecionar)
            {

                // adiciona itens de grandeza temperatura.

                case "Temperatura":

                    comboBox2.Items.Clear();
                    comboBox2.Sorted = true;

                    comboBox2.Items.Add("Celsius");
                    comboBox2.Items.Add("Kelvin");
                    comboBox2.Items.Add("Fahrenheit");

                    break;

                // adiciona itens de grandeza tempo.

                case "Tempo":

                    comboBox2.Items.Clear();
                    comboBox2.Sorted = false;

                    comboBox2.Items.Add("Ano");
                    comboBox2.Items.Add("Mês");
                    comboBox2.Items.Add("Dia");
                    comboBox2.Items.Add("Hora");
                    comboBox2.Items.Add("Minuto");

                    break;

                // adiciona itens de grandeza comprimento.

                case "Comprimento":

                    comboBox2.Items.Clear();
                    comboBox2.Sorted = false;

                    comboBox2.Items.Add("Quilômetro");
                    comboBox2.Items.Add("Hectômetro");
                    comboBox2.Items.Add("Diâmetro");
                    comboBox2.Items.Add("Metro");
                    comboBox2.Items.Add("Decímetro");
                    comboBox2.Items.Add("Centímetro");
                    comboBox2.Items.Add("Milímetro");

                    break;

            }
        }

        string selecionadoCB2;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Torna inviável a iteração com outros elementos do forms, até a selecção de um item na comboBox1.

            if (comboBox2.SelectedIndex >= 0)
            {
                comboBox3.Enabled = true;
                textBoxC3.Enabled = true;
            }

            string selecionadoCB2 = comboBox2.SelectedItem.ToString();

            // Garantia de que todos os itens presentes na comboBox1, menos o item selecionado, sejam copiados para comboBox2.

            comboBox3.Items.Clear();

            foreach (var item in comboBox2.Items)
            {
                if (item != comboBox2.SelectedItem)
                {
                    comboBox3.Items.Add(item);
                }
            }
        }

        private void textBoxC3_KeyPress(object sender, KeyPressEventArgs e)
        {

            // verifica se os caracteres digitados pelo usuário são números, se não forem, são bloqueados de serem inseridos.
            // sendo a única exceção a tecla delete.

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxC2_KeyPress(object sender, KeyPressEventArgs e)
        {

            // verifica se os caracteres digitados pelo usuário são números, se não forem, são bloqueados de serem inseridos.
            // sendo a única exceção a tecla delete.

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxC2_TextChanged(object sender, EventArgs e)
        {

            // tranfere para uma variável o nome do item selecionado pelo usuário no comboBox1.

            string selecionar = comboBox1.SelectedItem.ToString();

            // loop responsável pela filtragem e devida conversão de acordo com as escolhas do usuário.

            switch (selecionar)
            {
                // parte responsável pela conversão das unidades de grandeza temperatura.

                case "Temperatura":

                    // guarda em uma variável o nome do item selecionado pelo usuário na comboBox2.

                    string ConversorTemperatura = comboBox2.SelectedItem.ToString();

                    switch (ConversorTemperatura)
                    {
                        case "Celsius":

                            double temperaturaCelsius = 0.0;

                            if (string.IsNullOrEmpty(textBoxC2.Text))
                            {
                                textBoxC2.Text = "";
                                textBoxC3.Text = "";
                            }
                            else if (comboBox3.SelectedItem.ToString() == "Kelvin")
                            {
                                temperaturaCelsius = double.Parse(textBoxC2.Text);
                                double resultadoCCelsius = 0.0;

                                resultadoCCelsius = temperaturaCelsius + 273.15;

                                textBoxC3.Text = $"{resultadoCCelsius}K";
                            }
                            else if (comboBox3.SelectedItem.ToString() == "Fahrenheit")
                            {


                                temperaturaCelsius = int.Parse(textBoxC2.Text);
                                double resultadoCFahrenheit = 0.0;

                                resultadoCFahrenheit = (temperaturaCelsius * 1.8) + 32;

                                textBoxC3.Text = $"{resultadoCFahrenheit}F";

                            }


                                break;

                        case "Fahrenheit":

                            double temperaturaFahrenheit = 0.0;

                            if (string.IsNullOrEmpty(textBoxC2.Text))
                            {
                                textBoxC2.Text = "";
                                textBoxC3.Text = "";
                            }
                            else if (comboBox3.SelectedItem.ToString() == "Celsius")
                            {
                                temperaturaFahrenheit = double.Parse(textBoxC2.Text);
                                double resultadoCelsius = 0.0;

                                resultadoCelsius = ((temperaturaFahrenheit - 32) * 5/9);

                                textBoxC3.Text = $"{Math.Round(resultadoCelsius)}C";
                            }
                            else if (comboBox3.SelectedItem.ToString() == "Kelvin")
                            {
                                temperaturaFahrenheit = double.Parse(textBoxC2.Text);
                                double resultadoFKelvin = 0.0;

                                resultadoFKelvin = ((temperaturaFahrenheit - 32) * 5 / 9) + 273.15;

                                textBoxC3.Text = $"{Math.Round(resultadoFKelvin)}K";
                            }

                            break;

                        case "Kelvin":

                            double temperaturaKelvin = 0.0;

                            if (string.IsNullOrEmpty(textBoxC2.Text))
                            {
                                textBoxC2.Text = "";
                                textBoxC3.Text = "";
                            }
                            else if (comboBox3.SelectedItem.ToString() == "Celsius")
                            {
                                temperaturaKelvin = double.Parse(textBoxC2.Text);
                                double resultadoKCelsius = 0.0;

                                resultadoKCelsius = temperaturaKelvin - 273.15;

                                textBoxC3.Text = $"{Math.Round(resultadoKCelsius, 2)}C";
                            }
                            else if (comboBox3.SelectedItem.ToString() == "Fahrenheit")
                            {
                                temperaturaKelvin = int.Parse(textBoxC2.Text);
                                double resultadoKFahrenheit = 0.0;

                                resultadoKFahrenheit = ((temperaturaKelvin - 273.15) * 1.8) + 32;

                                textBoxC3.Text = $"{Math.Round(resultadoKFahrenheit)}F";
                            }

                            break;

                    }

                    break;

                case "Comprimento":


                    double unidadeInicial = comboBox2.SelectedIndex;
                    double unidadeFinal = 0.0;
                    string acompanhante = "";

                    if (string.IsNullOrEmpty(textBoxC2.Text))
                    {
                        textBoxC2.Text = "";
                        textBoxC3.Text = "";
                    }
                    else if (!string.IsNullOrEmpty(textBoxC2.Text))
                    {
                        double ConversorMetro = double.Parse(textBoxC2.Text);

                        switch (comboBox3.SelectedItem)
                        {
                            case "Quilômetro":

                                unidadeFinal = 0;
                                acompanhante = "Km";

                                break;

                            case "Hectômetro":

                                unidadeFinal = 1;
                                acompanhante = "Hm";

                                break;

                            case "Diâmetro":

                                unidadeFinal = 2;
                                acompanhante = "dam";

                                break;

                            case "Metro":

                                unidadeFinal = 3;
                                acompanhante = "m";

                                break;

                            case "Decímetro":

                                unidadeFinal = 4;
                                acompanhante = "dm";

                                break;

                            case "Centímetro":

                                unidadeFinal = 5;
                                acompanhante = "cm";

                                break;

                            case "Milímetro":

                                unidadeFinal = 6;
                                acompanhante = "mm";

                                break;
                        }

                        double resultadoComprimento = 0.0;

                        double expoente = Math.Abs(unidadeInicial - unidadeFinal);

                        if (unidadeInicial > unidadeFinal)
                        {
                            resultadoComprimento = ConversorMetro / Math.Pow(10, expoente);
                        }
                        else if (unidadeInicial < unidadeFinal)
                        {
                            resultadoComprimento = ConversorMetro * Math.Pow(10, expoente);
                        }

                        textBoxC3.Text = $"{resultadoComprimento}{acompanhante}";
                    }

                    break;
            }
        }
    }
}
