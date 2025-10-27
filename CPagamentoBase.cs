using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SacchieroPagamentiDigitali
{
    public abstract class CPagamentoBase
    {
        // questa è la classe astratta di base per le altre classi
        // Pagamento con carta → dati: numero carta, data di scadenza, PIN; richiede autenticazione
        // Pagamento con PayPal → dati: email account, saldo disponibile; richiede autenticazione
        // Pagamento in criptovaluta → dati: identificativo wallet, saldo cripto; non richiede autenticazione

        // quindi deve esserci il saldo
        public double Saldo { get; protected set; }

        public CPagamentoBase (double saldo)
        {
            Saldo = saldo;
        }

        // metodo per verificare la disponibilità
        public bool VerificaDisponibilita(double importo)
        {
            if(Saldo < importo)
            {
                return false;
            }
            return true;
        }

        // metodo per scalare i soldi (quindi pagare)
        public void Paga(double importo)
        {
            if(VerificaDisponibilita(importo))
            {
                Saldo -= importo;

                Cstatistiche.TotaleTransazioni += 1;
                Cstatistiche.TotaleIncassato += importo;
            }
        }

        // metodo di stampa ricevuta
        public abstract string StampaRicevuta();
    }
}
