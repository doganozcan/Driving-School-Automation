namespace SurucuKursuOtomasyonu
{
    partial class OdemeBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeBilgileri));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.LC_ID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtOdemeTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.cbOdemeTuru = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOdemeTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1183, 185);
            this.gridControl1.TabIndex = 40;
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
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(580, 193);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Mask.EditMask = "00000000000";
            this.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtID.Size = new System.Drawing.Size(150, 22);
            this.txtID.TabIndex = 42;
            // 
            // LC_ID
            // 
            this.LC_ID.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LC_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.LC_ID.Appearance.ForeColor = System.Drawing.Color.White;
            this.LC_ID.Appearance.Options.UseBackColor = true;
            this.LC_ID.Appearance.Options.UseFont = true;
            this.LC_ID.Appearance.Options.UseForeColor = true;
            this.LC_ID.Location = new System.Drawing.Point(507, 178);
            this.LC_ID.Margin = new System.Windows.Forms.Padding(4);
            this.LC_ID.Name = "LC_ID";
            this.LC_ID.Size = new System.Drawing.Size(38, 24);
            this.LC_ID.TabIndex = 41;
            this.LC_ID.Text = "ID :";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl14.Appearance.Options.UseBackColor = true;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(418, 228);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(133, 22);
            this.labelControl14.TabIndex = 54;
            this.labelControl14.Text = "Ödeme Tarihi :";
            // 
            // txtOdemeTutar
            // 
            this.txtOdemeTutar.Location = new System.Drawing.Point(582, 328);
            this.txtOdemeTutar.Name = "txtOdemeTutar";
            this.txtOdemeTutar.Size = new System.Drawing.Size(150, 22);
            this.txtOdemeTutar.TabIndex = 57;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Appearance.Options.UseBackColor = true;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(416, 315);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(135, 22);
            this.labelControl11.TabIndex = 56;
            this.labelControl11.Text = "Ödeme Tutarı :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(582, 399);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 46);
            this.simpleButton1.TabIndex = 72;
            this.simpleButton1.Text = "YATIR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(580, 241);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtTarih.Size = new System.Drawing.Size(150, 22);
            this.txtTarih.TabIndex = 73;
            // 
            // cbOdemeTuru
            // 
            this.cbOdemeTuru.EditValue = "";
            this.cbOdemeTuru.Location = new System.Drawing.Point(582, 287);
            this.cbOdemeTuru.Name = "cbOdemeTuru";
            this.cbOdemeTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOdemeTuru.Properties.NullText = "Ödeme Türü";
            this.cbOdemeTuru.Size = new System.Drawing.Size(150, 22);
            this.cbOdemeTuru.TabIndex = 81;
            this.cbOdemeTuru.EditValueChanged += new System.EventHandler(this.cbOdemeTuru_EditValueChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(438, 274);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(113, 22);
            this.labelControl12.TabIndex = 80;
            this.labelControl12.Text = "Ödeme Tipi :";
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.LC_ID);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Location = new System.Drawing.Point(-2, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1196, 556);
            this.panelControl1.TabIndex = 82;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(769, 270);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 24);
            this.labelControl1.TabIndex = 81;
            this.labelControl1.Text = "labelControl1";
            this.labelControl1.Visible = false;
            // 
            // OdemeBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1182, 434);
            this.Controls.Add(this.cbOdemeTuru);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtOdemeTutar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OdemeBilgileri";
            this.Text = "OdemeBilgileri";
            this.Load += new System.EventHandler(this.OdemeBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOdemeTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl LC_ID;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtOdemeTutar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.LookUpEdit cbOdemeTuru;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}