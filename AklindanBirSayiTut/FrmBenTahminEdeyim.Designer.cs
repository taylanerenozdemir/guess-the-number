namespace AklindanBirSayiTut
{
    partial class FrmBenTahminEdeyim
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
            this.txt_tahmin = new DevExpress.XtraEditors.TextEdit();
            this.lbl_bildirim = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tahmin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tahmin
            // 
            this.txt_tahmin.Location = new System.Drawing.Point(12, 46);
            this.txt_tahmin.Name = "txt_tahmin";
            this.txt_tahmin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tahmin.Properties.Appearance.Options.UseFont = true;
            this.txt_tahmin.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_tahmin.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txt_tahmin.Properties.MaskSettings.Set("mask", "n0");
            this.txt_tahmin.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.txt_tahmin.Size = new System.Drawing.Size(440, 48);
            this.txt_tahmin.TabIndex = 3;
            this.txt_tahmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tahmin_KeyDown);
            // 
            // lbl_bildirim
            // 
            this.lbl_bildirim.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bildirim.Appearance.Options.UseFont = true;
            this.lbl_bildirim.Appearance.Options.UseTextOptions = true;
            this.lbl_bildirim.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_bildirim.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbl_bildirim.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_bildirim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_bildirim.Location = new System.Drawing.Point(0, 120);
            this.lbl_bildirim.Name = "lbl_bildirim";
            this.lbl_bildirim.Size = new System.Drawing.Size(464, 53);
            this.lbl_bildirim.TabIndex = 4;
            this.lbl_bildirim.Text = "labelControl1";
            // 
            // FrmBenTahminEdeyim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 173);
            this.Controls.Add(this.lbl_bildirim);
            this.Controls.Add(this.txt_tahmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBenTahminEdeyim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBenTahminEdeyim";
            ((System.ComponentModel.ISupportInitialize)(this.txt_tahmin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_tahmin;
        private DevExpress.XtraEditors.LabelControl lbl_bildirim;
    }
}