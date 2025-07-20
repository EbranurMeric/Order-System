namespace CicekciDukkani.UI
{
    partial class FormSiparisDetayi
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
            this.nmAdet = new System.Windows.Forms.NumericUpDown();
            this.nmBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSiparisID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDetayID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.buttonİptal = new System.Windows.Forms.Button();
            this.nmToplamFiyat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textUrunID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmAdet
            // 
            this.nmAdet.Location = new System.Drawing.Point(162, 340);
            this.nmAdet.Name = "nmAdet";
            this.nmAdet.Size = new System.Drawing.Size(353, 33);
            this.nmAdet.TabIndex = 5;
            this.nmAdet.ThousandsSeparator = true;
            // 
            // nmBirimFiyat
            // 
            this.nmBirimFiyat.DecimalPlaces = 2;
            this.nmBirimFiyat.Location = new System.Drawing.Point(162, 215);
            this.nmBirimFiyat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmBirimFiyat.Name = "nmBirimFiyat";
            this.nmBirimFiyat.Size = new System.Drawing.Size(353, 33);
            this.nmBirimFiyat.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Birim Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "UrunID";
            // 
            // textSiparisID
            // 
            this.textSiparisID.Location = new System.Drawing.Point(162, 91);
            this.textSiparisID.Name = "textSiparisID";
            this.textSiparisID.ReadOnly = true;
            this.textSiparisID.Size = new System.Drawing.Size(353, 33);
            this.textSiparisID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "SiparişID";
            // 
            // textDetayID
            // 
            this.textDetayID.Location = new System.Drawing.Point(162, 34);
            this.textDetayID.Name = "textDetayID";
            this.textDetayID.ReadOnly = true;
            this.textDetayID.Size = new System.Drawing.Size(353, 33);
            this.textDetayID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "DetayID";
            // 
            // buttonTamam
            // 
            this.buttonTamam.Location = new System.Drawing.Point(162, 407);
            this.buttonTamam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTamam.Name = "buttonTamam";
            this.buttonTamam.Size = new System.Drawing.Size(166, 40);
            this.buttonTamam.TabIndex = 6;
            this.buttonTamam.Text = "Tamam";
            this.buttonTamam.UseVisualStyleBackColor = true;
            this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
            // 
            // buttonİptal
            // 
            this.buttonİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonİptal.Location = new System.Drawing.Point(349, 407);
            this.buttonİptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonİptal.Name = "buttonİptal";
            this.buttonİptal.Size = new System.Drawing.Size(166, 40);
            this.buttonİptal.TabIndex = 7;
            this.buttonİptal.Text = "İptal";
            this.buttonİptal.UseVisualStyleBackColor = true;
            // 
            // nmToplamFiyat
            // 
            this.nmToplamFiyat.DecimalPlaces = 2;
            this.nmToplamFiyat.Location = new System.Drawing.Point(162, 281);
            this.nmToplamFiyat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmToplamFiyat.Name = "nmToplamFiyat";
            this.nmToplamFiyat.Size = new System.Drawing.Size(353, 33);
            this.nmToplamFiyat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Toplam Fiyat";
            // 
            // textUrunID
            // 
            this.textUrunID.Location = new System.Drawing.Point(162, 151);
            this.textUrunID.Name = "textUrunID";
            this.textUrunID.ReadOnly = true;
            this.textUrunID.Size = new System.Drawing.Size(353, 33);
            this.textUrunID.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSiparisDetayi
            // 
            this.AcceptButton = this.buttonTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonİptal;
            this.ClientSize = new System.Drawing.Size(562, 488);
            this.Controls.Add(this.nmToplamFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmAdet);
            this.Controls.Add(this.nmBirimFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUrunID);
            this.Controls.Add(this.textSiparisID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDetayID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTamam);
            this.Controls.Add(this.buttonİptal);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSiparisDetayi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSiparisDetayi";
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmAdet;
        private System.Windows.Forms.NumericUpDown nmBirimFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSiparisID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDetayID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTamam;
        private System.Windows.Forms.Button buttonİptal;
        private System.Windows.Forms.NumericUpDown nmToplamFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUrunID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}