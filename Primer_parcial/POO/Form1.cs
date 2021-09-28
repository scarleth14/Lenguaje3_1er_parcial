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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Usuario usuario = new Usuario("SBAQUEDANO", "abigailb643@gmail.com");

            Usuario usuario = new Usuario();
            usuario.Codigo = "SBAQUEDANO";
            usuario.Correo = "abigailb643@gmail.com";
            usuario.Nombre = "SCARLETH";
            usuario.Apellidos = "BAQUEDANO";

            MessageBox.Show(usuario.GetNombreCompleto(usuario.Nombre, usuario.Apellidos));

        }
    }
}
