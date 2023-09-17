using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Conversor_de_Medidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Selecionado selecionado = new Selecionado();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionado.SCB1 = comboBox1.SelectedItem.ToString();

            if (comboBox1.SelectedIndex >= 0)
            {
                comboBox2.Enabled = true;
                textBoxCB2.Enabled = true;
            }


            // Agora você pode usar minhaVariavel com o valor atribuído


            // adiciona os itens na comboBox2 de acordo com o item selecionado pelo usuário na comboBox1.

            switch (selecionado.SCB1)
            {

                // adiciona itens de grandeza temperatura.

                case "Temperatura":

                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox2.Sorted = true;

                    comboBox2.Items.Add("Celsius");
                    comboBox2.Items.Add("Kelvin");
                    comboBox2.Items.Add("Fahrenheit");

                    break;

                // adiciona itens de grandeza tempo.

                case "Tempo":

                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
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
                    comboBox3.Items.Clear();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Torna inviável a iteração com outros elementos do forms, até a selecção de um item na comboBox1.

            if (comboBox2.SelectedIndex >= 0)
            {
                comboBox3.Enabled = true;
                textBoxCB3.Enabled = true;
            }


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

        private void textBoxCB2_KeyPress(object sender, KeyPressEventArgs e)
        {

            // verifica se os caracteres digitados pelo usuário são números, se não forem, são bloqueados de serem inseridos.
            // sendo a única exceção a tecla delete.

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxCB3_KeyPress(object sender, KeyPressEventArgs e)
        {

            // verifica se os caracteres digitados pelo usuário são números, se não forem, são bloqueados de serem inseridos.
            // sendo a única exceção a tecla delete.

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxCB2_TextChanged(object sender, EventArgs e)
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

                    double ValorTemperatura = 0.0;

                    switch (ConversorTemperatura)
                    {
                        case "Celsius":

                            Celsius celsius = new Celsius();
                            double resultado = 0.0;

                            if (double.TryParse(textBoxCB2.Text, out ValorTemperatura))
                            {
                                if (comboBox3.SelectedItem.ToString() == "Kelvin")
                                {
                                    resultado = celsius.Kelvin(ValorTemperatura);

                                    textBoxCB3.Text = $"{resultado}";
                                }
                                else if (comboBox3.SelectedItem.ToString() == "Fahrenheit")
                                {
                                    resultado = celsius.Fahrenheit(ValorTemperatura);

                                    textBoxCB3.Text = $"{resultado}";
                                }
                            }
                            else
                            {
                                textBoxCB2.Text = "";
                                textBoxCB3.Text = "";
                            }

                            break;

                        case "Fahrenheit":

                            Fahrenheit fahrenheit = new Fahrenheit();

                            if (double.TryParse(textBoxCB2.Text, out ValorTemperatura))
                            {
                                if (comboBox3.SelectedItem.ToString() == "Celsius")
                                {
                                    resultado = fahrenheit.Celsius(ValorTemperatura);

                                    textBoxCB3.Text = $"{resultado}";
                                }
                                else if (comboBox3.SelectedItem.ToString() == "Kelvin")
                                {
                                    resultado = fahrenheit.Kelvin(ValorTemperatura);

                                    textBoxCB3.Text = $"{Math.Round(resultado, 2)}";
                                }
                            }
                            else
                            {
                                textBoxCB2.Text = "";
                                textBoxCB3.Text = "";
                            }

                            break;

                        case "Kelvin":

                            Kelvin kelvin = new Kelvin();

                            if (double.TryParse(textBoxCB2.Text, out ValorTemperatura))
                            {
                                if (comboBox3.SelectedItem.ToString() == "Celsius")
                                {
                                    resultado = kelvin.Celsius(ValorTemperatura);

                                    textBoxCB3.Text = $"{resultado}";
                                }
                                else if (comboBox3.SelectedItem.ToString() == "Fahrenheit")
                                {
                                    resultado = kelvin.Fahrenheit(ValorTemperatura);

                                    textBoxCB3.Text = $"{resultado}";
                                }
                            }
                            else
                            {
                                textBoxCB2.Text = "";
                                textBoxCB3.Text = "";
                            }

                            break;

                    }

                    break;

                case "Comprimento":

                    if (double.TryParse(textBoxCB2.Text, out double comprimento))
                    {
                        Comprimento unidades = new Comprimento();
                        unidades.UnidadeInicial = comboBox3.SelectedIndex;

                        switch (selecionado.SCB3)
                        {
                            case "Quilômetro":
                                unidades.UnidadeFinal = 0;

                                break;

                            case "Hectômetro":
                                unidades.UnidadeFinal = 1;

                                break;

                            case "Decâmetro":
                                unidades.UnidadeFinal = 2;

                                break;

                            case "Metro":
                                unidades.UnidadeFinal = 3;

                                break;

                            case "Decímetro":
                                unidades.UnidadeFinal = 4;

                                break;

                            case "Centímetro":
                                unidades.UnidadeFinal = 5;

                                break;

                            case "Milímetro":
                                unidades.UnidadeFinal = 6;

                                break;
                        }

                        unidades.Conversao = unidades.Conversor(comprimento);
                        textBoxCB3.Text = $"{unidades.Conversao}";
                    }
                    else
                    {
                        textBoxCB2.Text = "";
                        textBoxCB3.Text = "";
                    }

                    break;
            }
        }
    }
}
