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
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
            cb_producto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        decimal subtotal, _subtotal, _descuento, precio;
        int cantidad;

        private async void btn_calcular_Click(object sender, EventArgs e)
        {
            string nombreProducto;

            AsignarPrecio();
            txt_precio.Text = precio.ToString("N2");
            cantidad = Convert.ToInt32(txt_cantidad.Text);
            subtotal = precio * cantidad;
            //acumula los subtotales 
            _subtotal = _subtotal + subtotal; 
            txt_subtotal.Text = _subtotal.ToString("N2");
            //Manda a llamar a las funciones que calculan el descuento y el pago total
            txt_descuento.Text = (await CalcularDescuento(_subtotal)).ToString("N2");
            txt_pagoTotal.Text = (await CalcularPagoTotal(_subtotal, _descuento)).ToString("N2");

            //Almacena el nombre del producto
            nombreProducto = Convert.ToString(cb_producto.SelectedItem);

            lbx_productos.Items.Add("Se agregó el producto '" + nombreProducto + "' con éxito. ");
        }

        private void AsignarPrecio()
        {
            int op = cb_producto.SelectedIndex;
            //Asigna el costo unitario de cada producto 
            switch (op)
            {
                case 0:
                    precio = 3.50M;
                    break;
                case 1:
                    precio = 25;
                    break;
                case 2:
                    precio = 11;
                    break;
                case 3:
                    precio = 20;
                    break;
                case 4:
                    precio = 35;
                    break;
                case 5:
                    precio = 40;
                    break;
                case 6:
                    precio = 10;
                    break;
                case 7:
                    precio = 36.50M;
                    break;
            }
        }

        //Función asincrona que calcula el descuento
        private async Task<decimal> CalcularDescuento(decimal subtotal)
        {
            decimal descuento = await Task.Run(() =>
            {
                return subtotal * 0.15M;
            });
            _descuento = descuento;
            return descuento;
        }

        //Funcion asincrona que calcula el pago total
        private async Task<decimal> CalcularPagoTotal(decimal subtotal, decimal descuento)
        {
            decimal pagoTotal = await Task.Run(() =>
            {
                return subtotal - descuento;
            });
            return pagoTotal;
        }

        private void Descuento_Load(object sender, EventArgs e)
        {
            //Configura los textbox para que sean sólo de lectura
            txt_subtotal.ReadOnly = true;
            txt_descuento.ReadOnly = true;
            txt_pagoTotal.ReadOnly = true;
            txt_precio.ReadOnly = true;
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida que el usuario ingrese número
            if (char.IsNumber(e.KeyChar)) 
            {
                errorProvider1.SetError(txt_cantidad, null);
                e.Handled = false;
                
            }else if (char.IsControl (e.KeyChar)){
                errorProvider1.SetError(txt_cantidad, null);
                e.Handled = false;
                
            }
            else
            {
                errorProvider1.SetError(txt_cantidad, "Debe ingresar un número");
                e.Handled = true;
 
            }
        }

        private void pbx_siguiente_Click(object sender, EventArgs e)
        {
            //Llama al formulario de multiplos
            Multiplos multiplos = new Multiplos();
            multiplos.Show();
            this.Hide();
        }

       

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                subtotal = subtotal + precio;
            }

            //Valida que el textbox de cantidad no quede vacío
            if (txt_cantidad.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la cantidad");
                btn_calcular.Enabled = false;
                txt_cantidad.Focus();
            }
            else
            {
                btn_calcular.Enabled = true;
            }
        }

        private void Limpiar()
        {
            cb_producto.Text = " ";
            txt_precio.Clear();
            txt_cantidad.Clear();
            txt_descuento.Clear();
            txt_pagoTotal.Clear();
            txt_subtotal.Clear();
            lbx_productos.Items.Clear();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        
    }
}
