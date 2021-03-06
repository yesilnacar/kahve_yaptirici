﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;

namespace kahve_yaptirici
{
    public static class FileHelper
    {
        public readonly static string DirectoryPath = @"\\10.35.107.107\network\KAHVE_YAPTIRICI"; //ConfigurationManager.AppSettings["DirectoryPath"].ToString();
        public readonly static string kahveYapanlarSabiti = "Kahve_Yapanlar_";
        public static string FileName = Path.Combine(DirectoryPath, kahveYapanlarSabiti + DateTime.Now.ToString("MMMM") + "_" + DateTime.Now.Year.ToString() + ".txt");
        
        public static void KlasorYarat()
        {
            if (!Directory.Exists(DirectoryPath))
                Directory.CreateDirectory(DirectoryPath);
        }

        public static void TextDosyaYoksaYarat()
        {
            KlasorYarat();

#if DEBUG
            FileName = Path.Combine(DirectoryPath, "Kahve_Yapanlar_TEST.txt");
#endif

            if (!File.Exists(FileName))
            {
                var myFile = File.Create(FileName);
                myFile.Close();
            }
        }

        public static string[] DosyaIcerigiOku()
        {
            KlasorYarat();

            if (File.Exists(FileName))
                return File.ReadAllLines(FileName);
            else
                return null;
        }

        public static string[] DosyaIcerigiOku(string istenenDosyaAdi)
        {
            string aranacakDosyaAdi = Path.Combine(DirectoryPath, kahveYapanlarSabiti + istenenDosyaAdi + ".txt");

            if (File.Exists(aranacakDosyaAdi))
                return File.ReadAllLines(aranacakDosyaAdi);
            else
                return null;
        }

        public static void DosyayaYaz(string secilenKisi)
        {
            if (!File.Exists(FileName))
                return;

            string degisecekSatir = string.Empty;
            string yeniSatir = string.Empty;
            bool streamSecilenKisiyiIceriyorMu = false;
            
            var eslesenList = DosyaIcerigiOku().AsEnumerable().Where(p => p.Contains(secilenKisi));

            if (eslesenList.Any())
            {
                degisecekSatir = eslesenList.ElementAtOrDefault(0);

                int sayi;
                int.TryParse(degisecekSatir.Substring(degisecekSatir.LastIndexOf(' '), degisecekSatir.Length - degisecekSatir.LastIndexOf(' ')).Trim(), out sayi);

                yeniSatir = secilenKisi + " - " + (sayi + 1).ToString();
                streamSecilenKisiyiIceriyorMu = true;
            }

            File.WriteAllLines(FileName, File.ReadLines(FileName).Where(p => p != degisecekSatir).ToList());

            if (yeniSatir == string.Empty && !streamSecilenKisiyiIceriyorMu)
                yeniSatir = secilenKisi + " - " + 1.ToString();

            File.AppendAllLines(FileName, new List<string> { yeniSatir });
        }

        public static DataTable DosyaIcerigiDataTableDondur()
        {
            string[] butunSatirlar = DosyaIcerigiOku();
            
            return DosyaIcerigiDataTableDondur(butunSatirlar);
        }

        public static DataTable DosyaIcerigiDataTableDondur(string[] icerik)
        {
            DataTable istatistikDt = new DataTable("IstatistikDt");
            istatistikDt.Columns.Add("Ad", typeof(string));
            istatistikDt.Columns.Add("Sayi", typeof(int));

            if (icerik == null)
                return istatistikDt;

            DataRow newRow;
            foreach (var satir in icerik)
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
