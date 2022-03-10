namespace SurucuKursuOtomasyonu
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.txtYeniSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtSifreTekrar = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMevcutSifre = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbKontrol = new DevExpress.XtraEditors.LabelControl();
            this.txtSKTelefon = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSKAdres = new DevExpress.XtraEditors.MemoEdit();
            this.txtSKAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMevcutSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(219, 110);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(142, 22);
            this.txtYeniSifre.TabIndex = 1;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(219, 161);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(142, 22);
            this.txtSifreTekrar.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(219, 225);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(142, 42);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "GÜNCELLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(89, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Yeni Şifreniz :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mevcut Şifreniz :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(36, 162);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(177, 21);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Yeni Şifreniz Tekrar :";
            // 
            // txtMevcutSifre
            // 
            this.txtMevcutSifre.Location = new System.Drawing.Point(219, 58);
            this.txtMevcutSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtMevcutSifre.Name = "txtMevcutSifre";
            this.txtMevcutSifre.Properties.UseSystemPasswordChar = true;
            this.txtMevcutSifre.Size = new System.Drawing.Size(150, 22);
            this.txtMevcutSifre.TabIndex = 49;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lbKontrol);
            this.panelControl1.Controls.Add(this.txtSKTelefon);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.txtSKAdres);
            this.panelControl1.Controls.Add(this.txtSKAdi);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Location = new System.Drawing.Point(533, 36);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(478, 371);
            this.panelControl1.TabIndex = 3;
            // 
            // lbKontrol
            // 
            this.lbKontrol.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbKontrol.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbKontrol.Appearance.Options.UseFont = true;
            this.lbKontrol.Appearance.Options.UseForeColor = true;
            this.lbKontrol.Location = new System.Drawing.Point(35, 336);
            this.lbKontrol.Name = "lbKontrol";
            this.lbKontrol.Size = new System.Drawing.Size(418, 21);
            this.lbKontrol.TabIndex = 51;
            this.lbKontrol.Text = "Kullanıcı Türünüz Bilgileri Değiştirmeye Yetmiyor";
            this.lbKontrol.Visible = false;
            // 
            // txtSKTelefon
            // 
            this.txtSKTelefon.Location = new System.Drawing.Point(196, 225);
            this.txtSKTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSKTelefon.Name = "txtSKTelefon";
            this.txtSKTelefon.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtSKTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSKTelefon.Size = new System.Drawing.Size(150, 22);
            this.txtSKTelefon.TabIndex = 44;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(204, 274);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(142, 42);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "KAYDET";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtSKAdres
            // 
            this.txtSKAdres.Location = new System.Drawing.Point(196, 71);
            this.txtSKAdres.Name = "txtSKAdres";
            this.txtSKAdres.Size = new System.Drawing.Size(201, 131);
            this.txtSKAdres.TabIndex = 2;
            // 
            // txtSKAdi
            // 
            this.txtSKAdi.Location = new System.Drawing.Point(196, 22);
            this.txtSKAdi.Name = "txtSKAdi";
            this.txtSKAdi.Size = new System.Drawing.Size(142, 22);
            this.txtSKAdi.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(67, 224);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(104, 21);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Telefon No :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(111, 72);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 21);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Adres :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(159, 21);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Sürücü Kursu Adı :";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(342, 57);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(27, 23);
            this.pictureEdit1.TabIndex = 50;
            this.pictureEdit1.ToolTip = "Şifreyi Göster";
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            this.pictureEdit1.DoubleClick += new System.EventHandler(this.pictureEdit1_DoubleClick);
            // 
            // panelControl2
            // 
            this.panelControl2.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl2.ContentImage")));
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Controls.Add(this.txtMevcutSifre);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1221, 667);
            this.panelControl2.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(644, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(148, 21);
            this.labelControl7.TabIndex = 51;
            this.labelControl7.Text = "Sürücü Kursu Adı";
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 434);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMevcutSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSKAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtYeniSifre;
        private DevExpress.XtraEditors.TextEdit txtSifreTekrar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMevcutSifre;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbKontrol;
        private DevExpress.XtraEditors.TextEdit txtSKTelefon;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.MemoEdit txtSKAdres;
        private DevExpress.XtraEditors.TextEdit txtSKAdi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}