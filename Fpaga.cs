using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroPagamentiDigitali
{
    public partial class Fpaga : Form
    {
        public List<CPagamentoBase> pagamenti = new List<CPagamentoBase>();
        public Fpaga(List<CPagamentoBase> pagamenti)
        {
            InitializeComponent();
            this.pagamenti = pagamenti;

            inizio();
        }

        private void inizio()
        {
            // popolare il combobox con i pagamenti
            cmb_scelta.Items.Clear();
            foreach (var pagamento in pagamenti)
            {
                if (pagamento is CPagamentoCarta Cc)
                {
                    cmb_scelta.Items.Add($"Carta di credito - {Cc.numeroCarta}");
                }
                else if (pagamento is CPagamentoPayPal Cp)
                {
                    cmb_scelta.Items.Add($"PayPal - {Cp.emailAccount}");
                }
                else if (pagamento is CPagamentoCripto Ccr)
                {
                    cmb_scelta.Items.Add($"Criptovaluta - {Ccr.identificativoWallet}");
                }
                else if (pagamento is CApplePay Cap)
                {
                    cmb_scelta.Items.Add($"Apple Pay - {Cap.IDapple}");
                }

                // non permette di scrivere nel combobox
                cmb_scelta.DropDownStyle = ComboBoxStyle.DropDownList;

                cmb_scelta.SelectedIndex = 0;
            }
        }

        private void btn_paga_Click(object sender, EventArgs e)
        {
            // prende la slezione
            int index = cmb_scelta.SelectedIndex;
            double importo = (double)nmr_importo.Value;

            try
            {
                if(importo <= 0)
                {
                    throw new ValoreMinoreDiZeroException();
                }

                if (!pagamenti[index].VerificaDisponibilita(importo))
                {
                    throw new FondiInsufficientiException();
                }

                // verifica se richiede autenticazione
                if (pagamenti[index] is Iautenticazione authPagamento)
                {
                    if (!authPagamento.autenticazione())
                    {
                        throw new AutenticazioneFallitaException();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il pagamento: {ex.Message}");
                return;
            }

            // esegue il pagamento
            pagamenti[index].Paga(importo);
            MessageBox.Show(pagamenti[index].StampaRicevuta());

            modificaSatistiche(index);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void modificaSatistiche(int index)
        {
            var pagamentoSelezionato = pagamenti[index];

            if (pagamentoSelezionato is CPagamentoCarta)
            {
                Cstatistiche.TransizioniCarta += 1;
            }
            else if (pagamentoSelezionato is CPagamentoPayPal)
            {
                Cstatistiche.TransizioniPayPal += 1;
            }
            else if (pagamentoSelezionato is CPagamentoCripto)
            {
                Cstatistiche.TransizioniCripto += 1;
            }
            else if (pagamentoSelezionato is CApplePay)
            {
                Cstatistiche.TransizioniApplePay += 1;
            }
            else
            {
                MessageBox.Show("Metodo di pagamento non valido.");
            }
        }

        private void Fpaga_Load(object sender, EventArgs e)
        {

        }
    }
}
