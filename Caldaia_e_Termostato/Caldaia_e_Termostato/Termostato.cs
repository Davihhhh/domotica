using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caldaia_e_Termostato
{
    public class Termostato
    {
        string produttore;
        string modello;
        string dataInstallazione;
        int numeroSerie;

        bool acceso;
        bool riscaldamento;

        int temperaturaMaxCaldaia;
        int temperaturaMinCaldaia;
        int temperaturaAttualeCaldaia;

        int temperaturaMaxAcqua;
        int temperaturaMinAcqua;
        int temperaturaAttualeAcqua;
                

        public string getProduttore()
        {
            return produttore;
        }
        public string getModello()
        {
            return modello;
        }
        public string getData_Installazione()
        {
            return dataInstallazione;
        }
        public int getNumero_Serie()
        {
            return numeroSerie;
        }


        public int getTemperturaMaxCaldaia()
        {
            return temperaturaMaxCaldaia;
        }
        public int getTemperturaMinCaldaia()
        {
            return temperaturaMinCaldaia;
        }
        public int getTemperaturaAttualeCaldaia()
        {
            return temperaturaAttualeCaldaia;
        }


        public int getTemperturaMaxAcqua()
        {
            return temperaturaMaxAcqua;
        }
        public int getTemperturaMinAcqua()
        {
            return temperaturaMinAcqua;
        }
        public int getTemperaturaAttualeAcqua()
        {
            return temperaturaAttualeAcqua;
        }


        public void setProduttore(string prod)
        {
            produttore = produ;
        }
        public void setModello(string mod)
        {
            modello = mod;
        }
        public void setData_Installazione(string data)
        {
            dataInstallazione = data;
        }
        public void setNumero_Serie(int num)
        {
            numeroSerie = num;
        }


        public void setTemperturaMaxCaldaia(int temp)
        {
            temperaturaMaxCaldaia = temp;
        }
        public void setTemperturaMinCaldaia(int temp)
        {
            temperaturaMinCaldaia = temp;
        }
        public void setTemperaturaAttualeCaldaia(int temp)
        {
            temperaturaAttualeCaldaia = temp;
        }


        public void setTemperturaMaxAcqua(int temp)
        {
            temperaturaMaxAcqua = temp;
        }
        public void setTemperturaMinAcqua(int temp)
        {
            temperaturaMinAcqua = temp;
        }
        public void setTemperaturaAttualeAcqua(int temp)
        {
            temperaturaAttualeAcqua = temp;
        }


    }
}
