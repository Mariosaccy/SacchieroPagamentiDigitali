namespace SacchieroPagamentiDigitali
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.btn_paga = new System.Windows.Forms.Button();
            this.txt_statistiche = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(185, 125);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(96, 47);
            this.btn_aggiungi.TabIndex = 0;
            this.btn_aggiungi.Text = "aggiungi carta";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // btn_paga
            // 
            this.btn_paga.Location = new System.Drawing.Point(519, 125);
            this.btn_paga.Name = "btn_paga";
            this.btn_paga.Size = new System.Drawing.Size(96, 47);
            this.btn_paga.TabIndex = 1;
            this.btn_paga.Text = "paga";
            this.btn_paga.UseVisualStyleBackColor = true;
            this.btn_paga.Click += new System.EventHandler(this.btn_paga_Click);
            // 
            // txt_statistiche
            // 
            this.txt_statistiche.Location = new System.Drawing.Point(241, 223);
            this.txt_statistiche.Multiline = true;
            this.txt_statistiche.Name = "txt_statistiche";
            this.txt_statistiche.Size = new System.Drawing.Size(318, 196);
            this.txt_statistiche.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_statistiche);
            this.Controls.Add(this.btn_paga);
            this.Controls.Add(this.btn_aggiungi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.Button btn_paga;
        private System.Windows.Forms.TextBox txt_statistiche;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

