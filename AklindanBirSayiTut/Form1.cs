using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AklindanBirSayiTut
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_benTahminEdeyim_Click(object sender, EventArgs e)
        {
            FrmBenTahminEdeyim frm2 = new FrmBenTahminEdeyim(Convert.ToInt32(txt_min.Text), Convert.ToInt32(txt_max.Text));
            frm2.ShowDialog();
        }

        private void txt_pcTahminEtsin_Click(object sender, EventArgs e)
        {
            FrmPcTahminEtsin pc = new FrmPcTahminEtsin(Convert.ToInt32(txt_min.Text), Convert.ToInt32(txt_max.Text));
            pc.ShowDialog();
        }
    }
}
