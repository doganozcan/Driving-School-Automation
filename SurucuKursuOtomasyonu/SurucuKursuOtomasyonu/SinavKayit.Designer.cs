namespace SurucuKursuOtomasyonu
{
    partial class SinavKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavKayit));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbSinavSaati = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LC_sinavTuru = new DevExpress.XtraEditors.LabelControl();
            this.txtSinavTarihi = new DevExpress.XtraEditors.DateEdit();
            this.cbSinavTuru = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbSinavSaati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinavTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinavTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSinavTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(188, 432);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 46);
            this.simpleButton1.TabIndex = 38;
            this.simpleButton1.Text = "KAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbSinavSaati
            // 
            this.cbSinavSaati.Location = new System.Drawing.Point(284, 377);
            this.cbSinavSaati.Name = "cbSinavSaati";
            this.cbSinavSaati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSinavSaati.Properties.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cbSinavSaati.Size = new System.Drawing.Size(138, 22);
            this.cbSinavSaati.TabIndex = 37;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(126, 373);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 24);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Sınav Saati :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(120, 328);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 24);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Sınav Tarihi :";
            // 
            // LC_sinavTuru
            // 
            this.LC_sinavTuru.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LC_sinavTuru.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.LC_sinavTuru.Appearance.ForeColor = System.Drawing.Color.White;
            this.LC_sinavTuru.Appearance.Options.UseBackColor = true;
            this.LC_sinavTuru.Appearance.Options.UseFont = true;
            this.LC_sinavTuru.Appearance.Options.UseForeColor = true;
            this.LC_sinavTuru.Location = new System.Drawing.Point(130, 275);
            this.LC_sinavTuru.Margin = new System.Windows.Forms.Padding(4);
            this.LC_sinavTuru.Name = "LC_sinavTuru";
            this.LC_sinavTuru.Size = new System.Drawing.Size(122, 24);
            this.LC_sinavTuru.TabIndex = 33;
            this.LC_sinavTuru.Text = "Sınav Türü :";
            // 
            // txtSinavTarihi
            // 
            this.txtSinavTarihi.EditValue = null;
            this.txtSinavTarihi.Location = new System.Drawing.Point(284, 330);
            this.txtSinavTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSinavTarihi.Name = "txtSinavTarihi";
            this.txtSinavTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSinavTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSinavTarihi.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtSinavTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSinavTarihi.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtSinavTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSinavTarihi.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtSinavTarihi.Size = new System.Drawing.Size(138, 22);
            this.txtSinavTarihi.TabIndex = 72;
            // 
            // cbSinavTuru
            // 
            this.cbSinavTuru.EditValue = "";
            this.cbSinavTuru.Location = new System.Drawing.Point(284, 279);
            this.cbSinavTuru.Name = "cbSinavTuru";
            this.cbSinavTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSinavTuru.Properties.NullText = "Sınav Türü Seç";
            this.cbSinavTuru.Size = new System.Drawing.Size(138, 22);
            this.cbSinavTuru.TabIndex = 73;
            this.cbSinavTuru.EditValueChanged += new System.EventHandler(this.cbSinavTuru_EditValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.btnGuncelle);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.txtSinavTarihi);
            this.panelControl1.Controls.Add(this.cbSinavSaati);
            this.panelControl1.Controls.Add(this.cbSinavTuru);
            this.panelControl1.Controls.Add(this.LC_sinavTuru);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(1, -111);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1212, 631);
            this.panelControl1.TabIndex = 76;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(317, 151);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(111, 16);
            this.labelControl4.TabIndex = 100;
            this.labelControl4.Text = "SINAV ID KONTROL";
            this.labelControl4.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSil.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnSil.AppearanceHovered.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnSil.AppearanceHovered.Options.UseBackColor = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(830, 487);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 46);
            this.btnSil.TabIndex = 99;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(797, 123);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(372, 355);
            this.gridControl1.TabIndex = 76;
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
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.AppearanceHovered.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnGuncelle.AppearanceHovered.Options.UseBackColor = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(1030, 487);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 46);
            this.btnGuncelle.TabIndex = 98;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(317, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(131, 16);
            this.labelControl2.TabIndex = 75;
            this.labelControl2.Text = "SINAV TÜRÜ KONTROL";
            this.labelControl2.Visible = false;
            // 
            // SinavKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1182, 434);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SinavKayit";
            this.Text = "SinavKayit";
            this.Load += new System.EventHandler(this.SinavKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbSinavSaati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinavTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinavTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSinavTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cbSinavSaati;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl LC_sinavTuru;
        private DevExpress.XtraEditors.DateEdit txtSinavTarihi;
        private DevExpress.XtraEditors.LookUpEdit cbSinavTuru;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}