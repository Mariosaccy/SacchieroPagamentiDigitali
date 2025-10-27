using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroPagamentiDigitali
{
    public partial class Form1 : Form
    {
        List<CPagamentoBase> pagamenti = new List<CPagamentoBase>();
        int index = 0;
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(Form1_Closing);

            inizio();

        }

        private void inizio()
        {
            // non permette di scrivere nel textbox delle statistiche
            txt_statistiche.ReadOnly = true;
            txt_statistiche.Multiline = true; // per permettere più righe
            aggiornaStatistiche();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            // chiedere conferma prima di chiudere
            var result = MessageBox.Show("Sei sicuro di voler uscire?", "Conferma uscita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // annulla la chiusura
            }
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            Faggiungi finestra = new Faggiungi();
            if (finestra.ShowDialog() == DialogResult.OK)
            {
                pagamenti.Add(finestra.pagamentoIn);
                index++;
                MessageBox.Show("Pagamento aggiunto con successo!");
                aggiornaStatistiche();
            }
            else
            {
                MessageBox.Show("Aggiunta pagamento annullata.");
            }
        }

        private void btn_paga_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                MessageBox.Show("Nessun metodo di pagamento disponibile. Aggiungi un metodo di pagamento prima di procedere.");
                return;
            }

            Fpaga finestra = new Fpaga(pagamenti);
            if (finestra.ShowDialog() == DialogResult.OK)
            {
                pagamenti = finestra.pagamenti; // aggiorna la lista dei pagamenti
                aggiornaStatistiche();
            }
        }

        private void aggiornaStatistiche()
        {
            txt_statistiche.Clear();
            txt_statistiche.AppendText(Cstatistiche.StampaStatistiche());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
