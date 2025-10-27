namespace SacchieroPagamentiDigitali
{
    partial class Faggiungi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_scelta = new System.Windows.Forms.ComboBox();
            this.nmr_saldo = new System.Windows.Forms.NumericUpDown();
            this.nmr_numeroCarta = new System.Windows.Forms.NumericUpDown();
            this.nmr_pin = new System.Windows.Forms.NumericUpDown();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.lbl_credito = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.pnl_carta = new System.Windows.Forms.Panel();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pnl_PayPal = new System.Windows.Forms.Panel();
            this.pnl_cripto = new System.Windows.Forms.Panel();
            this.lbl_identificativo = new System.Windows.Forms.Label();
            this.nmr_identificativo = new System.Windows.Forms.NumericUpDown();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.lbl_selta = new System.Windows.Forms.Label();
            this.pnl_IdApple = new System.Windows.Forms.Panel();
            this.lbl_idApple = new System.Windows.Forms.Label();
            this.txt_IdApple = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_saldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_numeroCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_pin)).BeginInit();
            this.pnl_carta.SuspendLayout();
            this.pnl_PayPal.SuspendLayout();
            this.pnl_cripto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_identificativo)).BeginInit();
            this.pnl_IdApple.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_scelta
            // 
            this.cmb_scelta.FormattingEnabled = true;
            this.cmb_scelta.Location = new System.Drawing.Point(340, 64);
            this.cmb_scelta.Name = "cmb_scelta";
            this.cmb_scelta.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta.TabIndex = 0;
            // 
            // nmr_saldo
            // 
            this.nmr_saldo.Location = new System.Drawing.Point(341, 119);
            this.nmr_saldo.Name = "nmr_saldo";
            this.nmr_saldo.Size = new System.Drawing.Size(120, 20);
            this.nmr_saldo.TabIndex = 1;
            // 
            // nmr_numeroCarta
            // 
            this.nmr_numeroCarta.Location = new System.Drawing.Point(33, 88);
            this.nmr_numeroCarta.Name = "nmr_numeroCarta";
            this.nmr_numeroCarta.Size = new System.Drawing.Size(120, 20);
            this.nmr_numeroCarta.TabIndex = 2;
            // 
            // nmr_pin
            // 
            this.nmr_pin.Location = new System.Drawing.Point(33, 136);
            this.nmr_pin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmr_pin.Name = "nmr_pin";
            this.nmr_pin.Size = new System.Drawing.Size(120, 20);
            this.nmr_pin.TabIndex = 3;
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(33, 28);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(200, 20);
            this.dtp_data.TabIndex = 4;
            // 
            // lbl_credito
            // 
            this.lbl_credito.AutoSize = true;
            this.lbl_credito.Location = new System.Drawing.Point(345, 104);
            this.lbl_credito.Name = "lbl_credito";
            this.lbl_credito.Size = new System.Drawing.Size(39, 13);
            this.lbl_credito.TabIndex = 5;
            this.lbl_credito.Text = "credito";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(31, 12);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(88, 13);
            this.lbl_data.TabIndex = 6;
            this.lbl_data.Text = "data di scadenza";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(31, 72);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(69, 13);
            this.lbl_numero.TabIndex = 7;
            this.lbl_numero.Text = "numero carta";
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Location = new System.Drawing.Point(30, 120);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(21, 13);
            this.lbl_pin.TabIndex = 8;
            this.lbl_pin.Text = "pin";
            // 
            // pnl_carta
            // 
            this.pnl_carta.Controls.Add(this.lbl_data);
            this.pnl_carta.Controls.Add(this.lbl_pin);
            this.pnl_carta.Controls.Add(this.nmr_numeroCarta);
            this.pnl_carta.Controls.Add(this.lbl_numero);
            this.pnl_carta.Controls.Add(this.nmr_pin);
            this.pnl_carta.Controls.Add(this.dtp_data);
            this.pnl_carta.Location = new System.Drawing.Point(269, 173);
            this.pnl_carta.Name = "pnl_carta";
            this.pnl_carta.Size = new System.Drawing.Size(263, 171);
            this.pnl_carta.TabIndex = 9;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(121, 26);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 10;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(121, 71);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 11;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(118, 10);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(25, 13);
            this.lbl_mail.TabIndex = 12;
            this.lbl_mail.Text = "mail";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(118, 56);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(52, 13);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "password";
            // 
            // pnl_PayPal
            // 
            this.pnl_PayPal.Controls.Add(this.lbl_mail);
            this.pnl_PayPal.Controls.Add(this.lbl_password);
            this.pnl_PayPal.Controls.Add(this.txt_mail);
            this.pnl_PayPal.Controls.Add(this.txt_pass);
            this.pnl_PayPal.Location = new System.Drawing.Point(231, 158);
            this.pnl_PayPal.Name = "pnl_PayPal";
            this.pnl_PayPal.Size = new System.Drawing.Size(339, 100);
            this.pnl_PayPal.TabIndex = 14;
            // 
            // pnl_cripto
            // 
            this.pnl_cripto.Controls.Add(this.lbl_identificativo);
            this.pnl_cripto.Controls.Add(this.nmr_identificativo);
            this.pnl_cripto.Location = new System.Drawing.Point(206, 181);
            this.pnl_cripto.Name = "pnl_cripto";
            this.pnl_cripto.Size = new System.Drawing.Size(388, 100);
            this.pnl_cripto.TabIndex = 15;
            // 
            // lbl_identificativo
            // 
            this.lbl_identificativo.AutoSize = true;
            this.lbl_identificativo.Location = new System.Drawing.Point(132, 24);
            this.lbl_identificativo.Name = "lbl_identificativo";
            this.lbl_identificativo.Size = new System.Drawing.Size(66, 13);
            this.lbl_identificativo.TabIndex = 6;
            this.lbl_identificativo.Text = "identificativo";
            // 
            // nmr_identificativo
            // 
            this.nmr_identificativo.Location = new System.Drawing.Point(134, 40);
            this.nmr_identificativo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmr_identificativo.Name = "nmr_identificativo";
            this.nmr_identificativo.Size = new System.Drawing.Size(120, 20);
            this.nmr_identificativo.TabIndex = 0;
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(363, 370);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(75, 23);
            this.btn_aggiungi.TabIndex = 16;
            this.btn_aggiungi.Text = "aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // lbl_selta
            // 
            this.lbl_selta.AutoSize = true;
            this.lbl_selta.Location = new System.Drawing.Point(338, 48);
            this.lbl_selta.Name = "lbl_selta";
            this.lbl_selta.Size = new System.Drawing.Size(91, 13);
            this.lbl_selta.TabIndex = 17;
            this.lbl_selta.Text = "tipo di pagamento";
            // 
            // pnl_IdApple
            // 
            this.pnl_IdApple.Controls.Add(this.lbl_idApple);
            this.pnl_IdApple.Controls.Add(this.txt_IdApple);
            this.pnl_IdApple.Location = new System.Drawing.Point(214, 168);
            this.pnl_IdApple.Name = "pnl_IdApple";
            this.pnl_IdApple.Size = new System.Drawing.Size(372, 100);
            this.pnl_IdApple.TabIndex = 18;
            // 
            // lbl_idApple
            // 
            this.lbl_idApple.AutoSize = true;
            this.lbl_idApple.Location = new System.Drawing.Point(135, 32);
            this.lbl_idApple.Name = "lbl_idApple";
            this.lbl_idApple.Size = new System.Drawing.Size(69, 13);
            this.lbl_idApple.TabIndex = 12;
            this.lbl_idApple.Text = "mail ID Apple";
            // 
            // txt_IdApple
            // 
            this.txt_IdApple.Location = new System.Drawing.Point(138, 48);
            this.txt_IdApple.Name = "txt_IdApple";
            this.txt_IdApple.Size = new System.Drawing.Size(100, 20);
            this.txt_IdApple.TabIndex = 10;
            // 
            // Faggiungi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_IdApple);
            this.Controls.Add(this.lbl_selta);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.pnl_cripto);
            this.Controls.Add(this.pnl_PayPal);
            this.Controls.Add(this.pnl_carta);
            this.Controls.Add(this.lbl_credito);
            this.Controls.Add(this.nmr_saldo);
            this.Controls.Add(this.cmb_scelta);
            this.Name = "Faggiungi";
            this.Text = "Faggiungi";
            this.Load += new System.EventHandler(this.Faggiungi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_saldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_numeroCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_pin)).EndInit();
            this.pnl_carta.ResumeLayout(false);
            this.pnl_carta.PerformLayout();
            this.pnl_PayPal.ResumeLayout(false);
            this.pnl_PayPal.PerformLayout();
            this.pnl_cripto.ResumeLayout(false);
            this.pnl_cripto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_identificativo)).EndInit();
            this.pnl_IdApple.ResumeLayout(false);
            this.pnl_IdApple.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_scelta;
        private System.Windows.Forms.NumericUpDown nmr_saldo;
        private System.Windows.Forms.NumericUpDown nmr_numeroCarta;
        private System.Windows.Forms.NumericUpDown nmr_pin;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label lbl_credito;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.Panel pnl_carta;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Panel pnl_PayPal;
        private System.Windows.Forms.Panel pnl_cripto;
        private System.Windows.Forms.NumericUpDown nmr_identificativo;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.Label lbl_selta;
        private System.Windows.Forms.Label lbl_identificativo;
        private System.Windows.Forms.Panel pnl_IdApple;
        private System.Windows.Forms.Label lbl_idApple;
        private System.Windows.Forms.TextBox txt_IdApple;
    }
}