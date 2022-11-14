using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrittore_Visualizzatore
{
    public partial class RichTextBox : Form
    {
        public RichTextBox()
        {
            InitializeComponent();
        }

        private Visualizzatore _visualizzatore;
        private Scrittore _scrittore;

        private string _utente

        private void RichTextBox_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInvio_Click(object sender, EventArgs e)
        {
            
            _scrittore = new Scrittore()
        }
    }
}
