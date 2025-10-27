using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroPagamentiDigitali
{
    public class CPagamentoPayPal : CPagamentoBase, Iautenticazione
    {
        // Pagamento con PayPal → dati: email account, saldo disponibile; richiede autenticazione.
        public string emailAccount { get; private set; }
        public string password { get; private set; }

        public CPagamentoPayPal(string emailAccount, string password, double saldo) : base(saldo)
        {
            this.emailAccount = emailAccount;
            this.password = password;
        }

        // implementazione del metodo di autenticazione
        public bool autenticazione()
        {
            Fautentificazione finestra = new Fautentificazione(this);
            if(finestra.ShowDialog() == DialogResult.OK)
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
            return $"Pagamento con PayPal dall'account {emailAccount} effettuato. Saldo rimanente: {Saldo}";
        }

    }
}
