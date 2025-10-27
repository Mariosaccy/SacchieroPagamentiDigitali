using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacchieroPagamentiDigitali
{
    public class CApplePay : CPagamentoBase
    {
        // Pagamento con Apple Pay → dati: ID dispositivo, saldo disponibile; NON richiede autenticazione
        public string IDapple { get; private set; }

        public CApplePay(string IDapple, double saldo) : base(saldo)
        {
            this.IDapple = IDapple;
        }
        public override string StampaRicevuta()
        {
            return $"Pagamento con Apple Pay dal dispositivo {IDapple} effettuato. Saldo rimanente: {Saldo}";
        }

    }
}
