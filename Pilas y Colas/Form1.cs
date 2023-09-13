using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_y_Colas
{
    public partial class Form1 : Form
    {
        Pila obj = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtMaximo.Text);
            obj = new Pila(m);
            MessageBox.Show("Pila Creada");
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            obj.push(int.Parse(txtValor.Text));
            MessageBox.Show("Valor Agregado");
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnPOP_Click(object sender, EventArgs e)
        {
            int n = obj.pop();
            MessageBox.Show("Salio el valor:" + n);

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            Pila x = new Pila();
            x = obj;
            int i;
            if (x.Pila_vacia() == false)
            {
                for (i = x.cima; i >= 0; i--)
                {
                    Lista.Items.Add(x.lapila[i]);
                }
            }
            else
                MessageBox.Show("No hay nada que mostrar");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


