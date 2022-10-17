using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telecomando
{   
    public class Telecomando
    {
        private string Produttore;
        private string Modello;
        private string[] Funzionamento;

        public Televisore TV;

        public Telecomando (Televisore TV)
        {
            SetTV(TV);
        }
        public void SetTV(Televisore TV)
        {
            TV.SetStato(false);

            TV.SetDefaultData();

            TV.SetDefaultRangeVolume();
            TV.SetDefaultVolume();

            TV.SetDefaultRangeCanale();
            TV.SetDefaultCanale();
        }
        public Televisore GetTV()
        {
            return TV;
        }
        public Telecomando()
        {
            TV.SetStato(false);

            SetDefaultData();

            TV.SetDefaultRangeVolume();
            TV.SetDefaultVolume();

            TV.SetDefaultRangeCanale();
            TV.SetDefaultCanale();
        }

        public Telecomando(string produttore, string modello, string[] funzionamento)
        {
            TV.SetStato(false);

            TV.SetData(produttore, modello, funzionamento);
            SetDefaultDataTelecomando();

            TV.SetDefaultRangeVolume();
            TV.SetDefaultVolume();

            TV.SetDefaultRangeCanale();
            TV.SetDefaultCanale();
        }
        public Telecomando(string modello)
        {
            TV.SetModello(modello);
        }
        public Telecomando(string[] funzionamento)
        {
            TV.SetFunzionamento(funzionamento);
        }
        public Telecomando(int volume, int canale)
        {
            TV.SetStato(false);

            SetDefaultData();

            TV.SetDefaultRangeVolume();
            SetVolume(volume);

            TV.SetDefaultRangeCanale();
            SetCanale(canale);
        }
        public Telecomando(int volume, int volmin, int volmax, int canale, int canmin, int canmax)
        {
            TV.SetStato(false);

            SetDefaultData();

            SetRangeVolume(volmin, volmax);
            SetVolume(volume);

            SetRangeCanale(canmin, canmax);
            SetCanale(canale);
        }
        public Telecomando(int volume, int volmin, int volmax, int canale, int canmin, int canmax, string produttore, string modello, string[] funzionamento )
        {
            TV.SetStato(false);

            TV.SetData(produttore, modello, funzionamento);
            SetDefaultDataTelecomando();

            SetRangeVolume(volmin, volmax);
            SetVolume(volume);

            SetRangeCanale(canmin, canmax);
            SetCanale(canale);
        }
        public Telecomando(int volume, int volmin, int volmax, int canale, int canmin, int canmax, string produttoretelecomando, string modellotelecomando, string[] funzionamentotelecomando, string produttore, string modello, string[] funzionamento)
        {
            TV.SetStato(false);

            TV.SetData(produttore, modello, funzionamento);
            SetDataTelecomando(produttoretelecomando, modellotelecomando, funzionamentotelecomando);

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
            return TV.GetStato();
        }
        public int GetVolume()
        {
            return TV.GetVolume();
        }
        public int GetCanale()
        {
            return TV.GetCanale();
        }


        public void AumentaCanale()
        {
            TV.SetCanale(TV.GetCanale() + 1);

            bool check = CheckCanale(TV.GetCanale());
            if (check)
            {
                TV.SetCanale(TV.GetCanale() - 1);
            }
        }
        public void DiminuisciCanale()
        {
            TV.SetCanale(TV.GetCanale() - 1);

            bool check = CheckCanale(TV.GetCanale());
            if (check)
            {
                TV.SetCanale(TV.GetCanale() + 1);
            }
        }
        public void AumentaVolume()
        {
            TV.SetVolume(TV.GetVolume()+1);

            bool check = CheckVolume(TV.GetVolume());
            if(check)
            {
                TV.SetVolume(TV.GetVolume() - 1);
            }
        }
        public void DiminuisciVolume()
        {
            TV.SetVolume(TV.GetVolume() - 1);

            bool check = CheckVolume(TV.GetVolume());
            if (check)
            {
                TV.SetVolume(TV.GetVolume() + 1);
            }
        }


        public void InvertiStatoTelevisore()
        {
            if (TV.GetStato())
                SpegniTelevisore();
            else
                AccendiTelevisore();
        }
        public void AccendiTelevisore()
        {
            TV.SetStato(true);
        }
        public void SpegniTelevisore()
        {
            TV.SetStato(false);
        }


       
        private void SetDefaultDataTelecomando()
        {
            Produttore = "Unknown";
            Modello = "Unknown";
            Funzionamento = new string[] { "Unknown" };
        }
        private void SetDefaultData()
        {
            TV.SetDefaultData();
            SetDefaultDataTelecomando();
        }        
        public void SetDataTelecomando(string produttore, string modello, string[] funzionamento)
        {
            Produttore = produttore;
            Modello = modello;
            Funzionamento = funzionamento;
        }    


        public void SetCanale(int can)
        {
            bool check = CheckCanale(can);
            if (check)
            { }
            else
                TV.SetCanale(can);
        }
        public void SetVolume(int vol)
        {
            bool check = CheckVolume(vol);
            if (check)
            { }
            else
                TV.SetVolume(vol);
        }


        public void SetRangeCanale(int canmin, int canmax)
        {
            TV.SetCanaleMin(canmin);
            TV.SetCanaleMax(canmax);
        }
        public void SetRangeVolume(int volmin, int volmax)
        {
            TV.SetVolumeMin(volmin);
            TV.SetVolumeMax(volmax);
        }



        private bool CheckVolume(int volume)
        {
            bool checker = false;
            if (volume < TV.GetVolumeMin())
            {
                checker = true;
            }
            if (volume > TV.GetVolumeMax())
            {
                checker = true;
            }
            return checker;
        }
        private bool CheckCanale(int canale)
        {
            bool checker = false;
            if (canale < TV.GetCanaleMin())
            {
                checker = true;
            }
            if (canale > TV.GetCanaleMax())
            {
                checker = true;
            }
            return checker;
        }
    }
}
