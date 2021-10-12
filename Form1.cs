using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mult
{
    public partial class FrmMenuPrincipal : Form
    {
        public int numero;
        public FrmMenuPrincipal()
        
        {
            InitializeComponent();
        }

        private RadioButton[] Buttoncito;

        private void btnIr_Click(object sender, EventArgs e)
        {
            int vare = 13;
            int cont = 0;
            foreach (RadioButton item in Buttoncito)
            {
                if (item != null)
                {
                    if (item.Checked)
                    {
                        vare = cont;
                    }
                    cont++;
                }

            }
            if (vare <= 12)
            {
                wMult ventan2 = new wMult(vare);
                ventan2.Show();
            }
            else
            { 
                MessageBox.Show("Elija el valor");
            }
        }
        //Evento se crea en propiedades - eventos

        private void wMulti(object sender, EventArgs e)
        {
            int posY = 0;
            Buttoncito = new RadioButton[12];
            for (int i = 0; i < 12; i++)
            {
                RadioButton Nradio = new RadioButton();
                posY += 30; //es = tener posY = PosY + 30
                Nradio.Location = new Point(100, posY);
                Nradio.Text = i.ToString();
                this.Controls.Add(Nradio);
                Buttoncito[i] = Nradio;
            }
        }
    }
}
     
