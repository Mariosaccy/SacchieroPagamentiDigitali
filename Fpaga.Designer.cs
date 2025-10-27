namespace SacchieroPagamentiDigitali
{
    partial class Fpaga
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
            this.lbl_selta = new System.Windows.Forms.Label();
            this.cmb_scelta = new System.Windows.Forms.ComboBox();
            this.nmr_importo = new System.Windows.Forms.NumericUpDown();
            this.btn_paga = new System.Windows.Forms.Button();
            this.lbl_importo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_importo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_selta
            // 
            this.lbl_selta.AutoSize = true;
            this.lbl_selta.Location = new System.Drawing.Point(323, 60);
            this.lbl_selta.Name = "lbl_selta";
            this.lbl_selta.Size = new System.Drawing.Size(154, 13);
            this.lbl_selta.TabIndex = 19;
            this.lbl_selta.Text = "scegliere metodo di pagamento";
            // 
            // cmb_scelta
            // 
            this.cmb_scelta.FormattingEnabled = true;
            this.cmb_scelta.Location = new System.Drawing.Point(309, 76);
            this.cmb_scelta.Name = "cmb_scelta";
            this.cmb_scelta.Size = new System.Drawing.Size(183, 21);
            this.cmb_scelta.TabIndex = 18;
            // 
            // nmr_importo
            // 
            this.nmr_importo.Location = new System.Drawing.Point(340, 162);
            this.nmr_importo.Name = "nmr_importo";
            this.nmr_importo.Size = new System.Drawing.Size(120, 20);
            this.nmr_importo.TabIndex = 20;
            // 
            // btn_paga
            // 
            this.btn_paga.Location = new System.Drawing.Point(363, 243);
            this.btn_paga.Name = "btn_paga";
            this.btn_paga.Size = new System.Drawing.Size(75, 23);
            this.btn_paga.TabIndex = 21;
            this.btn_paga.Text = "paga";
            this.btn_paga.UseVisualStyleBackColor = true;
            this.btn_paga.Click += new System.EventHandler(this.btn_paga_Click);
            // 
            // lbl_importo
            // 
            this.lbl_importo.AutoSize = true;
            this.lbl_importo.Location = new System.Drawing.Point(337, 146);
            this.lbl_importo.Name = "lbl_importo";
            this.lbl_importo.Size = new System.Drawing.Size(41, 13);
            this.lbl_importo.TabIndex = 22;
            this.lbl_importo.Text = "importo";
            // 
            // Fpaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_importo);
            this.Controls.Add(this.btn_paga);
            this.Controls.Add(this.nmr_importo);
            this.Controls.Add(this.lbl_selta);
            this.Controls.Add(this.cmb_scelta);
            this.Name = "Fpaga";
            this.Text = "Fpaga";
            this.Load += new System.EventHandler(this.Fpaga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_importo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selta;
        private System.Windows.Forms.ComboBox cmb_scelta;
        private System.Windows.Forms.NumericUpDown nmr_importo;
        private System.Windows.Forms.Button btn_paga;
        private System.Windows.Forms.Label lbl_importo;
    }
}