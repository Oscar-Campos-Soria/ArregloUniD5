using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ArregloUniD5
{
    public partial class Form1 : Form

    {
        private int[] arregloUnidimensional;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            int longitud;

            if (int.TryParse(txtLong.Text, out longitud) && longitud > 0)
            {
                arregloUnidimensional = new int[longitud];
                MessageBox.Show("Arreglo unidimensional creado con éxito. Por favor, ingrese los elementos.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una longitud válida para el arreglo.");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (arregloUnidimensional != null)
            {
                // Ingresar elementos en el arreglo
                for (int i = 0; i < arregloUnidimensional.Length; i++)
                {
                    using (var inputDialog = new Form())
                    {
                        var label = new Label() { Left = 20, Top = 20, Text = $"Ingrese el elemento {i + 1}:" };
                        var textBox = new TextBox() { Left = 20, Top = 50 };
                        var button = new Button() { Text = "Aceptar", Left = 20, Top = 80 };

                        button.Click += (sender, e) =>
                        {
                            if (int.TryParse(textBox.Text, out int elemento))
                            {
                                arregloUnidimensional[i] = elemento;
                                inputDialog.DialogResult = DialogResult.OK;
                                inputDialog.Close();
                            }
                            else
                            {
                                MessageBox.Show("Por favor, ingrese un valor entero válido.");
                            }
                        };

                        inputDialog.Controls.Add(label);
                        inputDialog.Controls.Add(textBox);
                        inputDialog.Controls.Add(button);

                        inputDialog.AcceptButton = button;

                        if (inputDialog.ShowDialog() != DialogResult.OK)
                        {
                            MessageBox.Show("Debe ingresar todos los elementos del arreglo.");
                            return;
                        }
                    }
                    // Calcular la suma, el promedio, el valor máximo y el valor mínimo
                    int suma = arregloUnidimensional.Sum();
                    double promedio = arregloUnidimensional.Average();
                    int maximo = arregloUnidimensional.Max();
                    int minimo = arregloUnidimensional.Min();

                    {
                        // Mostrar resultados
                        MessageBox.Show($"Suma de los elementos: {suma}\nPromedio de los elementos: {promedio}\nValor máximo: {maximo}\nValor mínimo: {minimo}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, cree primero el arreglo unidimensional.");
            }


                }
            }

            
        }
    

