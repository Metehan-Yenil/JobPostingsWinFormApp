namespace İsilanlariWinForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KullanıcıGirisText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ParolaGirisText = new System.Windows.Forms.TextBox();
            this.personelGirisbtn = new System.Windows.Forms.Button();
            this.personelKayıtbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KullanıcıGirisText
            // 
            this.KullanıcıGirisText.Location = new System.Drawing.Point(206, 55);
            this.KullanıcıGirisText.Name = "KullanıcıGirisText";
            this.KullanıcıGirisText.Size = new System.Drawing.Size(172, 22);
            this.KullanıcıGirisText.TabIndex = 0;
            this.KullanıcıGirisText.TextChanged += new System.EventHandler(this.KullanıcıGirisText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // ParolaGirisText
            // 
            this.ParolaGirisText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ParolaGirisText.Location = new System.Drawing.Point(206, 97);
            this.ParolaGirisText.Name = "ParolaGirisText";
            this.ParolaGirisText.Size = new System.Drawing.Size(172, 22);
            this.ParolaGirisText.TabIndex = 3;
            this.ParolaGirisText.UseSystemPasswordChar = true;
            // 
            // personelGirisbtn
            // 
            this.personelGirisbtn.BackColor = System.Drawing.Color.GhostWhite;
            this.personelGirisbtn.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelGirisbtn.Location = new System.Drawing.Point(152, 166);
            this.personelGirisbtn.Name = "personelGirisbtn";
            this.personelGirisbtn.Size = new System.Drawing.Size(105, 30);
            this.personelGirisbtn.TabIndex = 4;
            this.personelGirisbtn.Text = "Giriş Yap";
            this.personelGirisbtn.UseVisualStyleBackColor = false;
            this.personelGirisbtn.Click += new System.EventHandler(this.personelGirisbtn_Click);
            // 
            // personelKayıtbtn
            // 
            this.personelKayıtbtn.BackColor = System.Drawing.Color.White;
            this.personelKayıtbtn.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelKayıtbtn.Location = new System.Drawing.Point(318, 166);
            this.personelKayıtbtn.Name = "personelKayıtbtn";
            this.personelKayıtbtn.Size = new System.Drawing.Size(105, 30);
            this.personelKayıtbtn.TabIndex = 5;
            this.personelKayıtbtn.Text = "Kayıt Ol";
            this.personelKayıtbtn.UseVisualStyleBackColor = false;
            this.personelKayıtbtn.Click += new System.EventHandler(this.personelKayıtbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 14);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(166, 24);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Giriş Yapınız";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.personelGirisbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.personelKayıtbtn);
            this.panel1.Controls.Add(this.ParolaGirisText);
            this.panel1.Controls.Add(this.KullanıcıGirisText);
            this.panel1.Location = new System.Drawing.Point(95, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 245);
            this.panel1.TabIndex = 8;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(143, 459);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(413, 16);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Copyright 2023 Jobseam All Right Reserved | Designed by Mete_ynl";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(695, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::İsilanlariWinForm.Properties.Resources.photo_1557682250_33bd709cbe85;
            this.ClientSize = new System.Drawing.Size(735, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KullanıcıGirisText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ParolaGirisText;
        private System.Windows.Forms.Button personelGirisbtn;
        private System.Windows.Forms.Button personelKayıtbtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

