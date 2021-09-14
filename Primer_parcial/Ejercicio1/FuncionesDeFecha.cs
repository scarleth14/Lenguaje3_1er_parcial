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
    public partial class FuncionesDeFecha : Form
    {
        public FuncionesDeFecha()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            DateTime fechaIngresada = FechadateTimePicker.Value;
            
            NumeroDiaTextBox.Text = fechaIngresada.Day.ToString();
            NumeroMesTextBox.Text = fechaIngresada.Month.ToString();
            AnioTextBox.Text = fechaIngresada.Year.ToString();
            HoraTextBox.Text = fechaIngresada.Hour.ToString();

            MesTextBox.Text = fechaIngresada.ToString("MMMM");

            int numeroDias = Convert.ToInt32(AgregarDiasTextBox.Text);
            int numeroDiasARestar = Convert.ToInt32(RestarDiasTextBox.Text);

            NuevaFechaConDiasTextBox.Text = fechaIngresada.AddDays(numeroDias).ToShortDateString();
            NuevaFechaRestadaTextBox.Text = fechaIngresada.AddDays(-numeroDiasARestar).ToShortDateString();

            EdadTextBox.Text = DevolverEdad(fechaIngresada).ToString();

        }

        private int DevolverEdad(DateTime fechaNacimiento)
        {
            DateTime _fechaNacimiento = fechaNacimiento;
            DateTime _fechaActual = DateTime.Now;

            int edad; 
            if (_fechaNacimiento.Day >= _fechaActual.Day)
            {
                return 0;
            }
            {
                edad = (_fechaActual.Year - _fechaNacimiento.Year);
                if(_fechaNacimiento.Month > _fechaActual.Month)
                {
                    --edad;
                }
                return edad;
   
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void FuncionesDeFecha_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
