using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AklindanBirSayiTut
{

    public partial class FrmPcTahminEtsin : DevExpress.XtraEditors.XtraForm
    {
        private int tahminedilen;
        Random rnd = new Random();

        public FrmPcTahminEtsin(int min, int max)
        {
            InitializeComponent();
            for (int i = min; i <=max; i++)
            {
                listBoxControl1.Items.Add(i);
            }
            TahminEt();
        }

        private void TahminEt()
        {
            if (listBoxControl1.ItemCount == 0)
            {
                lbl_tahminedilenSayi.Text = "Tahmin Edebileceğim Sayı Kalmadı";
                return;
            }
            tahminedilen = rnd.Next(0, listBoxControl1.ItemCount-1);
            lbl_tahminedilenSayi.Text = listBoxControl1.Items[tahminedilen].ToString();
        }

        private void FrmPcTahminEtsin_Load(object sender, EventArgs e)
        {

        }

        private void btn_hayir_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.ItemCount == 0)
            {
                return;
            }
            listBoxControl1.Items.Remove(listBoxControl1.Items[tahminedilen]);
            TahminEt();
        }

        private void btn_evet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler! Kazandın.");
            this.Close();
        }

        
    }
}