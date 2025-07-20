namespace CicekciDukkani.UI
{
    partial class FormUrun
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUrunID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.buttonİptal = new System.Windows.Forms.Button();
            this.comboBoxTür = new System.Windows.Forms.ComboBox();
            this.nmFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmStok = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tür";
            // 
            // textUrunAdi
            // 
            this.textUrunAdi.Location = new System.Drawing.Point(165, 88);
            this.textUrunAdi.Name = "textUrunAdi";
            this.textUrunAdi.Size = new System.Drawing.Size(353, 33);
            this.textUrunAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "UrunAdi";
            // 
            // textUrunID
            // 
            this.textUrunID.Location = new System.Drawing.Point(165, 29);
            this.textUrunID.Name = "textUrunID";
            this.textUrunID.ReadOnly = true;
            this.textUrunID.Size = new System.Drawing.Size(353, 33);
            this.textUrunID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "UrunID";
            // 
            // buttonTamam
            // 
            this.buttonTamam.Location = new System.Drawing.Point(165, 338);
            this.buttonTamam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTamam.Name = "buttonTamam";
            this.buttonTamam.Size = new System.Drawing.Size(166, 40);
            this.buttonTamam.TabIndex = 5;
            this.buttonTamam.Text = "Tamam";
            this.buttonTamam.UseVisualStyleBackColor = true;
            this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
            // 
            // buttonİptal
            // 
            this.buttonİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonİptal.Location = new System.Drawing.Point(352, 338);
            this.buttonİptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonİptal.Name = "buttonİptal";
            this.buttonİptal.Size = new System.Drawing.Size(166, 40);
            this.buttonİptal.TabIndex = 6;
            this.buttonİptal.Text = "İptal";
            this.buttonİptal.UseVisualStyleBackColor = true;
            // 
            // comboBoxTür
            // 
            this.comboBoxTür.FormattingEnabled = true;
            this.comboBoxTür.Items.AddRange(new object[] {
            "1.Anemon (Anemone)",
            "2. Begonya (Begonia)",
            "3. Çuha Çiçeği (Velvet Flower)",
            "4. Dahliya (Dahlia)",
            "5. Erguvan (Judas Tree)",
            "6. Frezya (Freesia)",
            "7. Gül (Rosa)",
            "8. Hortensia (Hydrangea)",
            "9. İnci Çiçeği (Stephanotis)",
            "10. Japon Anemonesi (Japanese Anemone)",
            "11. Kardelen (Galanthus)",
            "12. Lale (Tulipa)",
            "13. Menekşe (Viola)",
            "14. Nergis (Narcissus)",
            "15. Orkide (Orchid)",
            "16. Papatya (Chrysanthemum)",
            "17. Renkli Begonya (Tuberous Begonia)",
            "18. Sardunya (Pelargonium)",
            "19. Sümbül (Hyacinthus)",
            "20. Yasemin (Jasmine)",
            "21. Zambak (Lilium)",
            "22. Çiğdem (Crocus)",
            "23. Kır Çiçekleri (Wildflowers)",
            "24. Petunya (Petunia)",
            "25. Salkım Söğüt (Catkins)",
            "26. İris (Iris)",
            "27. Pırıltı Çiçeği (Lantana)",
            "28. Leylak (Syringa)",
            "29. Papatya Çiçeği (Oxeye Daisy)",
            "30. Lavanta (Lavender)",
            "31. Horozibiği (Mirabilis jalapa)",
            "32. Begonya (Begonia)",
            "33. Güz Çiçeği (Calendula)",
            "34. Yıldız Çiçeği (Star of Bethlehem)",
            "35. Karanfil (Dianthus)",
            "36. Çan Çiçeği (Campanula)",
            "37. Gece Menekşesi (Hesperis matronalis)",
            "38. Kekik (Thyme)",
            "39. Sarı Çiçek (Buttercup)",
            "40. Eflatun Çiçek (Allium)"});
            this.comboBoxTür.Location = new System.Drawing.Point(165, 146);
            this.comboBoxTür.Name = "comboBoxTür";
            this.comboBoxTür.Size = new System.Drawing.Size(353, 36);
            this.comboBoxTür.TabIndex = 2;
            // 
            // nmFiyat
            // 
            this.nmFiyat.DecimalPlaces = 2;
            this.nmFiyat.Location = new System.Drawing.Point(165, 208);
            this.nmFiyat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmFiyat.Name = "nmFiyat";
            this.nmFiyat.Size = new System.Drawing.Size(353, 33);
            this.nmFiyat.TabIndex = 3;
            // 
            // nmStok
            // 
            this.nmStok.Location = new System.Drawing.Point(165, 262);
            this.nmStok.Name = "nmStok";
            this.nmStok.Size = new System.Drawing.Size(353, 33);
            this.nmStok.TabIndex = 4;
            this.nmStok.ThousandsSeparator = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormUrun
            // 
            this.AcceptButton = this.buttonTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonİptal;
            this.ClientSize = new System.Drawing.Size(573, 438);
            this.Controls.Add(this.nmStok);
            this.Controls.Add(this.nmFiyat);
            this.Controls.Add(this.comboBoxTür);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUrunID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTamam);
            this.Controls.Add(this.buttonİptal);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUrun";
            this.Load += new System.EventHandler(this.FormUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUrunID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTamam;
        private System.Windows.Forms.Button buttonİptal;
        private System.Windows.Forms.ComboBox comboBoxTür;
        private System.Windows.Forms.NumericUpDown nmFiyat;
        private System.Windows.Forms.NumericUpDown nmStok;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}