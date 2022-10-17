using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telecomando
{
    public class Televisore
    {
        private string Produttore;
        private string Modello;
        private string[] Funzionamento;


        private int CanaleAttuale;
        private int CanaleMax;
        private int CanaleMin;


        private int VolumeAttuale;
        private int VolumeMin;
        private int VolumeMax;

        private bool Stato;

        private string[] Unknown = {"Unknown"};
        public Televisore()
        {
            SetStato(false);

            SetDefaultData();

            SetDefaultRangeVolume();
            SetDefaultVolume();

            SetDefaultRangeCanale();
            SetDefaultCanale();
        }

        public Televisore(string produttore, string modello, string[] funzionamento)
        {
            SetStato(false);

            SetData(produttore, modello, funzionamento);
            
            SetDefaultRangeVolume();
            SetDefaultVolume();

            SetDefaultRangeCanale();
            SetDefaultCanale();
        }
        public Televisore(string modello)
        {
            SetStato(false);

            SetModello(modello);
            SetProduttore("Unknown");
            SetFunzionamento(Unknown);

            SetDefaultRangeVolume();
            SetDefaultVolume();

            SetDefaultRangeCanale();
            SetDefaultCanale();
            
        }
        public Televisore(string[] funzionamento)
        {
            SetStato(false);

            SetModello("Unknown");
            SetProduttore("Unknown");
            SetFunzionamento(funzionamento);

            SetDefaultRangeVolume();
            SetDefaultVolume();

            SetDefaultRangeCanale();
            SetDefaultCanale();
            
        }
        public Televisore(int volume, int canale)
        {
            SetStato(false);

            SetDefaultData();

            SetDefaultRangeVolume();
            SetVolume(volume);

            SetDefaultRangeCanale();
            SetCanale(canale);
        }
        public Televisore(int volume, int volmin, int volmax, int canale, int canmin, int canmax)
        {
            SetStato(false);

            SetDefaultData();

            SetRangeVolume(volmin, volmax);
            SetVolume(volume);

            SetRangeCanale(canmin, canmax);
            SetCanale(canale);
        }
        public Televisore(int volume, int volmin, int volmax, int canale, int canmin, int canmax, string produttore, string modello, string[] funzionamento)
        {
            SetStato(false);

            SetData(produttore, modello, funzionamento);
            

            SetRangeVolume(volmin, volmax);
            SetVolume(volume);

            SetRangeCanale(canmin, canmax);
            SetCanale(canale);
        }
        public Televisore(int volume, int volmin, int volmax, int canale, int canmin, int canmax, string produttoretelecomando, string modellotelecomando, string[] funzionamentotelecomando, string produttore, string modello, string[] funzionamento)
        {
            SetStato(false);

            SetData(produttore, modello, funzionamento);
            

            SetRangeVolume(volmin, volmax);
            SetVolume(volume);

            SetRangeCanale(canmin, canmax);
            SetCanale(canale);
        }
        public Televisore(string produttore, string modello, string[] funzionamento, int canaleAttuale, int canaleMax, int canaleMin, int volumeAttuale, int volumeMin, int volumeMax, bool stato)
        {
            Produttore = produttore;
            Modello = modello;
            Funzionamento = funzionamento;
            CanaleAttuale = canaleAttuale;
            CanaleMax = canaleMax;
            CanaleMin = canaleMin;
            VolumeAttuale = volumeAttuale;
            VolumeMin = volumeMin;
            VolumeMax = volumeMax;
            Stato = stato;
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
        public int GetVolumeMin()
        {
            return VolumeMin;
        }
        public int GetVolumeMax ()
        {
            return VolumeMax;
        }
        public int GetCanale()
        {
            return CanaleAttuale;
        }
        public int GetCanaleMin()
        {
            return CanaleMin;
        }
        public int GetCanaleMax ()
        {
            return CanaleMax;
        }

        public void SetModello(string modello)
        {
            Modello = modello;
        }
        public void SetProduttore(string produttore)
        {
            Produttore = produttore;
        }
        public void SetFunzionamento(string[] funzionamento)
        {
            Funzionamento = funzionamento;
        }

        public void SetData(string produttore, string modello, string[] funzionamento)
        {
            SetProduttore(produttore);
            SetModello(modello);
            SetFunzionamento(funzionamento);
        }
        public void SetDefaultData()
        {
            Produttore = "Unknown";
            Modello = "Unknown";
            Funzionamento = new string[] { "Unknown" };
        }

        public void SetStato(bool stato)
        {
            Stato = stato;
        }

        public void SetVolume(int volume)
        {
            VolumeAttuale = volume;
        }
        public void SetVolumeMin(int volume)
        {
            VolumeMin = volume;
        }
        public void SetVolumeMax (int volume)
        {
            VolumeMax = volume;
        }
        public void SetDefaultRangeVolume()
        {
            SetVolumeMin(0);
            SetVolumeMax(100);
        }
        public void SetDefaultVolume()
        {
            SetVolume(20);
        }
        private void SetRangeVolume(int volmin, int volmax)
        {
            SetVolumeMin(volmin);
            SetVolumeMax(volmax);
        }



        public void SetCanale(int canale)
        {
            CanaleAttuale = canale;
        }
        public void SetCanaleMin(int canale)
        {
            CanaleMin = canale;
        }
        public void SetCanaleMax(int canale)
        {
            CanaleMax = canale;
        }
        public void SetDefaultRangeCanale()
        {
            SetCanaleMin(1);
            SetCanaleMax(999);
        }       
        public void SetDefaultCanale()
        {
            SetCanale(1);
        }
        public void SetRangeCanale(int canmin, int canmax)
        {
            SetCanaleMin(canmin);
            SetCanaleMax(canmax);
        }
        

    }
}
