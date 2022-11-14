using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizzatoreScrittoreColombi
{
    public class Visualizzatore
    {
        private Color _colore;
        private bool _sottolineato;
        private bool _corsivo;
        private bool _grassetto;
        private RichTextBox textBox;
        private string _testo;
        public string Testo
        {
            set
            {
                _testo = value;
            }
            get
            {
                return _testo;
            }
        }
        public Color Colore
        {
            set
            {
                _colore = value;
            }
            get
            {
                return _colore;
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
        public void Visualizza()
        {
            textBox.Text = _testo;
            if (Grassetto)
            {
                textBox.SelectionFont = new Font(textBox.Font, FontStyle.Bold);
            }
            if (Sottolineato)
            {
                textBox.SelectionFont = new Font(textBox.Font, FontStyle.Underline);
            }
            if (Corsivo)
            {
                textBox.SelectionFont = new Font(textBox.Font, FontStyle.Italic);
            }
            if (Colore != null)
            {
                textBox.SelectionColor = Colore;
            }
        }
    }
}
