namespace SacchieroPagamentiDigitali
{
    partial class Fautentificazione
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
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_invia = new System.Windows.Forms.Button();
            this.nmr_pin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_pin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Location = new System.Drawing.Point(153, 48);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(99, 13);
            this.lbl_titolo.TabIndex = 0;
            this.lbl_titolo.Text = "inserire la password";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(152, 75);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 1;
            // 
            // btn_invia
            // 
            this.btn_invia.Location = new System.Drawing.Point(165, 101);
            this.btn_invia.Name = "btn_invia";
            this.btn_invia.Size = new System.Drawing.Size(75, 27);
            this.btn_invia.TabIndex = 2;
            this.btn_invia.Text = "paga";
            this.btn_invia.UseVisualStyleBackColor = true;
            this.btn_invia.Click += new System.EventHandler(this.btn_invia_Click);
            // 
            // nmr_pin
            // 
            this.nmr_pin.Location = new System.Drawing.Point(142, 76);
            this.nmr_pin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmr_pin.Name = "nmr_pin";
            this.nmr_pin.Size = new System.Drawing.Size(120, 20);
            this.nmr_pin.TabIndex = 3;
            // 
            // Fautentificazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 193);
            this.Controls.Add(this.nmr_pin);
            this.Controls.Add(this.btn_invia);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_titolo);
            this.Name = "Fautentificazione";
            this.Text = "Fautentificazione";
            this.Load += new System.EventHandler(this.Fautentificazione_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_pin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_invia;
        private System.Windows.Forms.NumericUpDown nmr_pin;
    }
}