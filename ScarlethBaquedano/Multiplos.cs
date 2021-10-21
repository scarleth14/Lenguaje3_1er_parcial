using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScarlethBaquedano
{
    public partial class Multiplos : Form
    {
        public Multiplos()
        {
            InitializeComponent();
        }

        string nombre, apellido;

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            MostrarMultiplos();
        }

        //Valida que solo se ingresen caracteres en los TextBox
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                errorProvider1.SetError(txt_nombre, null);
                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(txt_nombre, null);
                e.Handled = false;

            }
            else
            {
                errorProvider1.SetError(txt_nombre, "Debe ingresar letras");
                e.Handled = true;

            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                errorProvider1.SetError(txt_apellido, null);
                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(txt_apellido, null);
                e.Handled = false;

            }
            else
            {
                errorProvider1.SetError(txt_apellido, "Debe ingresar letras");
                e.Handled = true;

            }
        }

        //Valida que los TextBox no queden vacíos
        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese su nombre");
                btn_mostrar.Enabled = false;
                txt_nombre.Focus();
            }
            else
            {
                btn_mostrar.Enabled = true;
            }
        }

        private void txt_apellido_Leave(object sender, EventArgs e)
        {
            if (txt_apellido.Text == string.Empty)
            {
                MessageBox.Show("Ingrese su apellido");
                btn_mostrar.Enabled = false;
                txt_apellido.Focus();
            }
            else
            {
                btn_mostrar.Enabled = true;
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lbx_numeros.Items.Clear();
            lbx_MultiplosDe3.Items.Clear();
            lbx_MultiplosDe5.Items.Clear();
            lbx_MultiplosDe3y5.Items.Clear();
        }

        //Manda a llamar a otro formulario
        private void pbx_siguiente_Click(object sender, EventArgs e)
        {
            Interes interes = new Interes();
            interes.Show();
            this.Hide();
        }

       
        public void MostrarMultiplos()
        {
            nombre = txt_nombre.Text;
            apellido = txt_apellido.Text;

            for (int i = 1; i <=100; i++)
            {
                //Imprime los numeros del 1 al 100
                lbx_numeros.Items.Add(i);
                //Si el numero es multiplo de 3 imprime el nombre
                if (i % 3 == 0)
                {
                    lbx_MultiplosDe3.Items.Add(i + " " + nombre);
                }
                //Si el número es multiplo de 5 imprime los apellidos
                if (i % 5 == 0)
                {
                    lbx_MultiplosDe5.Items.Add(i + " " + apellido);
                }
                //Si el número es multiplo de 3 y 5 imprime el nombre y apellido
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    lbx_MultiplosDe3y5.Items.Add(i + " " + nombre +" " + apellido);
                }
            }
        }
    }
}
