namespace GestioneprodottiCRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nome_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Prezzo_box = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.modprezzo_box = new System.Windows.Forms.TextBox();
            this.modnome_box = new System.Windows.Forms.TextBox();
            this.ricerca_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.perc_box = new System.Windows.Forms.TextBox();
            this.articoli = new System.Windows.Forms.ListBox();
            this.somma_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.max_btn = new System.Windows.Forms.Button();
            this.min_btn = new System.Windows.Forms.Button();
            this.percentuale_btn = new System.Windows.Forms.Button();
            this.Modificap_btn = new System.Windows.Forms.Button();
            this.Modifican_btn = new System.Windows.Forms.Button();
            this.cancella_btn = new System.Windows.Forms.Button();
            this.inserisci_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // Nome_box
            // 
            this.Nome_box.Location = new System.Drawing.Point(48, 44);
            this.Nome_box.Name = "Nome_box";
            this.Nome_box.Size = new System.Drawing.Size(97, 20);
            this.Nome_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PREZZO";
            // 
            // Prezzo_box
            // 
            this.Prezzo_box.Location = new System.Drawing.Point(189, 44);
            this.Prezzo_box.Name = "Prezzo_box";
            this.Prezzo_box.Size = new System.Drawing.Size(97, 20);
            this.Prezzo_box.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 353);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 20);
            this.textBox3.TabIndex = 4;
            // 
            // modprezzo_box
            // 
            this.modprezzo_box.Location = new System.Drawing.Point(48, 254);
            this.modprezzo_box.Name = "modprezzo_box";
            this.modprezzo_box.Size = new System.Drawing.Size(97, 20);
            this.modprezzo_box.TabIndex = 5;
            // 
            // modnome_box
            // 
            this.modnome_box.Location = new System.Drawing.Point(48, 201);
            this.modnome_box.Name = "modnome_box";
            this.modnome_box.Size = new System.Drawing.Size(97, 20);
            this.modnome_box.TabIndex = 6;
            // 
            // ricerca_box
            // 
            this.ricerca_box.Location = new System.Drawing.Point(48, 146);
            this.ricerca_box.Name = "ricerca_box";
            this.ricerca_box.Size = new System.Drawing.Size(97, 20);
            this.ricerca_box.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "inserire una percentuale \r\nda sommare o sottrarre \r\na tutti i prezzi dei prodotti" +
    "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "MODIFICA PREZZO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MODIFICA NOME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "RICERCA NOME";
            // 
            // perc_box
            // 
            this.perc_box.Location = new System.Drawing.Point(48, 379);
            this.perc_box.Name = "perc_box";
            this.perc_box.Size = new System.Drawing.Size(97, 20);
            this.perc_box.TabIndex = 12;
            // 
            // articoli
            // 
            this.articoli.BackColor = System.Drawing.SystemColors.Window;
            this.articoli.ForeColor = System.Drawing.SystemColors.WindowText;
            this.articoli.FormattingEnabled = true;
            this.articoli.Location = new System.Drawing.Point(492, 12);
            this.articoli.Name = "articoli";
            this.articoli.Size = new System.Drawing.Size(323, 407);
            this.articoli.TabIndex = 13;
            // 
            // somma_btn
            // 
            this.somma_btn.Location = new System.Drawing.Point(377, 185);
            this.somma_btn.Name = "somma_btn";
            this.somma_btn.Size = new System.Drawing.Size(89, 36);
            this.somma_btn.TabIndex = 15;
            this.somma_btn.Text = "somma prezzo prodotti";
            this.somma_btn.UseVisualStyleBackColor = true;
            this.somma_btn.Click += new System.EventHandler(this.somma_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 57);
            this.button3.TabIndex = 16;
            this.button3.Text = "ordinamento dei prodotti";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // max_btn
            // 
            this.max_btn.Location = new System.Drawing.Point(377, 46);
            this.max_btn.Name = "max_btn";
            this.max_btn.Size = new System.Drawing.Size(78, 28);
            this.max_btn.TabIndex = 17;
            this.max_btn.Text = "prezzo max";
            this.max_btn.UseVisualStyleBackColor = true;
            this.max_btn.Click += new System.EventHandler(this.max_btn_Click);
            // 
            // min_btn
            // 
            this.min_btn.Location = new System.Drawing.Point(377, 12);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(78, 28);
            this.min_btn.TabIndex = 18;
            this.min_btn.Text = "prezzo min";
            this.min_btn.UseVisualStyleBackColor = true;
            this.min_btn.Click += new System.EventHandler(this.min_btn_Click);
            // 
            // percentuale_btn
            // 
            this.percentuale_btn.Location = new System.Drawing.Point(174, 371);
            this.percentuale_btn.Name = "percentuale_btn";
            this.percentuale_btn.Size = new System.Drawing.Size(78, 28);
            this.percentuale_btn.TabIndex = 19;
            this.percentuale_btn.Text = "percentuale";
            this.percentuale_btn.UseVisualStyleBackColor = true;
            this.percentuale_btn.Click += new System.EventHandler(this.percentuale_btn_Click);
            // 
            // Modificap_btn
            // 
            this.Modificap_btn.Location = new System.Drawing.Point(169, 246);
            this.Modificap_btn.Name = "Modificap_btn";
            this.Modificap_btn.Size = new System.Drawing.Size(78, 28);
            this.Modificap_btn.TabIndex = 20;
            this.Modificap_btn.Text = "modifica";
            this.Modificap_btn.UseVisualStyleBackColor = true;
            this.Modificap_btn.Click += new System.EventHandler(this.Modificap_btn_Click);
            // 
            // Modifican_btn
            // 
            this.Modifican_btn.Location = new System.Drawing.Point(169, 193);
            this.Modifican_btn.Name = "Modifican_btn";
            this.Modifican_btn.Size = new System.Drawing.Size(78, 28);
            this.Modifican_btn.TabIndex = 21;
            this.Modifican_btn.Text = "modifica";
            this.Modifican_btn.UseVisualStyleBackColor = true;
            this.Modifican_btn.Click += new System.EventHandler(this.Modifican_btn_Click);
            // 
            // cancella_btn
            // 
            this.cancella_btn.Location = new System.Drawing.Point(169, 138);
            this.cancella_btn.Name = "cancella_btn";
            this.cancella_btn.Size = new System.Drawing.Size(78, 28);
            this.cancella_btn.TabIndex = 22;
            this.cancella_btn.Text = "cancella";
            this.cancella_btn.UseVisualStyleBackColor = true;
            this.cancella_btn.Click += new System.EventHandler(this.cancella_btn_Click);
            // 
            // inserisci_btn
            // 
            this.inserisci_btn.Location = new System.Drawing.Point(138, 70);
            this.inserisci_btn.Name = "inserisci_btn";
            this.inserisci_btn.Size = new System.Drawing.Size(75, 23);
            this.inserisci_btn.TabIndex = 23;
            this.inserisci_btn.Text = "aggiungi";
            this.inserisci_btn.UseVisualStyleBackColor = true;
            this.inserisci_btn.Click += new System.EventHandler(this.inserisci_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.inserisci_btn);
            this.Controls.Add(this.cancella_btn);
            this.Controls.Add(this.Modifican_btn);
            this.Controls.Add(this.Modificap_btn);
            this.Controls.Add(this.percentuale_btn);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.max_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.somma_btn);
            this.Controls.Add(this.articoli);
            this.Controls.Add(this.perc_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ricerca_box);
            this.Controls.Add(this.modnome_box);
            this.Controls.Add(this.modprezzo_box);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Prezzo_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome_box);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Prezzo_box;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox modprezzo_box;
        private System.Windows.Forms.TextBox modnome_box;
        private System.Windows.Forms.TextBox ricerca_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox perc_box;
        private System.Windows.Forms.ListBox articoli;
        private System.Windows.Forms.Button somma_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button max_btn;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.Button percentuale_btn;
        private System.Windows.Forms.Button Modificap_btn;
        private System.Windows.Forms.Button Modifican_btn;
        private System.Windows.Forms.Button cancella_btn;
        private System.Windows.Forms.Button inserisci_btn;
    }
}

