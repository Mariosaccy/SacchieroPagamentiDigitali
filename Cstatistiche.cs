using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacchieroPagamentiDigitali
{
    public static class Cstatistiche
    {
        public static double TotaleIncassato { get; set; } = 0;
        public static int TotaleTransazioni { get; set; } = 0;
        public static double TransizioniCarta { get; set; } = 0;
        public static double TransizioniPayPal { get; set; } = 0;
        public static double TransizioniApplePay { get; set; } = 0;
        public static double TransizioniCripto { get; set; } = 0;
        public static string TipoTransazionePiuUsata { get; set; }

        public static void CalcolaTransazionePiuUsata()
        {
            if(TransizioniCarta > TransizioniPayPal && TransizioniCarta > TransizioniApplePay && TransizioniCarta > TransizioniCripto)
            {
                TipoTransazionePiuUsata = "Carta di credito";
            } else if(TransizioniPayPal > TransizioniCarta && TransizioniPayPal > TransizioniApplePay && TransizioniPayPal > TransizioniCripto)
            {
                TipoTransazionePiuUsata = "PayPal";
            } else if (TransizioniApplePay > TransizioniCarta && TransizioniApplePay > TransizioniPayPal && TransizioniApplePay > TransizioniCripto)
            {
                TipoTransazionePiuUsata = "Apple Pay";
            }
            else if (TransizioniCripto > TransizioniCarta && TransizioniCripto > TransizioniPayPal && TransizioniCripto > TransizioniApplePay)
            {
                TipoTransazionePiuUsata = "Criptovaluta";
            }
            else
            {
                TipoTransazionePiuUsata = "Hanno tutti lo stesso numero di transizioni";
            }
        }

        public static string StampaStatistiche()
        {
            CalcolaTransazionePiuUsata();
            string testo = "";
            // \r \n va a capo, \r serve per tornare all'inizio della riga e \n per andare a capo
            testo += "----- Statistiche Pagamenti Digitali -----\r\n";
            testo += $"Totale Incassato: {TotaleIncassato}\r\n";
            testo += $"Totale Transazioni: {TotaleTransazioni}\r\n";
            testo += $"Tipo con più transizioni: {TipoTransazionePiuUsata}\r\n";

            return testo;
        }
    }
}
