namespace İsilanlariWinForm
{
    partial class kayıtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayıtForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.telnoTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.kayıtolButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.emailTextbox3 = new Bunifu.Framework.UI.BunifuTextbox();
            this.sifreTextbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.kullaniciadiTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrchid;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(804, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuCheckbox1);
            this.panel1.Controls.Add(this.telnoTextbox1);
            this.panel1.Controls.Add(this.kayıtolButton21);
            this.panel1.Controls.Add(this.emailTextbox3);
            this.panel1.Controls.Add(this.sifreTextbox2);
            this.panel1.Controls.Add(this.kullaniciadiTextbox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(211, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 420);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sözleşmeyi okudum ve kabul ediyorum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(61, 323);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 17;
            // 
            // telnoTextbox1
            // 
            this.telnoTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.telnoTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("telnoTextbox1.BackgroundImage")));
            this.telnoTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.telnoTextbox1.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telnoTextbox1.ForeColor = System.Drawing.Color.Navy;
            this.telnoTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("telnoTextbox1.Icon")));
            this.telnoTextbox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.telnoTextbox1.Location = new System.Drawing.Point(75, 198);
            this.telnoTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telnoTextbox1.Name = "telnoTextbox1";
            this.telnoTextbox1.Size = new System.Drawing.Size(283, 42);
            this.telnoTextbox1.TabIndex = 16;
            this.telnoTextbox1.text = "Telefon No";
            this.telnoTextbox1.OnTextChange += new System.EventHandler(this.telnoTextbox1_OnTextChange);
            // 
            // kayıtolButton21
            // 
            this.kayıtolButton21.ActiveBorderThickness = 1;
            this.kayıtolButton21.ActiveCornerRadius = 20;
            this.kayıtolButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.kayıtolButton21.ActiveForecolor = System.Drawing.Color.White;
            this.kayıtolButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.kayıtolButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kayıtolButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kayıtolButton21.BackgroundImage")));
            this.kayıtolButton21.ButtonText = "Kayıt Ol";
            this.kayıtolButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayıtolButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayıtolButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.kayıtolButton21.IdleBorderThickness = 1;
            this.kayıtolButton21.IdleCornerRadius = 20;
            this.kayıtolButton21.IdleFillColor = System.Drawing.Color.White;
            this.kayıtolButton21.IdleForecolor = System.Drawing.Color.Navy;
            this.kayıtolButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.kayıtolButton21.Location = new System.Drawing.Point(72, 358);
            this.kayıtolButton21.Margin = new System.Windows.Forms.Padding(5);
            this.kayıtolButton21.Name = "kayıtolButton21";
            this.kayıtolButton21.Size = new System.Drawing.Size(269, 44);
            this.kayıtolButton21.TabIndex = 15;
            this.kayıtolButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kayıtolButton21.Click += new System.EventHandler(this.kayıtolButton21_Click);
            // 
            // emailTextbox3
            // 
            this.emailTextbox3.AccessibleDescription = "";
            this.emailTextbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.emailTextbox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailTextbox3.BackgroundImage")));
            this.emailTextbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emailTextbox3.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTextbox3.ForeColor = System.Drawing.Color.Navy;
            this.emailTextbox3.Icon = ((System.Drawing.Image)(resources.GetObject("emailTextbox3.Icon")));
            this.emailTextbox3.Location = new System.Drawing.Point(49, 259);
            this.emailTextbox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextbox3.Name = "emailTextbox3";
            this.emailTextbox3.Size = new System.Drawing.Size(330, 42);
            this.emailTextbox3.TabIndex = 14;
            this.emailTextbox3.text = "Email";
            this.emailTextbox3.OnTextChange += new System.EventHandler(this.emailTextbox3_OnTextChange);
            // 
            // sifreTextbox2
            // 
            this.sifreTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sifreTextbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sifreTextbox2.BackgroundImage")));
            this.sifreTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sifreTextbox2.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTextbox2.ForeColor = System.Drawing.Color.Navy;
            this.sifreTextbox2.Icon = ((System.Drawing.Image)(resources.GetObject("sifreTextbox2.Icon")));
            this.sifreTextbox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sifreTextbox2.Location = new System.Drawing.Point(75, 135);
            this.sifreTextbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifreTextbox2.Name = "sifreTextbox2";
            this.sifreTextbox2.Size = new System.Drawing.Size(283, 42);
            this.sifreTextbox2.TabIndex = 13;
            this.sifreTextbox2.text = "Şifre";
            this.sifreTextbox2.OnTextChange += new System.EventHandler(this.sifreTextbox2_OnTextChange);
            // 
            // kullaniciadiTextbox1
            // 
            this.kullaniciadiTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kullaniciadiTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kullaniciadiTextbox1.BackgroundImage")));
            this.kullaniciadiTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kullaniciadiTextbox1.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadiTextbox1.ForeColor = System.Drawing.Color.Navy;
            this.kullaniciadiTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("kullaniciadiTextbox1.Icon")));
            this.kullaniciadiTextbox1.Location = new System.Drawing.Point(75, 75);
            this.kullaniciadiTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciadiTextbox1.Name = "kullaniciadiTextbox1";
            this.kullaniciadiTextbox1.Size = new System.Drawing.Size(283, 42);
            this.kullaniciadiTextbox1.TabIndex = 12;
            this.kullaniciadiTextbox1.text = "Kullanıcı Adı";
            this.kullaniciadiTextbox1.OnTextChange += new System.EventHandler(this.kullaniciadiTextbox1_OnTextChange);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(167, 35);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(89, 20);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Kayıt Ol";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::İsilanlariWinForm.Properties.Resources.photo_1557682250_33bd709cbe85;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(865, 563);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // kayıtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 540);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kayıtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayıtForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTextbox kullaniciadiTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox emailTextbox3;
        private Bunifu.Framework.UI.BunifuTextbox sifreTextbox2;
        private Bunifu.Framework.UI.BunifuThinButton2 kayıtolButton21;
        private Bunifu.Framework.UI.BunifuTextbox telnoTextbox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}