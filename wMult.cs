using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mult
{
    public partial class wMult : Form
    {
        public int numeroRecibido;
        int cont;
        int vlrOpera;
        private Label[] etiquetas;

        public wMult(int valor)
        {
            InitializeComponent();
            this.numeroRecibido = valor;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int posY = 10;
            string titulo;
            etiquetas = new Label[12];
            for (int i = 0; i < 11; i++)
            {
                Label Nradio = new Label();
                posY += 30;
            Nradio.Location = new Point(10, posY);
                titulo = Nradio.Name;
                cont++;
                vlrOpera = numeroRecibido * cont;
                Nradio.Text = numeroRecibido.ToString() + " x " + cont + " = " +
               vlrOpera.ToString();
                this.Controls.Add(Nradio);
                etiquetas[i] = Nradio;
            }

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
   
