namespace SurucuKursuOtomasyonu
{
    partial class Odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtOdemeTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tarih = new DevExpress.XtraEditors.DateEdit();
            this.cbEhliyetSinifi = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxDonem = new DevExpress.XtraEditors.LookUpEdit();
            this.txtOdenecekMiktar = new DevExpress.XtraEditors.LookUpEdit();
            this.cbOdemeTuru = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEhliyetSinifi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDonem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdenecekMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOdemeTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(368, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(609, 463);
            this.gridControl1.TabIndex = 39;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(123, 425);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(177, 46);
            this.simpleButton1.TabIndex = 55;
            this.simpleButton1.Text = "KAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtOdemeTutar
            // 
            this.txtOdemeTutar.Location = new System.Drawing.Point(188, 311);
            this.txtOdemeTutar.Name = "txtOdemeTutar";
            this.txtOdemeTutar.Properties.Mask.EditMask = "d";
            this.txtOdemeTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOdemeTutar.Size = new System.Drawing.Size(146, 22);
            this.txtOdemeTutar.TabIndex = 51;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(121, 441);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(113, 22);
            this.labelControl12.TabIndex = 43;
            this.labelControl12.Text = "Ödeme Tipi :";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl14.Appearance.Options.UseBackColor = true;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(108, 542);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(133, 22);
            this.labelControl14.TabIndex = 44;
            this.labelControl14.Text = "Ödeme Tarihi :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Appearance.Options.UseBackColor = true;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(105, 497);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(135, 22);
            this.labelControl11.TabIndex = 45;
            this.labelControl11.Text = "Ödeme Tutarı :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl10.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl10.Appearance.Options.UseBackColor = true;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(157, 398);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(77, 22);
            this.labelControl10.TabIndex = 46;
            this.labelControl10.Text = "Dönem :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.Options.UseBackColor = true;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(82, 357);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(166, 22);
            this.labelControl9.TabIndex = 47;
            this.labelControl9.Text = "Ödenecek Miktar :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseBackColor = true;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(117, 313);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(123, 22);
            this.labelControl8.TabIndex = 48;
            this.labelControl8.Text = "Ehliyet Sınıfı :";
            // 
            // tarih
            // 
            this.tarih.EditValue = null;
            this.tarih.Location = new System.Drawing.Point(188, 354);
            this.tarih.Margin = new System.Windows.Forms.Padding(4);
            this.tarih.Name = "tarih";
            this.tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.tarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tarih.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.tarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tarih.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.tarih.Size = new System.Drawing.Size(146, 22);
            this.tarih.TabIndex = 72;
            // 
            // cbEhliyetSinifi
            // 
            this.cbEhliyetSinifi.EditValue = "";
            this.cbEhliyetSinifi.Location = new System.Drawing.Point(192, 127);
            this.cbEhliyetSinifi.Name = "cbEhliyetSinifi";
            this.cbEhliyetSinifi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEhliyetSinifi.Properties.NullText = "Ehliyet Sınıfı Seç";
            this.cbEhliyetSinifi.Size = new System.Drawing.Size(143, 22);
            this.cbEhliyetSinifi.TabIndex = 75;
            this.cbEhliyetSinifi.EditValueChanged += new System.EventHandler(this.cbEhliyetSinifi_EditValueChanged);
            // 
            // cbxDonem
            // 
            this.cbxDonem.EditValue = "";
            this.cbxDonem.Location = new System.Drawing.Point(188, 206);
            this.cbxDonem.Name = "cbxDonem";
            this.cbxDonem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDonem.Properties.NullText = "Dönem Seçiniz";
            this.cbxDonem.Size = new System.Drawing.Size(146, 22);
            this.cbxDonem.TabIndex = 76;
            this.cbxDonem.EditValueChanged += new System.EventHandler(this.cbxDonem_EditValueChanged);
            // 
            // txtOdenecekMiktar
            // 
            this.txtOdenecekMiktar.EditValue = "";
            this.txtOdenecekMiktar.Location = new System.Drawing.Point(192, 171);
            this.txtOdenecekMiktar.Name = "txtOdenecekMiktar";
            this.txtOdenecekMiktar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtOdenecekMiktar.Properties.NullText = "Ödenecek Miktar";
            this.txtOdenecekMiktar.Size = new System.Drawing.Size(143, 22);
            this.txtOdenecekMiktar.TabIndex = 78;
            // 
            // cbOdemeTuru
            // 
            this.cbOdemeTuru.EditValue = "";
            this.cbOdemeTuru.Location = new System.Drawing.Point(192, 253);
            this.cbOdemeTuru.Name = "cbOdemeTuru";
            this.cbOdemeTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOdemeTuru.Properties.NullText = "Ödeme Türü";
            this.cbOdemeTuru.Size = new System.Drawing.Size(142, 22);
            this.cbOdemeTuru.TabIndex = 79;
            this.cbOdemeTuru.EditValueChanged += new System.EventHandler(this.cbOdemeTuru_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(189, 224);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 22);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "ID  :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(110, 267);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 22);
            this.labelControl2.TabIndex = 47;
            this.labelControl2.Text = "Adı Ve Soyadı:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(192, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 22);
            this.txtID.TabIndex = 80;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Location = new System.Drawing.Point(192, 75);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(142, 22);
            this.txtAdSoyad.TabIndex = 81;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(142, 403);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(116, 16);
            this.labelControl3.TabIndex = 82;
            this.labelControl3.Text = "Ödeme Türü Kontrol";
            this.labelControl3.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Location = new System.Drawing.Point(-64, -188);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2859, 1000);
            this.panelControl1.TabIndex = 83;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(328, 591);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 16);
            this.labelControl5.TabIndex = 50;
            this.labelControl5.Text = "Dönem Kontrol";
            this.labelControl5.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Location = new System.Drawing.Point(87, 591);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(113, 16);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Ehliyet Sınıfı Kontrol";
            this.labelControl4.Visible = false;
            // 
            // Odeme
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 650);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbOdemeTuru);
            this.Controls.Add(this.txtOdenecekMiktar);
            this.Controls.Add(this.cbxDonem);
            this.Controls.Add(this.cbEhliyetSinifi);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtOdemeTutar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Odeme";
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEhliyetSinifi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDonem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdenecekMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOdemeTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtOdemeTutar;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit tarih;
        private DevExpress.XtraEditors.LookUpEdit cbEhliyetSinifi;
        private DevExpress.XtraEditors.LookUpEdit cbxDonem;
        private DevExpress.XtraEditors.LookUpEdit txtOdenecekMiktar;
        private DevExpress.XtraEditors.LookUpEdit cbOdemeTuru;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}