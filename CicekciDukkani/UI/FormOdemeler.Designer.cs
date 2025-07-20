namespace CicekciDukkani.UI
{
    partial class FormOdemeler
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSiparisID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textOdemeID = new System.Windows.Forms.TextBox();
            this.SiparişID = new System.Windows.Forms.Label();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.buttonİptal = new System.Windows.Forms.Button();
            this.nmOdemeTutarı = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOdemeDurumu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmOdemeTutarı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(353, 33);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ödeme Tutarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ödeme Tarihi";
            // 
            // textSiparisID
            // 
            this.textSiparisID.Location = new System.Drawing.Point(181, 74);
            this.textSiparisID.Name = "textSiparisID";
            this.textSiparisID.ReadOnly = true;
            this.textSiparisID.Size = new System.Drawing.Size(353, 33);
            this.textSiparisID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "SiparişID";
            // 
            // textOdemeID
            // 
            this.textOdemeID.Location = new System.Drawing.Point(181, 17);
            this.textOdemeID.Name = "textOdemeID";
            this.textOdemeID.ReadOnly = true;
            this.textOdemeID.Size = new System.Drawing.Size(353, 33);
            this.textOdemeID.TabIndex = 0;
            // 
            // SiparişID
            // 
            this.SiparişID.AutoSize = true;
            this.SiparişID.Location = new System.Drawing.Point(63, 22);
            this.SiparişID.Name = "SiparişID";
            this.SiparişID.Size = new System.Drawing.Size(100, 28);
            this.SiparişID.TabIndex = 37;
            this.SiparişID.Text = "ÖdemeID";
            // 
            // buttonTamam
            // 
            this.buttonTamam.Location = new System.Drawing.Point(191, 382);
            this.buttonTamam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTamam.Name = "buttonTamam";
            this.buttonTamam.Size = new System.Drawing.Size(166, 40);
            this.buttonTamam.TabIndex = 6;
            this.buttonTamam.Text = "Tamam";
            this.buttonTamam.UseVisualStyleBackColor = true;
            // 
            // buttonİptal
            // 
            this.buttonİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonİptal.Location = new System.Drawing.Point(368, 382);
            this.buttonİptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonİptal.Name = "buttonİptal";
            this.buttonİptal.Size = new System.Drawing.Size(166, 40);
            this.buttonİptal.TabIndex = 7;
            this.buttonİptal.Text = "İptal";
            this.buttonİptal.UseVisualStyleBackColor = true;
            this.buttonİptal.Click += new System.EventHandler(this.buttonİptal_Click);
            // 
            // nmOdemeTutarı
            // 
            this.nmOdemeTutarı.DecimalPlaces = 2;
            this.nmOdemeTutarı.Location = new System.Drawing.Point(181, 195);
            this.nmOdemeTutarı.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmOdemeTutarı.Name = "nmOdemeTutarı";
            this.nmOdemeTutarı.Size = new System.Drawing.Size(353, 33);
            this.nmOdemeTutarı.TabIndex = 3;
            // 
            // comboBoxOdemeTuru
            // 
            this.comboBoxOdemeTuru.FormattingEnabled = true;
            this.comboBoxOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Banka Transferi",
            "Kapıda Ödeme"});
            this.comboBoxOdemeTuru.Location = new System.Drawing.Point(181, 254);
            this.comboBoxOdemeTuru.Name = "comboBoxOdemeTuru";
            this.comboBoxOdemeTuru.Size = new System.Drawing.Size(353, 36);
            this.comboBoxOdemeTuru.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ödeme Türü";
            // 
            // comboBoxOdemeDurumu
            // 
            this.comboBoxOdemeDurumu.FormattingEnabled = true;
            this.comboBoxOdemeDurumu.Items.AddRange(new object[] {
            "Tamamlandı",
            "Beklemede",
            "İptal Edildi"});
            this.comboBoxOdemeDurumu.Location = new System.Drawing.Point(181, 311);
            this.comboBoxOdemeDurumu.Name = "comboBoxOdemeDurumu";
            this.comboBoxOdemeDurumu.Size = new System.Drawing.Size(353, 36);
            this.comboBoxOdemeDurumu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "Ödeme Durumu";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormOdemeler
            // 
            this.AcceptButton = this.buttonTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonİptal;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.comboBoxOdemeDurumu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOdemeTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmOdemeTutarı);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSiparisID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textOdemeID);
            this.Controls.Add(this.SiparişID);
            this.Controls.Add(this.buttonTamam);
            this.Controls.Add(this.buttonİptal);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormOdemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOdemeler";
            ((System.ComponentModel.ISupportInitialize)(this.nmOdemeTutarı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSiparisID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOdemeID;
        private System.Windows.Forms.Label SiparişID;
        private System.Windows.Forms.Button buttonTamam;
        private System.Windows.Forms.Button buttonİptal;
        private System.Windows.Forms.NumericUpDown nmOdemeTutarı;
        private System.Windows.Forms.ComboBox comboBoxOdemeTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOdemeDurumu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}