namespace CicekciDukkani
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMusteriEkle = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriSil = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnMusteriBul = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteriler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürünler";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(3, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMusteriEkle,
            this.btnMusteriDuzenle,
            this.btnMusteriSil,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.btnMusteriBul});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.Image")));
            this.btnMusteriEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(60, 28);
            this.btnMusteriEkle.Text = "Ekle";
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriDuzenle.Image")));
            this.btnMusteriDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(87, 28);
            this.btnMusteriDuzenle.Text = "Düzenle";
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriSil.Image")));
            this.btnMusteriSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(49, 28);
            this.btnMusteriSil.Text = "Sil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 362);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 28);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMusteriBul.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriBul.Image")));
            this.btnMusteriBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(29, 28);
            this.btnMusteriBul.Text = "Bul";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.Text = "Çiçekçi Dükkanı";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnMusteriEkle;
        private System.Windows.Forms.ToolStripButton btnMusteriDuzenle;
        private System.Windows.Forms.ToolStripButton btnMusteriSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton btnMusteriBul;
    }
}

