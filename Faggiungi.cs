using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroPagamentiDigitali
{
    public partial class Faggiungi : Form
    {
        public CPagamentoBase pagamentoIn {get; private set; }
        public Faggiungi()
        {
            InitializeComponent();

            inizio();

            // fare evento se cambia il combobox
            cmb_scelta.SelectedIndexChanged += (s, e) => cambiatiCMB();
            
        }

        private void inizio()
        {
            cmb_scelta.Items.Add("Carta di credito");
            cmb_scelta.Items.Add("PayPal");
            cmb_scelta.Items.Add("Criptovaluta");
            cmb_scelta.Items.Add("Apple Pay");
            cmb_scelta.SelectedIndex = 0;

            // non permette di scrivere nel combobox
            cmb_scelta.DropDownStyle = ComboBoxStyle.DropDownList;

            cambiatiCMB();

            // tutti i textbox dove va scritta una password devono non poter mostrare i caratteri
            txt_pass.UseSystemPasswordChar = true;
        }

        private void cambiatiCMB()
        {
            // nascondere tutti i pannelli
            pnl_carta.Visible = false;
            pnl_PayPal.Visible = false;
            pnl_cripto.Visible = false;
            pnl_IdApple.Visible = false;

            // mostrare il pannello giusto
            switch (cmb_scelta.SelectedIndex)
            {
                case 0:
                    pnl_carta.Visible = true;
                    break;
                case 1:
                    pnl_PayPal.Visible = true;
                    break;
                case 2:
                    pnl_cripto.Visible = true;
                    break;
                case 3:
                    pnl_IdApple.Visible = true;
                    break;
            }
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            switch (cmb_scelta.SelectedIndex)
            {
                case 0:
                    creaCarta();
                    break;
                case 1:
                    CreaPayPal();
                    break;
                case 2:
                    CreaCripto();
                    break;
                case 3:
                    CreaApplePay();
                    break;
                default:
                    MessageBox.Show("Selezione non valida.");
                    break;
            }
        }

        private void creaCarta()
        {
            int numeroCarta = (int)nmr_numeroCarta.Value;
            DateTime dataScadenza = dtp_data.Value;
            int pin = (int)nmr_pin.Value;
            double saldo = (double)nmr_saldo.Value;

            try
            {
                if (numeroCarta < 0)
                {
                    throw new ValoreMinoreDiZeroException();
                }

                if (dataScadenza <= DateTime.Now)
                {
                    throw new DataScadenzaNonValidaException();
                }

                if (pin < 0 || pin.ToString().Length != 4)
                {
                    throw new PinNonValidoException();
                }

                if (saldo <= 0)
                {
                    throw new ValoreMinoreDiZeroException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            pagamentoIn = new CPagamentoCarta(numeroCarta, dataScadenza, pin, saldo);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CreaPayPal()
        {
            string emailAccount = txt_mail.Text;
            string password = txt_pass.Text;
            double saldo = (double)nmr_saldo.Value;
           

            try
            {
                if (string.IsNullOrWhiteSpace(emailAccount) || !emailAccount.Contains("@"))
                {
                    throw new EmailNonValidaException();
                }

                if (string.IsNullOrWhiteSpace(password) || password.Length < 4)
                {
                    throw new PasswordNonValidaException();
                }

                if (saldo <= 0)
                {
                    throw new ValoreMinoreDiZeroException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            pagamentoIn = new CPagamentoPayPal(emailAccount, password, saldo);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CreaCripto()
        {
            int idWallet = (int)nmr_identificativo.Value;
            
            double saldo = (double)nmr_saldo.Value;

            try
            {
                if (idWallet < 0 || idWallet.ToString().Length < 4)
                {
                    throw new IdentificativoWalletNonValidoException();
                }

                if (saldo <= 0)
                {
                    throw new ValoreMinoreDiZeroException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            pagamentoIn = new CPagamentoCripto(idWallet, saldo);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CreaApplePay()
        {
            string idApple = txt_IdApple.Text;
            double saldo = (double)nmr_saldo.Value;
            try
            {
                if (string.IsNullOrWhiteSpace(idApple) || !idApple.Contains("@"))
                {
                    throw new EmailNonValidaException();
                }

                if (saldo <= 0)
                {
                    throw new ValoreMinoreDiZeroException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            pagamentoIn = new CApplePay(idApple, saldo);
            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void Faggiungi_Load(object sender, EventArgs e)
        {

        }
    }
}
