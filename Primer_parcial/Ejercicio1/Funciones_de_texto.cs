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
{
    public partial class Funciones_de_texto : Form
    {
        public Funciones_de_texto()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            string cadena = txt_cadena.Text;

            //Obtiene la longitud de la cadena
            txt_longitud.Text = cadena.Length.ToString();

            //Obtiene el primer elemento de la cadena
            txt_primer_caracter.Text = cadena.Substring(0, 1);

            //Obtiene el ultimo elemento
            txt_ultimo_caracter.Text = cadena.Substring(cadena.Length - 1, 1);

            //Obtiene un rango de caracteres
            txt_rango.Text = cadena.Substring(5, 15);

            //Convertir a mayusculas
            txt_mayusculas.Text = cadena.ToUpper();

            //Convertir a minusculas
            txt_minuscula.Text = cadena.ToLower();

            //Reemplazar caracteres
            txt_reemplazar.Text = cadena.Replace("a", "b");

        }
    }
}
