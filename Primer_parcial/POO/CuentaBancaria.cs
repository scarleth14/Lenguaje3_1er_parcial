using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class CuentaBancaria : Form
    {
        public CuentaBancaria()
        {
            InitializeComponent();
        }


        Cliente cliente;
        Cuenta cuenta;
        MovimientosCuenta movimientosCuenta;
        List<MovimientosCuenta> ListaMovimientosCuenta;


        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            // 1. Crear el Cliente
            cliente = new Cliente(IdentidadTextBox.Text, NombreTextBox.Text);

            // 2. Crear la cuenta
            cuenta = new Cuenta(NumeroCuentaTextBox.Text, cliente, DateTime.Now);

            SaldoTextBox.Text = cuenta.Saldo.ToString("N");

        }

        private void AgregarMovimientoButton_Click(object sender, EventArgs e)
        {
            if (MontoTextBox.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el monto del movimiento");
                MontoTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(TipoMovimientoComboBox.Text))
            {
                MessageBox.Show("Seleccione el tipo de movimiento");
                return;
            }

            if (TipoMovimientoComboBox.Text == "Depósito")
            {
                cuenta.Depositar(Convert.ToDecimal(MontoTextBox.Text));

                movimientosCuenta = new MovimientosCuenta(cuenta, DateTime.Now, 
                                                        Convert.ToDecimal(MontoTextBox.Text), 
                                                        TipoMovimientoComboBox.Text);

                ListaMovimientosCuenta = new List<MovimientosCuenta>();
                ListaMovimientosCuenta.Add(movimientosCuenta);

                MovimientosListBox.Items.Add("Déposito a la cuenta N." + cuenta.NumeroCuenta + " por la cantidad de L. " +
                                            Convert.ToDecimal(MontoTextBox.Text) + " con fecha: " +
                                            movimientosCuenta.FechaMovimiento.ToShortDateString());

                SaldoTextBox.Text = cuenta.Saldo.ToString("N");

            }
            else if (TipoMovimientoComboBox.Text == "Retiro")
            {
                
                bool pudoRetirar = cuenta.Retirar(Convert.ToDecimal(MontoTextBox.Text));
                if (pudoRetirar)
                {
                    movimientosCuenta = new MovimientosCuenta(cuenta, DateTime.Now,
                                                        Convert.ToDecimal(MontoTextBox.Text),
                                                        TipoMovimientoComboBox.Text);

                    ListaMovimientosCuenta = new List<MovimientosCuenta>();
                    ListaMovimientosCuenta.Add(movimientosCuenta);

                    MovimientosListBox.Items.Add("Retiro a la cuenta N." + cuenta.NumeroCuenta + " por la cantidad de L. " +
                                                Convert.ToDecimal(MontoTextBox.Text) + " con fecha: " +
                                                movimientosCuenta.FechaMovimiento.ToShortDateString());

                    SaldoTextBox.Text = cuenta.Saldo.ToString("N");
                }
                else
                {
                    MessageBox.Show("No tiene saldo suficiente para realizar la transacción");
                }

            }

            MontoTextBox.Clear();
        }


    }
}
