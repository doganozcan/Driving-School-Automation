namespace SurucuKursuOtomasyonu
{
    partial class DireksiyonDersi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DireksiyonDersi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.tarih = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.btnKaydet);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.tarih);
            this.panelControl1.Controls.Add(this.txtTutar);
            this.panelControl1.Controls.Add(this.txtID);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(-68, -1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1282, 648);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(80, 196);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kursiyer ID :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(132, 241);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tutar :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(85, 289);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 21);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ders Tarihi :";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(206, 195);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(206, 242);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Mask.EditMask = "d";
            this.txtTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTutar.Size = new System.Drawing.Size(125, 22);
            this.txtTutar.TabIndex = 1;
            // 
            // tarih
            // 
            this.tarih.EditValue = null;
            this.tarih.Location = new System.Drawing.Point(206, 290);
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
            this.tarih.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.tarih.Size = new System.Drawing.Size(125, 22);
            this.tarih.TabIndex = 73;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(68, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1183, 177);
            this.gridControl1.TabIndex = 74;
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
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnKaydet.AppearanceHovered.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.btnKaydet.AppearanceHovered.Options.UseBackColor = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(213, 359);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 41);
            this.btnKaydet.TabIndex = 46;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // DireksiyonDersi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 434);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DireksiyonDersi";
            this.Text = "DireksiyonDersi";
            this.Load += new System.EventHandler(this.DireksiyonDersi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit tarih;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}