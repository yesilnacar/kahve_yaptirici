using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;

namespace kahve_yaptirici
{
    public static class FileHelper
    {
        public readonly static string DirectoryPath = ConfigurationManager.AppSettings["DirectoryPath"].ToString();
        public readonly static string FileName = Path.Combine(DirectoryPath, "Kahve_Yapanlar.txt");

        public static void KlasorYarat()
        {
            if (!Directory.Exists(DirectoryPath))
                Directory.CreateDirectory(DirectoryPath);
        }

        public static void TextDosyaYoksaYarat()
        {
            if (!File.Exists(FileName))
            {
                var myFile = File.Create(FileName);
                myFile.Close();
            }
        }

        public static string[] DosyaIcerigiOku()
        {
            return File.ReadAllLines(FileName);
        }

        public static void DosyayaYaz(string secilenKisi)
        {
            if (!File.Exists(FileName))
                return;

            string degisecekSatir = string.Empty;
            string yeniSatir = string.Empty;
            bool streamSecilenKisiyiIceriyorMu = false;

            string[] butunSatirlar = DosyaIcerigiOku();

            foreach (var satir in butunSatirlar)
            {
                if (satir.Contains(secilenKisi))
                {
                    degisecekSatir = satir;

                    int sayi;
                    int.TryParse(satir.Substring(satir.LastIndexOf(' '), satir.Length - satir.LastIndexOf(' ')).Trim(), out sayi);

                    yeniSatir = secilenKisi + " - " + (sayi + 1).ToString();
                    streamSecilenKisiyiIceriyorMu = true;

                    break;
                }
            }

            File.WriteAllLines(FileName, File.ReadLines(FileName).Where(p => p != degisecekSatir).ToList());

            if (yeniSatir == string.Empty && !streamSecilenKisiyiIceriyorMu)
                yeniSatir = secilenKisi + " - " + 1.ToString();

            File.AppendAllLines(FileName, new List<string> { yeniSatir });
        }

        public static DataTable DosyaIcerigiDataTableDondur()
        {
            string[] butunSatirlar = DosyaIcerigiOku();

            DataTable istatistikDt = new DataTable("IstatistikDt");
            istatistikDt.Columns.Add("Ad", typeof(string));
            istatistikDt.Columns.Add("Sayi", typeof(int));

            DataRow newRow;
            foreach (var satir in butunSatirlar)
            {
                var bilgi = satir.Split('-').ToList();

                newRow = istatistikDt.NewRow();
                newRow["Ad"] = bilgi[0].Trim();

                int sayi = 0;
                int.TryParse(bilgi[1].Trim(), out sayi);
                newRow["Sayi"] = sayi;

                istatistikDt.Rows.Add(newRow);
            }

            istatistikDt.AcceptChanges();

            return istatistikDt;
        }
    }
}
