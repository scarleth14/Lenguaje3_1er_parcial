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
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void OrdenarButton_Click(object sender, EventArgs e)
        {
            int[] valores = new int[] { 3, 6, 9, 2, 1, 8, 7 };
            //Ordenar de menor a mayor
            Array.Sort(valores);

            //Ordenar de mayor a menor
            Array.Reverse(valores);

            foreach (var item in valores)
            {
                listBox2.Items.Add(item);
            }


        }
    }
}
