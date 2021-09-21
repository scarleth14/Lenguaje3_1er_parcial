using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
    //Presentado por: Scarleth Abigail Baquedano Padilla
    //Número de cuenta: 20191001765
    //Última modificación: 16/9/2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            //Llama a la función que limpia los controles 
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            NumeroTextBox.Clear();
            NumeroParLabel.Text = "";
            NumeroImparLabel.Text = "";
            NumeroPrimoLabel.Text = "";
        }

        private int NumeroParEImpar(int numero)
        {
            //Si el residuo de dividir el número entre dos es exacto, el número es par. Sino, es impar.
            if (numero % 2 == 0)
            {
                NumeroParLabel.Text = "El número es par";
                NumeroImparLabel.Text = "";
            }
            else
            {
                NumeroImparLabel.Text = "El número es impar";
                NumeroParLabel.Text = "";
            }
            return numero;
        }

        private int NumeroPrimo(int numero)
            //Un número primo es aquel que es divisible de manera entera entre 1 y entre si mismo.
        {
            //Variables locales
            int x = 1, contador = 0;

            while (x <= numero)
            {
                if (numero % x == 0)
                {
                    //Cuenta las divisiones exactas
                    contador = contador + 1;
                }
                x = x + 1;
            }

            //Se evalúa si el número tuvo unicamente dos divisiones.
            if (contador == 2) {
                NumeroPrimoLabel.Text = "El número es primo";
            }
            else
            {
                NumeroPrimoLabel.Text = "El número no es primo";
            }

            return numero;
        }

        private void ResultadoButton_Click(object sender, EventArgs e)
        {
            //Almacena el numero que ingresó el usuario en una variable
            int NumeroIngresado = Convert.ToInt32(NumeroTextBox.Text);
            //Envía el número ingresado a cada función 
            NumeroParEImpar(NumeroIngresado);
            NumeroPrimo(NumeroIngresado);
        }
    }
}
