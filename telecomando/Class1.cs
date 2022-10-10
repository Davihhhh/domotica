using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telecomando
{
    internal class Telecomando
    {
        private string Produttore;
        private string Modello;
        private string[] Funzionamento;


        private bool Stato;


        private int CanaleAttuale;
        private int CanaleMax;
        private int CanaleMin;


        private int VolumeAttuale;
        private int VolumeMin;
        private int VolumeMax;

        public Telecomando()
        {
            Stato = false;

            SetDefaultData();

            SetDefaultRangeVolume();
            SetDefaultVolume();

            SetDefaultRangeCanale();
            SetDefaultCanale();
        }
        public Telecomando(string produttore, string modello, string[] funzionamento)
        {
            Stato = false;

            SetData(produttore, modello, funzionamento);

            SetDefaultRangeVolume();
            SetDefaultVolume();

            SetDefaultRangeCanale();
            SetDefaultCanale();
        }
        public Telecomando(int volume, int canale)
        {
            Stato = false;

            SetDefaultData();

            SetDefaultRangeVolume();
            SetVolume(volume);

            SetDefaultRangeCanale();
            SetCanale(canale);
        }
        public Telecomando(int volume, int volmin, int volmax, int canale, int canmin, int canmax)
        {
            Stato = false;

            SetDefaultData();

            SetRangeVolume(volmin, volmax);
            SetVolume(volume);

            SetRangeCanale(canmin, canmax);
            SetCanale(canale);
        }
        public Telecomando(int volume, int volmin, int volmax, int canale, int canmin, int canmax, string produttore, string modello, string[] funzionamento )
        {
            Stato = false;

            SetData(produttore, modello, funzionamento);

            SetRangeVolume(volmin, volmax);
            SetVolume(volume);

            SetRangeCanale(canmin, canmax);
            SetCanale(canale);
        }

        public string GetProduttore()
        {
            return Produttore;
        }
        public string GetModello()
        {
            return Modello;
        }
        public string[] GetFunzionamento()
        {
            return Funzionamento;
        }
        public bool GetStato()
        {
            return Stato;
        }
        public int GetVolume()
        {
            return VolumeAttuale;
        }
        public int GetCanale()
        {
            return CanaleAttuale;
        }


        public void AumentaCanale()
        {
            CanaleAttuale++;

            bool check = CheckCanale(CanaleAttuale);
            if (check)
            {
                CanaleAttuale = CanaleMin;
            }
        }
        public void DiminuisciCanale()
        {
            CanaleAttuale--;
           
            bool check = CheckCanale(CanaleAttuale);
            if (check)
            {
                CanaleAttuale = CanaleMax;
            }
        }
        public void AumentaVolume()
        {
            VolumeAttuale++;

            bool check = CheckVolume(VolumeAttuale);
            if(check)
            {
                VolumeAttuale--;
            }
        }
        public void DiminuisciVolume()
        {
            VolumeAttuale--;
            bool check = CheckVolume(VolumeAttuale);
            if (check)
            {
                VolumeAttuale++;
            }
        }

        public void InvertiStatoTelevisione()
        {
            if (Stato)
                SpegniTelevisione();
            else
                AccendiTelevisione();
        }
        public void AccendiTelevisione()
        {
            Stato = true;
        }
        public void SpegniTelevisione()
        {
            Stato = false;
        }


        private void SetDefaultData()
        {
            Produttore = "Unknown";
            Modello = "Unknown";
            Funzionamento = new string[] { "Unknown"};
        }
        private void SetData(string produttore, string modello, string[] funzionamento)
        {
            Produttore = produttore;
            Modello = modello;
            Funzionamento = funzionamento;
        }

        
        private void SetDefaultRangeVolume()
        {
            VolumeMin = 0;
            VolumeMax = 100;
        }
        private void SetRangeVolume(int volmin, int volmax)
        {
            VolumeMax = volmax;
            VolumeMin = volmin;
        }

        private void SetDefaultVolume()
        {
            VolumeAttuale = 20;
        }
        public void SetVolume(int vol)
        {
            bool check = CheckVolume(vol);
            if (check)
            { }
            else
                VolumeAttuale = vol;
        }


        private void SetDefaultCanale()
        {
            CanaleAttuale = 1;
        }
        public void SetCanale(int can)
        {
            bool check = CheckCanale(can);
            if (check)
            { }
            else
                CanaleAttuale = can;
        }

        private void SetDefaultRangeCanale()
        {
            CanaleMin = 1;
            CanaleMax = 999;
        }
        private void SetRangeCanale(int canmin, int canmax)
        {
            CanaleMin = canmin;
            CanaleMax = canmax;
        }


        private bool CheckVolume(int volume)
        {
            bool checker = false;
            if (volume < VolumeMin)
            {
                checker = true;
            }
            if (volume > VolumeMax)
            {
                checker = true;
            }
            return checker;
        }
        private bool CheckCanale(int canale)
        {
            bool checker = false;
            if (canale < CanaleMin)
            {
                checker = true;
            }
            if (canale > CanaleMax)
            {
                checker = true;
            }
            return checker;
        }

    }
}
