namespace CicekciDukkani.UI
{
    partial class FormMusteri
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
            this.buttonİptal = new System.Windows.Forms.Button();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textİSİM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSOYİSİM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textEPOSTA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textADRES = new System.Windows.Forms.TextBox();
            this.maskedTextTEL = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonİptal
            // 
            this.buttonİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonİptal.Location = new System.Drawing.Point(332, 493);
            this.buttonİptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonİptal.Name = "buttonİptal";
            this.buttonİptal.Size = new System.Drawing.Size(166, 40);
            this.buttonİptal.TabIndex = 7;
            this.buttonİptal.Text = "İptal";
            this.buttonİptal.UseVisualStyleBackColor = true;
            // 
            // buttonTamam
            // 
            this.buttonTamam.Location = new System.Drawing.Point(145, 493);
            this.buttonTamam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTamam.Name = "buttonTamam";
            this.buttonTamam.Size = new System.Drawing.Size(166, 40);
            this.buttonTamam.TabIndex = 6;
            this.buttonTamam.Text = "Tamam";
            this.buttonTamam.UseVisualStyleBackColor = true;
            this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "MusteriID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(145, 28);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(353, 33);
            this.textID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim";
            // 
            // textİSİM
            // 
            this.textİSİM.Location = new System.Drawing.Point(145, 87);
            this.textİSİM.Name = "textİSİM";
            this.textİSİM.Size = new System.Drawing.Size(353, 33);
            this.textİSİM.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyisim";
            // 
            // textSOYİSİM
            // 
            this.textSOYİSİM.Location = new System.Drawing.Point(145, 143);
            this.textSOYİSİM.Name = "textSOYİSİM";
            this.textSOYİSİM.Size = new System.Drawing.Size(353, 33);
            this.textSOYİSİM.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Eposta";
            // 
            // textEPOSTA
            // 
            this.textEPOSTA.Location = new System.Drawing.Point(145, 251);
            this.textEPOSTA.Name = "textEPOSTA";
            this.textEPOSTA.Size = new System.Drawing.Size(353, 33);
            this.textEPOSTA.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adres";
            // 
            // textADRES
            // 
            this.textADRES.Location = new System.Drawing.Point(145, 304);
            this.textADRES.Multiline = true;
            this.textADRES.Name = "textADRES";
            this.textADRES.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textADRES.Size = new System.Drawing.Size(353, 180);
            this.textADRES.TabIndex = 5;
            // 
            // maskedTextTEL
            // 
            this.maskedTextTEL.Location = new System.Drawing.Point(145, 202);
            this.maskedTextTEL.Mask = "\\0(599) 000-0000";
            this.maskedTextTEL.Name = "maskedTextTEL";
            this.maskedTextTEL.Size = new System.Drawing.Size(353, 33);
            this.maskedTextTEL.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMusteri
            // 
            this.AcceptButton = this.buttonTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonİptal;
            this.ClientSize = new System.Drawing.Size(570, 557);
            this.Controls.Add(this.maskedTextTEL);
            this.Controls.Add(this.textADRES);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textEPOSTA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSOYİSİM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textİSİM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTamam);
            this.Controls.Add(this.buttonİptal);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonİptal;
        private System.Windows.Forms.Button buttonTamam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textİSİM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSOYİSİM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEPOSTA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textADRES;
        private System.Windows.Forms.MaskedTextBox maskedTextTEL;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}