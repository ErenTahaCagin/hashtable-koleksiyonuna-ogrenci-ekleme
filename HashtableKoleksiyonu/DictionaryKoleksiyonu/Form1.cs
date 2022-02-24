using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DictionaryKoleksiyonu
{
    public partial class Form1 : Form
    {
        Hashtable ogrenciler = new Hashtable();
        private int anahtar;
        private string deger;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(txtOkulNo.Text);
            deger = txtAdSoyad.Text;
            ogrenciler.Add(anahtar,deger);
            Listele();
        }

        private void Listele()
        {
            lbOgrenciler.Items.Clear();

            foreach (DictionaryEntry ogrenci in ogrenciler)
            {
                lbOgrenciler.Items.Add(ogrenci.Key + " - " + ogrenci.Value);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(txtOkulNo.Text);
            deger = txtAdSoyad.Text;
            ogrenciler[anahtar] = deger;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(txtOkulNo.Text);
            ogrenciler.Remove(anahtar);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = false;

            if (txtOkulNo.Text != "")
            {
                anahtar = int.Parse(txtOkulNo.Text);
                durum = ogrenciler.ContainsKey(anahtar);
            }
            else
            {
                deger = txtAdSoyad.Text;
                durum = ogrenciler.ContainsValue(deger);
            }

            if (durum == true)
            {
                MessageBox.Show("Öğrenci Kayıtlıdır.");
            }
            else
            {
                MessageBox.Show("Öğrenci Kayıtlı Değildir.");
            }
        }
    }
}
