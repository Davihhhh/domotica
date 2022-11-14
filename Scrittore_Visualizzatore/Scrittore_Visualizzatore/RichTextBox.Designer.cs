namespace Scrittore_Visualizzatore
{
    partial class RichTextBox
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
            this.checkBoxCorsivo = new System.Windows.Forms.CheckBox();
            this.checkBoxSottolineato = new System.Windows.Forms.CheckBox();
            this.checkBoxGrassetto = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInvio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxCorsivo
            // 
            this.checkBoxCorsivo.AutoSize = true;
            this.checkBoxCorsivo.BackColor = System.Drawing.Color.Thistle;
            this.checkBoxCorsivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBoxCorsivo.Location = new System.Drawing.Point(58, 111);
            this.checkBoxCorsivo.Name = "checkBoxCorsivo";
            this.checkBoxCorsivo.Size = new System.Drawing.Size(85, 24);
            this.checkBoxCorsivo.TabIndex = 0;
            this.checkBoxCorsivo.Text = "Corsivo";
            this.checkBoxCorsivo.UseVisualStyleBackColor = false;
            // 
            // checkBoxSottolineato
            // 
            this.checkBoxSottolineato.AutoSize = true;
            this.checkBoxSottolineato.BackColor = System.Drawing.Color.Thistle;
            this.checkBoxSottolineato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBoxSottolineato.Location = new System.Drawing.Point(58, 217);
            this.checkBoxSottolineato.Name = "checkBoxSottolineato";
            this.checkBoxSottolineato.Size = new System.Drawing.Size(116, 24);
            this.checkBoxSottolineato.TabIndex = 2;
            this.checkBoxSottolineato.Text = "Sottolineato";
            this.checkBoxSottolineato.UseVisualStyleBackColor = false;
            // 
            // checkBoxGrassetto
            // 
            this.checkBoxGrassetto.AutoSize = true;
            this.checkBoxGrassetto.BackColor = System.Drawing.Color.Thistle;
            this.checkBoxGrassetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBoxGrassetto.Location = new System.Drawing.Point(58, 165);
            this.checkBoxGrassetto.Name = "checkBoxGrassetto";
            this.checkBoxGrassetto.Size = new System.Drawing.Size(102, 24);
            this.checkBoxGrassetto.TabIndex = 3;
            this.checkBoxGrassetto.Text = "Grassetto";
            this.checkBoxGrassetto.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(387, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(403, 406);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Thistle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(58, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonInvio
            // 
            this.buttonInvio.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonInvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonInvio.Location = new System.Drawing.Point(58, 366);
            this.buttonInvio.Name = "buttonInvio";
            this.buttonInvio.Size = new System.Drawing.Size(103, 33);
            this.buttonInvio.TabIndex = 7;
            this.buttonInvio.Text = "Invio";
            this.buttonInvio.UseVisualStyleBackColor = false;
            this.buttonInvio.Click += new System.EventHandler(this.buttonInvio_Click);
            // 
            // RichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 476);
            this.Controls.Add(this.buttonInvio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBoxGrassetto);
            this.Controls.Add(this.checkBoxSottolineato);
            this.Controls.Add(this.checkBoxCorsivo);
            this.Name = "RichTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen";
            this.Load += new System.EventHandler(this.RichTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCorsivo;
        private System.Windows.Forms.CheckBox checkBoxSottolineato;
        private System.Windows.Forms.CheckBox checkBoxGrassetto;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonInvio;
    }
}

