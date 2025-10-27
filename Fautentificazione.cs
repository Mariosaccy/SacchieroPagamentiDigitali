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
    public partial class Fautentificazione : Form
    {
        CPagamentoBase carta;
        public Fautentificazione( CPagamentoBase carta)
        {
            InitializeComponent();
            this.carta = carta;

            inizio();
        }

        private void inizio()
        {
            // fare in modo che nel textbox non si vedano i caratteri inseriti
            txt_pass.UseSystemPasswordChar = true;

            if (carta is CPagamentoCarta Cc)
            {
                lbl_titolo.Text = $"Inserisci il PIN della carta {Cc.numeroCarta}:";
                txt_pass.Visible = false;
                nmr_pin.Visible = true;
            }
            else if(carta is CPagamentoPayPal Cp)
            {
                lbl_titolo.Text = $"Inserisci la password di PayPal {Cp.emailAccount}:";
                nmr_pin.Visible = false;
                txt_pass.Visible = true;
            }
        }
        private void btn_invia_Click(object sender, EventArgs e)
        {
            string inputPass;
            if (carta is CPagamentoCarta Cc)
            {
                inputPass = nmr_pin.Value.ToString();
                int pinInt = (int)nmr_pin.Value;

                try
                {
                    if(pinInt <= 0 || inputPass.Length != 4)
                    {
                        throw new PinNonValidoException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                if (pinInt == Cc.pin && Cc.dataScadenza > DateTime.Now)
                {
                    MessageBox.Show("Autenticazione riuscita!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else if (carta is CPagamentoPayPal Cp)
            {
                inputPass = txt_pass.Text;

                try
                {
                    if(string.IsNullOrEmpty(inputPass) || !inputPass.Contains("@"))
                    {
                        throw new PasswordNonValidaException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                if (inputPass == Cp.password)
                {
                    MessageBox.Show("Autenticazione riuscita!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void Fautentificazione_Load(object sender, EventArgs e)
        {

        }
    }
}
