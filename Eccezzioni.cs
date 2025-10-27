using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacchieroPagamentiDigitali
{
    // crea eccezione personalizzata per valore minore di zero
    public class ValoreMinoreDiZeroException : Exception
    {
        public ValoreMinoreDiZeroException() : base("Il valore non può essere minore di zero.") { }
    }

    // crea eccezione personalizzata per autenticazione fallita
    public class AutenticazioneFallitaException : Exception
    {
        public AutenticazioneFallitaException() : base("Autenticazione fallita.") { }

    }

    // crea eccezione personalizzata per fondi insufficienti
    public class FondiInsufficientiException : Exception
    {
        public FondiInsufficientiException() : base("Fondi insufficienti per effettuare il pagamento.") { }
    }

    // crea eccezione personalizzata per data scadenza non valida
    public class DataScadenzaNonValidaException : Exception
    {
        public DataScadenzaNonValidaException() : base("La data di scadenza deve essere futura.") { }
    }

    // crea eccezione personalizzata per email non valida
    public class EmailNonValidaException : Exception
    {
        public EmailNonValidaException() : base("Inserisci una email valida.") { }
    }

    // crea eccezione personalizzata per pin non valido
    public class PinNonValidoException : Exception
    {
        public PinNonValidoException() : base("Il PIN deve essere un numero di 4 cifre.") { }
    }

    // crea eccezione personalizzata per password non valida
    public class PasswordNonValidaException : Exception
    {
        public PasswordNonValidaException() : base("La password deve essere di almeno 4 caratteri.") { }
    }

    // crea eccezione personalizzata per identificativo wallet non valido
    public class IdentificativoWalletNonValidoException : Exception
    {
        public IdentificativoWalletNonValidoException() : base("L'identificativo del wallet non può essere vuoto.") { }
    }
}
