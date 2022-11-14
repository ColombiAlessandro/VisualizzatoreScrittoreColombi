using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizzatoreScrittoreColombi
{
    public class Scrittore
    {
        private Visualizzatore visualizzatore;
        private string utente;
        public Scrittore (string utente, Visualizzatore visualizzatore)
        {
            this.utente = utente;
            this.visualizzatore = visualizzatore;
        }
        public void setGrassetto(bool g)
        {
            visualizzatore.Grassetto = g;
        }
        public void setSottolineato(bool s)
        {
            visualizzatore.Sottolineato = s;
        }
        public void setCorsivo(bool c)
        {
            visualizzatore.Corsivo = c;
        }
        public void setColore(Color c)
        {
            visualizzatore.Colore = c;
        }
        public void aggiungiTesto(string testo)
        {
            visualizzatore.Testo = testo;
        }
    }
}
