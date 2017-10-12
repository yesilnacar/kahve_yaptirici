using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace kahve_yaptirici
{
    public partial class AnaEkranForm : Form
    {
        int kahveYaptirmaSayisi;
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        int selectedItemIndex;
        string selectedItem = string.Empty;
        bool kisiSecildiMi;

        #region Initialize Form

        public AnaEkranForm()
        {
            InitializeComponent();

            kisilerLb.Items.Clear();
            kisiAdiTb.Text = string.Empty;
            talihliLb.Text = string.Empty;
            elineSaglikLbl.Visible = false;

            top5Lbl.Text = "KAHVE KRALLIĞI TOP 5" + " - " + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year.ToString();
            tarihSaatLbl.Text = DateTime.Now.ToString();
            LeaderboardOlustur();
            GecenAyKraliAdDondur();
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

        private void leaderboardLb_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            Brush brush = Brushes.Black;
            Font font = new Font("Calibri", 9, FontStyle.Bold);
            
            switch (e.Index)
            {
                case 0:
                    brush = Brushes.Red;
                    font = new Font("Calibri", 9, FontStyle.Bold);
                    break;
                default:
                    break;
            }

            e.Graphics.DrawString(leaderboardLb.Items[e.Index].ToString(), font, brush, e.Bounds);
        }

        private void TickerTimer_Tick(object sender, EventArgs e)
        {
            if (leaderboardLb.Items.Count == 0 || !kisiSecildiMi || selectedItemIndex > leaderboardLb.Items.Count || string.IsNullOrWhiteSpace(selectedItem))
                return;

            if (string.IsNullOrWhiteSpace(leaderboardLb.Items[selectedItemIndex].ToString()))
                leaderboardLb.Items[selectedItemIndex] = selectedItem;
            else
                leaderboardLb.Items[selectedItemIndex] = string.Empty;
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
            if (kisilerLb.Items.Count == 0)
                return;

            ListedekiIsimleriDondur();

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];
                rng.GetBytes(uintBuffer);

                uint num = BitConverter.ToUInt32(uintBuffer, 0);
                int index = Convert.ToInt32(Math.Abs(num) % kisilerLb.Items.Count);

                talihliLb.Text = kisilerLb.Items[index].ToString() + " - " + DateTime.Now.ToLongTimeString();

                talihliLb.ForeColor = Color.Red;
                elineSaglikLbl.Visible = true;
                elineSaglikLbl.Refresh();

                kahveYaptirmaSayisi++;
                sayiLbl.Text = kahveYaptirmaSayisi.ToString() + " defa butona basılmıştır.";

                DosyayaYaz(talihliLb.Text.Substring(0, talihliLb.Text.IndexOf('-')).Trim());
                MuzikCal();
                LeaderboardOlustur();
                SecilenKisiLeaderboarddaVarMi(kisilerLb.Items[index].ToString());

                kisiSecildiMi = true;
            }
        }

        private void SecilenKisiLeaderboarddaVarMi(string secilenKisi)
        {
            if (leaderboardLb.Items.Cast<string>().AsEnumerable().Any(p => p.Contains(secilenKisi)))
            {
                selectedItem = leaderboardLb.Items.Cast<string>().AsEnumerable().Where(p => p.Contains(secilenKisi)).Select(p => p).FirstOrDefault();
                selectedItemIndex = leaderboardLb.Items.IndexOf(selectedItem);
            }
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

        private void LeaderboardOlustur()
        {
            leaderboardLb.Items.Clear();
            DataTable icerikDt = FileHelper.DosyaIcerigiDataTableDondur();

            if (icerikDt.Rows.Count == 0)
                return;

            var top5RowList = (from dt in icerikDt.AsEnumerable()
                               orderby (int)dt["Sayi"] descending
                               select dt).Take(5);

            var maxNameLength = (from dt in icerikDt.AsEnumerable()
                                 orderby ((string)dt["Ad"]).Length descending
                                 select ((string)dt["Ad"]).Length).FirstOrDefault();

            var maxCountLength = (from dt in icerikDt.AsEnumerable()
                                  orderby Convert.ToString(dt["Sayi"]).Length descending
                                  select Convert.ToString(dt["Sayi"]).Length).FirstOrDefault();

            int index = 1;
            foreach (var row in top5RowList)
            {
                int starCount = Convert.ToInt32(row["Sayi"]) / 5;

                string satir = index.ToString() + ".  " + ((string)row["Ad"]).PadRight(maxNameLength, ' ') + " - " + Convert.ToString(row["Sayi"]).PadLeft(maxCountLength, ' ') + "  " + new string('*', starCount);
                leaderboardLb.Items.Add(satir);

                index++;
            }

            //firstItem = leaderboardLb.Items[0].ToString();
        }

        private void GecenAyKraliAdDondur()
        {
            string isim = DateTime.Now.AddMonths(-1).ToString("MMMM") + "_" + DateTime.Now.AddMonths(-1).Year;

            string[] gecmisDosyaIcerigi = FileHelper.DosyaIcerigiOku(isim);

            if (gecmisDosyaIcerigi == null)
                GecenAyKraliAdLbl.Text = string.Empty;
            else
            {
                DataTable icerikDt = FileHelper.DosyaIcerigiDataTableDondur(gecmisDosyaIcerigi);

                if (icerikDt.Rows.Count == 0)
                    GecenAyKraliAdLbl.Text = string.Empty;
                else
                {
                    var topRow = (from dt in icerikDt.AsEnumerable()
                                  orderby (int)dt["Sayi"] descending
                                  select dt).Take(1).FirstOrDefault();

                    GecenAyKraliAdLbl.Text = ">> " + (string)topRow["Ad"] + " - " + topRow["Sayi"].ToString() + " <<";
                }
            }
        }

        #region Override Methods

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    {
                        base.WndProc(ref m);
                        if ((int)m.Result == HTCLIENT)
                            m.Result = (IntPtr)HTCAPTION;

                        return;
                    }
            }

            base.WndProc(ref m);
        }

        #endregion Override Methods

        #endregion Methods
    }
}
