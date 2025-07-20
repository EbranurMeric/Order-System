namespace CicekciDukkani.UI
{
    partial class FormSiparis
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMusteriID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUrunID = new System.Windows.Forms.TextBox();
            this.SiparişID = new System.Windows.Forms.Label();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.buttonİptal = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textTeslimatAdresi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSiparisDurumu = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Teslimat Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sipariş Durumu";
            // 
            // textMusteriID
            // 
            this.textMusteriID.Location = new System.Drawing.Point(173, 74);
            this.textMusteriID.Name = "textMusteriID";
            this.textMusteriID.ReadOnly = true;
            this.textMusteriID.Size = new System.Drawing.Size(353, 33);
            this.textMusteriID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "MüşteriID";
            // 
            // textUrunID
            // 
            this.textUrunID.Location = new System.Drawing.Point(173, 17);
            this.textUrunID.Name = "textUrunID";
            this.textUrunID.ReadOnly = true;
            this.textUrunID.Size = new System.Drawing.Size(353, 33);
            this.textUrunID.TabIndex = 0;
            // 
            // SiparişID
            // 
            this.SiparişID.AutoSize = true;
            this.SiparişID.Location = new System.Drawing.Point(88, 22);
            this.SiparişID.Name = "SiparişID";
            this.SiparişID.Size = new System.Drawing.Size(79, 28);
            this.SiparişID.TabIndex = 27;
            this.SiparişID.Text = "UrunID";
            // 
            // buttonTamam
            // 
            this.buttonTamam.Location = new System.Drawing.Point(183, 419);
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
            this.buttonİptal.Location = new System.Drawing.Point(360, 419);
            this.buttonİptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonİptal.Name = "buttonİptal";
            this.buttonİptal.Size = new System.Drawing.Size(166, 40);
            this.buttonİptal.TabIndex = 6;
            this.buttonİptal.Text = "İptal";
            this.buttonİptal.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(353, 33);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textTeslimatAdresi
            // 
            this.textTeslimatAdresi.Location = new System.Drawing.Point(173, 263);
            this.textTeslimatAdresi.Multiline = true;
            this.textTeslimatAdresi.Name = "textTeslimatAdresi";
            this.textTeslimatAdresi.Size = new System.Drawing.Size(353, 138);
            this.textTeslimatAdresi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sipariş Tarihi";
            // 
            // comboBoxSiparisDurumu
            // 
            this.comboBoxSiparisDurumu.FormattingEnabled = true;
            this.comboBoxSiparisDurumu.Items.AddRange(new object[] {
            "Hazırlanıyor",
            "Teslim Edildi",
            "İptal Edildi"});
            this.comboBoxSiparisDurumu.Location = new System.Drawing.Point(173, 199);
            this.comboBoxSiparisDurumu.Name = "comboBoxSiparisDurumu";
            this.comboBoxSiparisDurumu.Size = new System.Drawing.Size(353, 36);
            this.comboBoxSiparisDurumu.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSiparis
            // 
            this.AcceptButton = this.buttonTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonİptal;
            this.ClientSize = new System.Drawing.Size(561, 484);
            this.Controls.Add(this.comboBoxSiparisDurumu);
            this.Controls.Add(this.textTeslimatAdresi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMusteriID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUrunID);
            this.Controls.Add(this.SiparişID);
            this.Controls.Add(this.buttonTamam);
            this.Controls.Add(this.buttonİptal);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSiparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSiparis";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMusteriID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUrunID;
        private System.Windows.Forms.Label SiparişID;
        private System.Windows.Forms.Button buttonTamam;
        private System.Windows.Forms.Button buttonİptal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textTeslimatAdresi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSiparisDurumu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}