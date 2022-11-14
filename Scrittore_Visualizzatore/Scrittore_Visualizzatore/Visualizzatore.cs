using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrittore_Visualizzatore
{
    public class Visualizzatore
    {
        private bool _grassetto;
        private bool _corsivo;
        private bool _sottolineato;
        private ConsoleColor _color;
        RichTextBox _RichTextBox;

        public bool Grassetto
        {
            set
            {
                _grassetto = value; 
            }
            get
            {
                return _grassetto;
            }
        }
        public bool Sottolineato
        {
            set
            {
                _sottolineato = value;
            }
            get 
            { 
                return _sottolineato; 
            }
        }
        public bool Corsivo
        {
            set 
            {
                _corsivo = value;
            }
            get
            {
                return _corsivo;
            }
        }
        public ConsoleColor Color
        {
            set
            {
                _color = value;
            }
            get
            {
                return _color;
            }
        }


        public void visualizza()
        {
            
        }



    }
}
