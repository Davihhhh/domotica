using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telecomando
{
    public partial class Form1 : Form
    {
        private Televisore tv;
        private Telecomando tel;
        int[] canale = new int[3];
        
        int cont = 0;
        
        public Form1()
        {
            InitializeComponent();

            tv=new Televisore();
            tel=new Telecomando(tv);
                      
            setstatocolor();
            modificatextbox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setstatocolor()
        {
             if (tel.GetStato())
                buttonStato.BackColor = Color.Green;
            else
                buttonStato.BackColor = Color.Red;
        }
        private void modificatextbox()
        {
            if(tel.GetStato())
            {
                textBoxVolumeAttuale.Text = tel.GetVolume().ToString();
                textBoxCanaleAttuale.Text = tel.GetCanale().ToString();
            }
            else
            {
                textBoxVolumeAttuale.Text = "";
                textBoxCanaleAttuale.Text = "";
            }
        }
        private void OnOff_Click(object sender, EventArgs e)
        {
            tel.InvertiStatoTelevisore();   
            modificatextbox();
            setstatocolor();
        }


        private void AlzaVol_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                tel.AumentaVolume();
                modificatextbox();
            }
            else { }
        }
        private void AbbassaVol_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                tel.DiminuisciVolume();
                modificatextbox();
            }
            else { }
        }


        private void AumentaCan_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                tel.AumentaCanale();
                modificatextbox();
            }
            else { }
        }
        private void AbbassaCan_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                tel.DiminuisciCanale();
                modificatextbox();
            }
            else { }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 0;
                cont++;
            }
            else { }
        }
        private void uno_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 1;
                cont++;
            }
            else { }
        }

        private void due_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 2;
                cont++;
            }
            else { }
        }

        private void tre_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 3;
                cont++;
            }
            else { }
        }

        private void quattro_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 4;
                cont++;
            }
            else { }
        }

        private void cinque_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 5;
                cont++;
            }
            else { }
        }

        private void sei_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 6;
                cont++;
            }
            else { }
        }

        private void sette_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 7;
                cont++;
            }
            else { }
        }

        private void otto_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 8;
                cont++;
            }
            else { }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            if (checkacceso())
            {
                canale[cont] = 9;
                cont++;
            }
            else { }
        }

        private void TempoDigitazione_Tick(object sender, EventArgs e)
        {
            textBoxCanale.Text = Convert.ToString(canale);
        }

        private bool checkacceso()
        {
            bool check = tel.GetStato();
            return check;
        }

        private void buttonStato_Click(object sender, EventArgs e)
        {

        }
    }
}
