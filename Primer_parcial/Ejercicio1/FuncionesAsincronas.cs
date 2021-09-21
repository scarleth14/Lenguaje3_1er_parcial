using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FuncionesAsincronas : Form
    {
        public FuncionesAsincronas()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = "Proceso iniciado";
            HornearPizzaAsync();
            ResultadoLabel.Text = "Terminó el proceso";
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);

        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private async void SumarButton_Click(object sender, EventArgs e)
        {
            ResultadoSumaLabel.Text = Convert.ToString(await SumarDosValoresAsync(25M, 50M));
        }
        

        private async Task<decimal> SumarDosValoresAsync(decimal num1, decimal num2)
        {
            decimal resultado = await Task.Run(() => 
           {
                return num1 + num2;
            });

            return resultado;
        }
    }
}
