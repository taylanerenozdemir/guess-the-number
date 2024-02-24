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
//ReSharper disable all

namespace AklindanBirSayiTut
{
    public partial class FrmBenTahminEdeyim : DevExpress.XtraEditors.XtraForm
    {
        private int tahminet;
        Random rnd = new Random();

        private string[] Mesajlar =
        {
            "Olmadı", "Bir Daha Dene", "Lütfen Tekrar Deneyin", "Ben Bu Sayıyı Tutmamıştım",
            "Bu Kadar Basit Bir Sayı Tutacağımı mı Sandın?"
        };
        public FrmBenTahminEdeyim(int min,int max)
        {
            InitializeComponent();
            tahminet = rnd.Next(min,max);
            lbl_bildirim.Text = $"Senin İçin Aklımdan {min} ile {max} Arasında Bir Sayı Tuttum.Bakalım Bulabilecek misin.";
        }

        private void txt_tahmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_tahmin.Text==tahminet.ToString())
                {
                    MessageBox.Show("Tebrikler! Kazandın ");
                    this.Close();
                }
                else
                {
                    lbl_bildirim.Text = Mesajlar[rnd.Next(0, 3)];
                    txt_tahmin.Text = null;
                    txt_tahmin.Focus();
                }
            }
        }
    }
}