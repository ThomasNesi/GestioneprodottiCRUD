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
            this.modprezzo_box = new System.Windows.Forms.TextBox();
            this.modnome_box = new System.Windows.Forms.TextBox();
            this.ricerca_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.articoli = new System.Windows.Forms.ListBox();
            this.somma_btn = new System.Windows.Forms.Button();
            this.ordinamento_btn = new System.Windows.Forms.Button();
            this.max_btn = new System.Windows.Forms.Button();
            this.min_btn = new System.Windows.Forms.Button();
            this.Modificap_btn = new System.Windows.Forms.Button();
            this.Modifican_btn = new System.Windows.Forms.Button();
            this.cancella_btn = new System.Windows.Forms.Button();
            this.inserisci_btn = new System.Windows.Forms.Button();
            this.fileprod_btn = new System.Windows.Forms.Button();
            this.mostraprod_btn = new System.Windows.Forms.Button();
            this.prc_box = new System.Windows.Forms.TextBox();
            this.sott_btn = new System.Windows.Forms.Button();
            this.agg_btn = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(45, 292);
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
            // articoli
            // 
            this.articoli.BackColor = System.Drawing.SystemColors.Window;
            this.articoli.ForeColor = System.Drawing.SystemColors.WindowText;
            this.articoli.FormattingEnabled = true;
            this.articoli.Location = new System.Drawing.Point(492, 12);
            this.articoli.Name = "articoli";
            this.articoli.Size = new System.Drawing.Size(323, 342);
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
            // ordinamento_btn
            // 
            this.ordinamento_btn.Location = new System.Drawing.Point(377, 122);
            this.ordinamento_btn.Name = "ordinamento_btn";
            this.ordinamento_btn.Size = new System.Drawing.Size(89, 57);
            this.ordinamento_btn.TabIndex = 16;
            this.ordinamento_btn.Text = "ordinamento dei prodotti";
            this.ordinamento_btn.UseVisualStyleBackColor = true;
            this.ordinamento_btn.Click += new System.EventHandler(this.ordinamento_btn_Click);
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
            // fileprod_btn
            // 
            this.fileprod_btn.Location = new System.Drawing.Point(380, 238);
            this.fileprod_btn.Name = "fileprod_btn";
            this.fileprod_btn.Size = new System.Drawing.Size(86, 36);
            this.fileprod_btn.TabIndex = 24;
            this.fileprod_btn.Text = "salva prodotti in un file";
            this.fileprod_btn.UseVisualStyleBackColor = true;
            this.fileprod_btn.Click += new System.EventHandler(this.fileprod_btn_Click);
            // 
            // mostraprod_btn
            // 
            this.mostraprod_btn.Location = new System.Drawing.Point(380, 280);
            this.mostraprod_btn.Name = "mostraprod_btn";
            this.mostraprod_btn.Size = new System.Drawing.Size(86, 37);
            this.mostraprod_btn.TabIndex = 25;
            this.mostraprod_btn.Text = "mostra prodotti nel file";
            this.mostraprod_btn.UseVisualStyleBackColor = true;
            this.mostraprod_btn.Click += new System.EventHandler(this.mostraprod_btn_Click);
            // 
            // prc_box
            // 
            this.prc_box.Location = new System.Drawing.Point(50, 339);
            this.prc_box.Name = "prc_box";
            this.prc_box.Size = new System.Drawing.Size(100, 20);
            this.prc_box.TabIndex = 26;
            // 
            // sott_btn
            // 
            this.sott_btn.Location = new System.Drawing.Point(174, 308);
            this.sott_btn.Name = "sott_btn";
            this.sott_btn.Size = new System.Drawing.Size(75, 23);
            this.sott_btn.TabIndex = 27;
            this.sott_btn.Text = "sottrarre";
            this.sott_btn.UseVisualStyleBackColor = true;
            this.sott_btn.Click += new System.EventHandler(this.sott_btn_Click);
            // 
            // agg_btn
            // 
            this.agg_btn.Location = new System.Drawing.Point(174, 339);
            this.agg_btn.Name = "agg_btn";
            this.agg_btn.Size = new System.Drawing.Size(75, 23);
            this.agg_btn.TabIndex = 28;
            this.agg_btn.Text = "aggiungere";
            this.agg_btn.UseVisualStyleBackColor = true;
            this.agg_btn.Click += new System.EventHandler(this.agg_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 371);
            this.Controls.Add(this.agg_btn);
            this.Controls.Add(this.sott_btn);
            this.Controls.Add(this.prc_box);
            this.Controls.Add(this.mostraprod_btn);
            this.Controls.Add(this.fileprod_btn);
            this.Controls.Add(this.inserisci_btn);
            this.Controls.Add(this.cancella_btn);
            this.Controls.Add(this.Modifican_btn);
            this.Controls.Add(this.Modificap_btn);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.max_btn);
            this.Controls.Add(this.ordinamento_btn);
            this.Controls.Add(this.somma_btn);
            this.Controls.Add(this.articoli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ricerca_box);
            this.Controls.Add(this.modnome_box);
            this.Controls.Add(this.modprezzo_box);
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
        private System.Windows.Forms.TextBox modprezzo_box;
        private System.Windows.Forms.TextBox modnome_box;
        private System.Windows.Forms.TextBox ricerca_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox articoli;
        private System.Windows.Forms.Button somma_btn;
        private System.Windows.Forms.Button ordinamento_btn;
        private System.Windows.Forms.Button max_btn;
        private System.Windows.Forms.Button min_btn;
        private System.Windows.Forms.Button Modificap_btn;
        private System.Windows.Forms.Button Modifican_btn;
        private System.Windows.Forms.Button cancella_btn;
        private System.Windows.Forms.Button inserisci_btn;
        private System.Windows.Forms.Button fileprod_btn;
        private System.Windows.Forms.Button mostraprod_btn;
        private System.Windows.Forms.TextBox prc_box;
        private System.Windows.Forms.Button sott_btn;
        private System.Windows.Forms.Button agg_btn;
    }
}

