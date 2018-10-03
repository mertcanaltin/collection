namespace ryToplama2
{
    partial class toplamaForm
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
            this.lbSayi1 = new System.Windows.Forms.Label();
            this.lbSayi2 = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.tbSayi1 = new System.Windows.Forms.TextBox();
            this.tbSayi2 = new System.Windows.Forms.TextBox();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.matMenu = new System.Windows.Forms.MenuStrip();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.toplaBilgi = new System.Windows.Forms.ToolTip(this.components);
            this.matMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSayi1
            // 
            this.lbSayi1.AutoSize = true;
            this.lbSayi1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSayi1.Location = new System.Drawing.Point(34, 64);
            this.lbSayi1.Name = "lbSayi1";
            this.lbSayi1.Size = new System.Drawing.Size(51, 19);
            this.lbSayi1.TabIndex = 0;
            this.lbSayi1.Text = "1.sayı";
            this.lbSayi1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSayi2
            // 
            this.lbSayi2.AutoSize = true;
            this.lbSayi2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSayi2.Location = new System.Drawing.Point(158, 64);
            this.lbSayi2.Name = "lbSayi2";
            this.lbSayi2.Size = new System.Drawing.Size(51, 19);
            this.lbSayi2.TabIndex = 1;
            this.lbSayi2.Text = "2.sayı";
            this.lbSayi2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSonuc.Location = new System.Drawing.Point(321, 64);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(52, 19);
            this.lbSonuc.TabIndex = 2;
            this.lbSonuc.Text = "sonuc";
            this.lbSonuc.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbSayi1
            // 
            this.tbSayi1.Location = new System.Drawing.Point(12, 103);
            this.tbSayi1.MaxLength = 4;
            this.tbSayi1.Name = "tbSayi1";
            this.tbSayi1.Size = new System.Drawing.Size(100, 24);
            this.tbSayi1.TabIndex = 3;
            this.tbSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toplaBilgi.SetToolTip(this.tbSayi1, "Buraya 0 ile 9999 arasında bir değer giriniz\r\n\r\n");
            // 
            // tbSayi2
            // 
            this.tbSayi2.Location = new System.Drawing.Point(142, 103);
            this.tbSayi2.MaxLength = 4;
            this.tbSayi2.Name = "tbSayi2";
            this.tbSayi2.Size = new System.Drawing.Size(100, 24);
            this.tbSayi2.TabIndex = 4;
            this.toplaBilgi.SetToolTip(this.tbSayi2, "Buraya 0 ile 9999 arasında bir değer giriniz\r\n");
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(306, 105);
            this.tbSonuc.MaxLength = 5;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(100, 24);
            this.tbSonuc.TabIndex = 5;
            this.toplaBilgi.SetToolTip(this.tbSonuc, "Toplama işlemi sonucu");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(118, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTopla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTopla.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(248, 103);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(52, 27);
            this.btnTopla.TabIndex = 6;
            this.btnTopla.Text = "=";
            this.toplaBilgi.SetToolTip(this.btnTopla, "işlemi gerçekleştirmek için tıklayınız");
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // matMenu
            // 
            this.matMenu.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.matMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.matMenu.Location = new System.Drawing.Point(0, 0);
            this.matMenu.Name = "matMenu";
            this.matMenu.Size = new System.Drawing.Size(418, 25);
            this.matMenu.TabIndex = 7;
            this.matMenu.Text = "menuStrip1";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMenuItem,
            this.kapatMenuItem});
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.çıkışToolStripMenuItem.Text = "&Dosya";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // kapatMenuItem
            // 
            this.kapatMenuItem.Name = "kapatMenuItem";
            this.kapatMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatMenuItem.Text = "Çı&kış";
            this.kapatMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // yeniMenuItem
            // 
            this.yeniMenuItem.Name = "yeniMenuItem";
            this.yeniMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniMenuItem.Text = "&Yeni";
            this.yeniMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.ItemHeight = 16;
            this.lbListe.Location = new System.Drawing.Point(16, 148);
            this.lbListe.MultiColumn = true;
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(390, 148);
            this.lbListe.TabIndex = 8;
            this.toplaBilgi.SetToolTip(this.lbListe, "işlem listesi");
            // 
            // toplamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 305);
            this.ControlBox = false;
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.tbSayi2);
            this.Controls.Add(this.tbSayi1);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.lbSayi2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSayi1);
            this.Controls.Add(this.matMenu);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.matMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "toplamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merhaba Dünya";
            this.Load += new System.EventHandler(this.toplamaForm_Load);
            this.matMenu.ResumeLayout(false);
            this.matMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSayi1;
        private System.Windows.Forms.Label lbSayi2;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.TextBox tbSayi1;
        private System.Windows.Forms.TextBox tbSayi2;
        private System.Windows.Forms.TextBox tbSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.MenuStrip matMenu;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMenuItem;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.ToolTip toplaBilgi;
    }
}

