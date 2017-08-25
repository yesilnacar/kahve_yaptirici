using System.Text.RegularExpressions;

namespace kahve_yaptirici
{
    public static class RegexHelper
    {
        /// <summary>
        /// Girilen metni sayılardan ve özel karakterlerden temizleyerek döndürür.
        /// </summary>
        public static string StringTemizle(string metin)
        {
            return Regex.Replace(metin, @"[^A-Z^a-z^şŞıİçÇöÖüÜĞğ\s]", string.Empty).Trim();
        }
    }
}
