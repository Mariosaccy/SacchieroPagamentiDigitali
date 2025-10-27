using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacchieroPagamentiDigitali
{
    public class CPagamentoCripto : CPagamentoBase
    {
        // Pagamento in criptovaluta → dati: identificativo wallet, saldo cripto; non richiede autenticazione
        public int identificativoWallet;

        public CPagamentoCripto(int identificativoWallet, double saldo) : base(saldo)
        {
            this.identificativoWallet = identificativoWallet;
        }

        public override string StampaRicevuta()
        {
            return $"Pagamento con Cripto al wallet {identificativoWallet} effettuato. Saldo rimanente: {Saldo}";
        }
    }
}
