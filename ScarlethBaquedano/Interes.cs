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
    public partial class Interes : Form
    {
        public Interes()
        {
            InitializeComponent();
        }

        decimal deposito;

        private void Interes_Load(object sender, EventArgs e)
        {
            //Configura los textbox para que sean de solo lectura
            txt_deposito.ReadOnly = true;
            txt_TasaInteres.ReadOnly = true;
            txt_TasaInteres.Text = "1.5%";
            //Asigna el valor del déposito
            deposito = 200000;
            txt_deposito.Text = deposito.ToString("N2");
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            CalcularInteres();
            btn_mostrar.Enabled = false;
        }

        private void CalcularInteres()
        {
            decimal[] _interes = new decimal[12];
            string[] mes = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            for (int i = 0; i < _interes.Length; i++)
            {
                //Calcula el interes de cada mes
                _interes[i] = deposito * 0.015M;
                //Acumula el saldo del mes anterior
                deposito = deposito + _interes[i];
                //Imprime los resultados en un ListView
                ListViewItem elemento = new ListViewItem(mes[i]);
                elemento.SubItems.Add(_interes[i].ToString("N2"));
                lvw_interes.Items.Add(elemento); 
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            //Inicializa el valor del déposito
            deposito = 200000;
            
            lvw_interes.Items.Clear();
            
            btn_mostrar.Enabled = true;
        }

        private void pbx_siguiente_Click(object sender, EventArgs e)
        {
            //Llama a otro formulario
            Descuento descuento = new Descuento();
            descuento.Show();
            this.Hide();
        }

        
    }
}
