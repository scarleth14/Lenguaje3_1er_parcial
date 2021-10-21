using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class DespachoLegal : Form
    {
        public DespachoLegal()
        {
            InitializeComponent();
        }

        //Instanciar las clases 
        Cliente cliente;
        Solicitudes solicitud;

        private void ValidarDatos()
        {
            //Valida que los textbox de nombre y correo no queden vacíos
            if (txt_nombre.Text == string.Empty)
            {
                errorProvider1.SetError(txt_nombre, "Ingrese el nombre");
                txt_nombre.Focus();
            }
            else
            {
                errorProvider1.SetError(txt_nombre, null);
            }

            if (txt_CorreoElectronico.Text == string.Empty)
            {
                errorProvider1.SetError(txt_CorreoElectronico, "Ingrese el correo eléctronico");
                txt_CorreoElectronico.Focus();
            }
            else
            {
                errorProvider1.SetError(txt_CorreoElectronico, null);
            }
        }


        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            //Variables locales
            int codigo = 100;
            int edad = 0;
            int _edad ;

            //Imprime el codigo de cliente en su TextBox
            txt_codigoCliente.Text  = Convert.ToString(codigo);

           //Le suma uno al codigo cada vez que presiona el botón
            codigo = codigo + 1;

            //Llama a la función que devuelve la edad 
            txt_edad.Text = DevolverEdad(dtp_FechaNacimiento.Value, edad).ToString();
            //Guarda la edad en la variables _edad
            _edad= DevolverEdad(dtp_FechaNacimiento.Value, edad);

            //Si tiene 18 o más años puede realizar trámites legales 
            if (_edad>=18)
            {
                ValidarDatos();

                btn_EnviarSolicitud.Enabled = true;
               
                cliente = new Cliente();
                cliente.NombreCliente = txt_nombre.Text;
                cliente.Edad = Convert.ToInt32(txt_edad.Text);
                cliente.Correo = txt_CorreoElectronico.Text;
                cliente.Genero = cb_genero.Text;

                ExpedienteClienteListBox.Items.Add("El cliente " + cliente.NombreCliente + " con " + cliente.Edad + " años de edad, de genero "
                    + cliente.Genero + " y correo eléctronico " + cliente.Correo + " fue agregado con éxito");
            }
            else if (_edad<18)
            {
                MessageBox.Show("No tiene la edad suficiente para solicitar servicios legales");
                btn_EnviarSolicitud.Enabled = false;
            }
        }

      
        private int DevolverEdad(DateTime FechaNacimiento, int edad)
        {
            DateTime FechaActual = DateTime.Now;

            if (FechaNacimiento.Day >= FechaActual.Day)
            {
                return 0;
               
            }
            {
                edad = FechaActual.Year - FechaNacimiento.Year;

                if (FechaNacimiento.Month > FechaActual.Month)
                {
                    --edad;
                }
            }

            return edad;
        }

        private void LimpiarDatos()
        {
            dtp_FechaNacimiento.Value = DateTime.Now;
            txt_nombre.Clear();
            cb_genero.Text = " ";
            txt_CorreoElectronico.Text = string.Empty;
            txt_edad.Clear();
            txt_codigoCliente.Clear();
            ExpedienteClienteListBox.Items.Clear();
            SolicitudTrabajoListBox.Items.Clear();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btn_EnviarSolicitud_Click(object sender, EventArgs e)
        {
            solicitud = new Solicitudes(cb_TrabajoSolicitado.Text);

            lbl_NombreCliente.Text = txt_nombre.Text;

            MessageBox.Show("Su solicitud fue realizada con éxito");

            SolicitudTrabajoListBox.Items.Add("El cliente solicitó el servicio de: " + cb_TrabajoSolicitado.Text);
        }
    }
}
