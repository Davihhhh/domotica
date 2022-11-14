using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrittore_Visualizzatore
{
    public class Scrittore
    {
        private string _utente;
        private Visualizzatore _visualizzatore;

        public Scrittore(string utente)
        {
            Utente = utente;
        }

        public string Utente
        {
            set
            {
                _utente = value;
            }
            get
            {
                return _utente;
            }
        }

        public void setGrassetto(bool g)
        {
            _visualizzatore.Grassetto = g;
        }
        public void setCorsivo(bool c)
        {
            _visualizzatore.Corsivo = c;
        }
        public void setSottolineato(bool s)
        {
            _visualizzatore.Sottolineato = s;
        }
        public void setColor(ConsoleColor c)
        {
            _visualizzatore.Color = c;
        }
        
    }
}
