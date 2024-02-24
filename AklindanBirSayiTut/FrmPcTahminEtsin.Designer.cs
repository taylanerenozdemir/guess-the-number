namespace AklindanBirSayiTut
{
    partial class FrmPcTahminEtsin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPcTahminEtsin));
            this.lbl_tahminedilenSayi = new DevExpress.XtraEditors.LabelControl();
            this.btn_evet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_hayir = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tahminedilenSayi
            // 
            this.lbl_tahminedilenSayi.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tahminedilenSayi.Appearance.Options.UseFont = true;
            this.lbl_tahminedilenSayi.Appearance.Options.UseTextOptions = true;
            this.lbl_tahminedilenSayi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_tahminedilenSayi.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbl_tahminedilenSayi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_tahminedilenSayi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_tahminedilenSayi.Location = new System.Drawing.Point(0, 0);
            this.lbl_tahminedilenSayi.Name = "lbl_tahminedilenSayi";
            this.lbl_tahminedilenSayi.Size = new System.Drawing.Size(582, 85);
            this.lbl_tahminedilenSayi.TabIndex = 5;
            this.lbl_tahminedilenSayi.Text = "labelControl1";
            // 
            // btn_evet
            // 
            this.btn_evet.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_evet.Appearance.Options.UseFont = true;
            this.btn_evet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_evet.ImageOptions.Image")));
            this.btn_evet.Location = new System.Drawing.Point(172, 137);
            this.btn_evet.Name = "btn_evet";
            this.btn_evet.Size = new System.Drawing.Size(121, 49);
            this.btn_evet.TabIndex = 6;
            this.btn_evet.Text = "Evet";
            this.btn_evet.Click += new System.EventHandler(this.btn_evet_Click);
            // 
            // btn_hayir
            // 
            this.btn_hayir.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hayir.Appearance.Options.UseFont = true;
            this.btn_hayir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_hayir.ImageOptions.Image")));
            this.btn_hayir.Location = new System.Drawing.Point(299, 137);
            this.btn_hayir.Name = "btn_hayir";
            this.btn_hayir.Size = new System.Drawing.Size(121, 49);
            this.btn_hayir.TabIndex = 6;
            this.btn_hayir.Text = "Hayır";
            this.btn_hayir.Click += new System.EventHandler(this.btn_hayir_Click);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(0, 120);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(141, 119);
            this.listBoxControl1.TabIndex = 7;
            // 
            // FrmPcTahminEtsin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 238);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.btn_hayir);
            this.Controls.Add(this.btn_evet);
            this.Controls.Add(this.lbl_tahminedilenSayi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPcTahminEtsin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPcTahminEtsin";
            this.Load += new System.EventHandler(this.FrmPcTahminEtsin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_tahminedilenSayi;
        private DevExpress.XtraEditors.SimpleButton btn_evet;
        private DevExpress.XtraEditors.SimpleButton btn_hayir;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
    }
}