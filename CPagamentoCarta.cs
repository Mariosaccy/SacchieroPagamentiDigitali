using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroPagamentiDigitali
{
    public class CPagamentoCarta : CPagamentoBase, Iautenticazione
    {
        // Pagamento con carta → dati: numero carta, data di scadenza, PIN; richiede autenticazione.
        public int numeroCarta {get; private set; }
        public DateTime dataScadenza;
        public int pin { get; private set; }

        public CPagamentoCarta(int numeroCarta, DateTime dataScadenza, int pin, double saldo) : base(saldo)
        {
            this.numeroCarta = numeroCarta;
            this.dataScadenza = dataScadenza;
            this.pin = pin;
        }

        public bool autenticazione()
        {
            Fautentificazione finestra = new Fautentificazione(this);
            if (finestra.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string StampaRicevuta()
        {

            return $"Pagamento con carta numero {numeroCarta} effettuato. Saldo rimanente: {Saldo}";
        }
    }
}
