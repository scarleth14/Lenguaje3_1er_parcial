using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Presentado por: Scarleth Abigail Baquedano Padilla
//Número de cuenta: 20191001765
//Última modificación: 23/9/2021

namespace Evaluación1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            //Variables globales
            double salario, VentasPromedio;
            int edad, AniosAntiguedad;
            DateTime FechaIngresada;


            //Guarda los valores en cada variable
            VentasPromedio = Convert.ToDouble(VentasPromedioTextBox.Text);
            FechaIngresada = FechaNacimientoDateTimePicker.Value;
            edad = CalcularEdad(FechaIngresada);
            AniosAntiguedad = Convert.ToInt32(AniosAntiguedadTextBox.Text);
            salario = Convert.ToDouble(SalarioTextBox.Text);

            //Envía los parametros a la funcion que calcula el aumento de salario
            AumentoSalario(VentasPromedio, edad, AniosAntiguedad, salario);

            //Muestra la edad del empleado en textbox
            EdadTextBox.Text = edad.ToString();
        }

        private int CalcularEdad(DateTime FechaNac)
        {
            int _edad;

            //Guarda la fecha actual
            DateTime FechaAct = DateTime.Now;

            //Si el día de nacimiento es mayor al día actual retorna 0, quiere decir que la persona no ha nacido
            if (FechaNac.Day >= FechaAct.Day)
            {
                return 0;
            }
            //Calcula la edad de la persona y si el mes de nacimiento es mayor al mes actual quiere decir
            //que no ha cumplido años y se le resta uno a la edad.
            {
                _edad = FechaAct.Year - FechaNac.Year;
                if (FechaNac.Month > FechaAct.Month)
                {
                    --_edad;
                }  
            }
            return _edad;
        }

        private double AumentoSalario(double VentasPromedio, int edad, int AniosAntiguedad, double salario)
        {
            //Inicializa la variable salario con 15,000
   
            double NuevoSalario, aumento;

            //Se tienen que cumplir las tres condiciones para que haya un aumento del 5% del salario
            if ((VentasPromedio>10000)&&(edad>=30)&&(AniosAntiguedad>=10))
            {
                aumento = salario * 0.05;
                NuevoSalario = salario + aumento; ;
                SalarioNuevoLabel.Text = "Su nuevo salario es Lps. " + NuevoSalario.ToString("N2");
                AumentoLabel.Text = "El aumento fue de Lps. " + aumento.ToString("N2"); 

            }
            else
            {
                NuevoSalario = 0;
                SalarioNuevoLabel.Text = "No hubo un aumento de salario";
                AumentoLabel.Text = " ";
            }

            return NuevoSalario;
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            FechaNacimientoDateTimePicker.Value = DateTime.Now ;
            VentasPromedioTextBox.Clear();
            AniosAntiguedadTextBox.Clear();
            SalarioTextBox.Clear();
            EdadTextBox.Clear();
            SalarioNuevoLabel.Text = " ";
            AumentoLabel.Text = " ";
        }
    }
}
