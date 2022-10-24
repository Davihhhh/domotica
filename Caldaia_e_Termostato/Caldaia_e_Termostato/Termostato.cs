using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caldaia_e_Termostato
{
    public class Termostato
    {
        private string _produttore;
        public string Produttore
        {
            get{
                 return _produttore;
            }
            set{
                _produttore = value;
            }
        }      
                
        private string _modello;
        public string Modello
        {
            get{
                 return _modello;
            }
            set{
                _modello = value;
            }
        }

        private string _dataInstallazione;
        public string Data_Installazione
        {
            get{
                 return _dataInstallazione;
            }
            set{
                _dataInstallazione = value;
            }
        }

        private int _numeroSerie;
        public int Numero_Serie
        {
            get{
                 return _numeroSerie;
            }
            set{
                _numeroSerie = value;
            }
        }


        private int _temperaturaMaxCaldaia;
        public int TemperturaMaxCaldaia
        {
            get{
                 return _temperaturaMaxCaldaia;
            }
            set{
                _temperaturaMaxCaldaia = value;
            }
        }

        private int _temperaturaMinCaldaia;
        public int TemperturaMinCaldaia
        {
            get{
                 return _temperaturaMinCaldaia;
            }
            set{
                _temperaturaMinCaldaia = value;
            }            
        }

        private int _temperaturaAttualeCaldaia;
        public int TemperaturaAttualeCaldaia
        {
            get{
                 return _temperaturaAttualeCaldaia;
            }
            set{
                _temperaturaAttualeCaldaia = value;
            }   
   
        }


        private int _temperaturaMaxAcqua;
        public int TemperturaMaxAcqua
        {
            get{
                 return _temperaturaMaxAcqua;
            }
            set{
                _temperaturaMaxAcqua = value;
            }   
             
        }

        private int _temperaturaMinAcqua;
        public int TemperturaMinAcqua
        {
            get{
                 return _temperaturaMinAcqua;
            }
            set{
                _temperaturaMinAcqua = value;
            }  
        }

        private int _temperaturaAttualeAcqua;
        public int TemperaturaAttualeAcqua
        {
            get{
                 return _temperaturaAttualeAcqua;
            }
            set{
                _temperaturaAttualeAcqua = value;
            }  
        }

        
        private bool _stato;
        public bool Stato
        {
            get { 
            return _stato;
            }
            set
            {
                if (value)
                    _stato = false;
                else
                    _stato = true;             
            }
        }

        private bool _riscaldamento;
        public bool Riscaldamento
        {
            get { 
            return _riscaldamento;
            }
            set
            {
                if (value)
                    _riscaldamento = false;
                else
                    _riscaldamento = true;  
            }
        }

        private int checker = -10;

        public Termostato()
        {
            _stato = false;
            setDataNull();
            setValueNull();
        }
        public Termostato(string produttore, string modello, string data, int numero)
        {
            _stato = false;
            setValueNull();
            _produttore = produttore;
            _modello = modello;
            _dataInstallazione = data;
            _numeroSerie = numero;
        }
        public Termostato(string produttore, string modello, string data, int numero, int tempAttAcq, int tempMaxAcq, int tempMinAcq, int tempAttCal, int tempMaxCal, int tempMinCal)
        {
            _stato = false;            
            _produttore = produttore;
            _modello = modello;
            _dataInstallazione = data;
            _numeroSerie = numero;

            _temperaturaAttualeAcqua = tempAttAcq;
            _temperaturaMaxAcqua = tempMaxAcq;
            _temperaturaMinAcqua = tempMinAcq;

            _temperaturaAttualeCaldaia = tempAttCal;
            _temperaturaMaxCaldaia = tempMaxCal;
            _temperaturaMinCaldaia = tempMinCal;
        }

        private void setDataNull()
        {
            _produttore = null;
            _modello = null;
            _dataInstallazione = null;   
            _numeroSerie = checker;
        }
        private void setValueNull()
        {
            _temperaturaAttualeAcqua = checker;
            _temperaturaMaxAcqua = checker;
            _temperaturaMinAcqua = checker;

            _temperaturaAttualeCaldaia = checker;
            _temperaturaMaxCaldaia = checker;
            _temperaturaMinCaldaia = checker;
        }
    }
}
