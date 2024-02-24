namespace AklindanBirSayiTut
{
    partial class Form1
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
            this.btn_benTahminEdeyim = new DevExpress.XtraEditors.SimpleButton();
            this.txt_pcTahminEtsin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_min = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_max = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_min.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_max.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_benTahminEdeyim
            // 
            this.btn_benTahminEdeyim.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_benTahminEdeyim.Appearance.Options.UseFont = true;
            this.btn_benTahminEdeyim.Appearance.Options.UseTextOptions = true;
            this.btn_benTahminEdeyim.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btn_benTahminEdeyim.Location = new System.Drawing.Point(12, 96);
            this.btn_benTahminEdeyim.Name = "btn_benTahminEdeyim";
            this.btn_benTahminEdeyim.Size = new System.Drawing.Size(222, 158);
            this.btn_benTahminEdeyim.TabIndex = 0;
            this.btn_benTahminEdeyim.Text = "Ben Tahmin Edeyim";
            this.btn_benTahminEdeyim.Click += new System.EventHandler(this.btn_benTahminEdeyim_Click);
            // 
            // txt_pcTahminEtsin
            // 
            this.txt_pcTahminEtsin.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pcTahminEtsin.Appearance.Options.UseFont = true;
            this.txt_pcTahminEtsin.Appearance.Options.UseTextOptions = true;
            this.txt_pcTahminEtsin.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.txt_pcTahminEtsin.Location = new System.Drawing.Point(283, 96);
            this.txt_pcTahminEtsin.Name = "txt_pcTahminEtsin";
            this.txt_pcTahminEtsin.Size = new System.Drawing.Size(222, 158);
            this.txt_pcTahminEtsin.TabIndex = 0;
            this.txt_pcTahminEtsin.Text = "Bilgisayar Tahmin Etsin";
            this.txt_pcTahminEtsin.Click += new System.EventHandler(this.txt_pcTahminEtsin_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(517, 47);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Aklından Bir Sayı Tut Oyunu";
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(12, 261);
            this.txt_min.Name = "txt_min";
            this.txt_min.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_min.Properties.Appearance.Options.UseFont = true;
            this.txt_min.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_min.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txt_min.Properties.MaskSettings.Set("mask", "n0");
            this.txt_min.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.txt_min.Size = new System.Drawing.Size(222, 48);
            this.txt_min.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(240, 272);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 33);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "İle";
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(283, 261);
            this.txt_max.Name = "txt_max";
            this.txt_max.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_max.Properties.Appearance.Options.UseFont = true;
            this.txt_max.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_max.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txt_max.Properties.MaskSettings.Set("mask", "n0");
            this.txt_max.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.txt_max.Size = new System.Drawing.Size(222, 48);
            this.txt_max.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 355);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_pcTahminEtsin);
            this.Controls.Add(this.btn_benTahminEdeyim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txt_min.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_max.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_benTahminEdeyim;
        private DevExpress.XtraEditors.SimpleButton txt_pcTahminEtsin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_min;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_max;
    }
}

