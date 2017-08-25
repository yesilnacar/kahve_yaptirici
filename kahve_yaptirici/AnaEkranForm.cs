﻿using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace kahve_yaptirici
{
    public partial class AnaEkranForm : Form
    {
        int kahveYaptirmaSayisi;

        #region Initialize Form

        public AnaEkranForm()
        {
            InitializeComponent();

            kisilerLb.Items.Clear();
            kisiAdiTb.Text = string.Empty;
            talihliLb.Text = string.Empty;
            elineSaglikLbl.Visible = false;

            tarihSaatLbl.Text = DateTime.Now.ToString();
        }

        #endregion Initialize Form

        #region Events

        private void KapatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kisiEkleBtn_Click(object sender, EventArgs e)
        {
            KisiEkle();
        }

        private void secBtn_Click(object sender, EventArgs e)
        {
            talihliLb.Text = string.Empty;
            sayiLbl.Text = string.Empty;
            kahveYaptirmaSayisi = 0;
            talihliLb.Text = string.Empty;

            KisiSec();
        }

        private void kisiAdiTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                KisiEkle();

            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            if (kisilerLb.Items.Count == 0)
                return;

            var kisilerList = kisilerLb.SelectedItems.Cast<string>().ToList();

            for (int i = 0; i < kisilerList.Count; i++)
                kisilerLb.Items.Remove(kisilerList[i]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarihSaatLbl.Text = DateTime.Now.ToString();
        }

        private void TemizleButton_Click(object sender, EventArgs e)
        {
            kisiAdiTb.Text = string.Empty;
            kisilerLb.Items.Clear();
            elineSaglikLbl.Visible = false;
            kahveYaptirmaSayisi = 0;
            sayiLbl.Text = string.Empty;
            talihliLb.Text = string.Empty;
        }

        #endregion Events

        #region Methods

        private void KisiEkle()
        {
            if (string.IsNullOrWhiteSpace(kisiAdiTb.Text))
                return;

            string adTemiz = RegexHelper.StringTemizle(kisiAdiTb.Text).ToUpper();

            if (!kisilerLb.Items.Contains(adTemiz))
            {
                kisilerLb.Items.Add(adTemiz);
                kisiAdiTb.Text = string.Empty;

                kahveYaptirmaSayisi = 0;
                sayiLbl.Text = string.Empty;
            }
            else
                kisiAdiTb.Text = string.Empty;
        }

        private void KisiSec()
        {
            if (kisilerLb.Items.Count > 0)
            {
                ListedekiIsimleriDondur();

                Guid id = Guid.NewGuid();
                int index = Math.Abs(id.GetHashCode()) % kisilerLb.Items.Count;
                talihliLb.Text = kisilerLb.Items[index].ToString() + " - " + DateTime.Now.ToLongTimeString();
            }
            else
                talihliLb.Text = "Liste boş olduğundan TAMER MEMİLİ yapacaktır.";

            talihliLb.ForeColor = Color.Red;
            elineSaglikLbl.Visible = true;
            elineSaglikLbl.Refresh();

            kahveYaptirmaSayisi++;
            sayiLbl.Text = kahveYaptirmaSayisi.ToString() + " defa butona basılmıştır.";

            DosyayaYaz(talihliLb.Text.Substring(0, talihliLb.Text.IndexOf('-')).Trim());
            MuzikCal();
        }

        private void ListedekiIsimleriDondur()
        {
            for (int i = 0; i < kisilerLb.Items.Count * 10; i++)
            {
                talihliLb.ForeColor = Color.Black;
                talihliLb.Text = kisilerLb.Items[i % kisilerLb.Items.Count].ToString();
                talihliLb.Refresh();

                int wait = 100;

                if (kisilerLb.Items.Count * 10 - i < 10)
                {
                    wait = 300;
                    if (kisilerLb.Items.Count * 10 - i < 5)
                    {
                        wait = 400;
                        if (kisilerLb.Items.Count * 10 - i < 3)
                            wait = 500;
                    }
                }

                System.Threading.Thread.Sleep(wait);
            }
        }

        private void MuzikCal()
        {
            SoundPlayer player = new SoundPlayer(Resources.KahveSesi);
            player.Play();
        }

        private void DosyayaYaz(string secilenKisi)
        {
            FileHelper.KlasorYarat();
            FileHelper.TextDosyaYoksaYarat();
            FileHelper.DosyayaYaz(secilenKisi);
        }

        #endregion Methods  
    }
}
