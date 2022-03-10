namespace SurucuKursuOtomasyonu
{
    partial class sifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifremiUnuttum));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTc = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Turquoise;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(155, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mail Adresiniz :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(196, 64);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(151, 22);
            this.txtMail.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(178, 115);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(169, 43);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Mail Gönder";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 210);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "labelControl2";
            this.labelControl2.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Turquoise;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(164, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "T.C :";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(197, 29);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.Name = "txtTc";
            this.txtTc.Properties.Mask.EditMask = "00000000000";
            this.txtTc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTc.Size = new System.Drawing.Size(150, 22);
            this.txtTc.TabIndex = 37;
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(-25, -7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(580, 334);
            this.panelControl1.TabIndex = 38;
            // 
            // sifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 269);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "sifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.sifremiUnuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}