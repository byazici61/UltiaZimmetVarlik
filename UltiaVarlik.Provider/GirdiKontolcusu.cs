using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UltiaVarlik.Provider
{
    public static class GirdiKontolcusu
    {


        /// <summary>
        /// //isim soyisim sayı girememez ve boş bırakılamaz. Eğer ad doğru formattaysa "True" değilse "False" döner.
        /// </summary>
        /// <param name="anneKizlikAd"></param>
        /// <param name="kisiAd"></param>
        /// <returns></returns>
        public static bool IsimKontrolEt(this string txtbox)
        {

            for (int i = 0; i < txtbox.Length; i++)
            {
                if (txtbox.Contains(" ") // Ad en az iki kelimeden oluştuğu için boşluk içermek zorunda ama bu boşluklar başta ve sonda olamaz.
                && !txtbox.EndsWith(" ")
                && !txtbox.StartsWith(" ")
                && (Char.IsLetter(txtbox[i]) || txtbox[i] == ' '))
                {
                    return true;
                }

            }
            return false;

        }


        /// <summary>
        /// Girilen string double mı diye kontorl eder. Double "True" değise "False"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool DoubleKontorlu(this string s)
        {
            foreach (char item in s)
            {
                if (!(Char.IsDigit(item) || item == ','))
                {
                    return false;
                }
            }
            return true;

        }


        /// <summary>
        /// parametreler(string) boş bu diye bakar. Değilse "True" döner
        /// </summary>
        /// <param name="texts"></param>
        /// <returns></returns>
        public static bool BosMu(params string[] texts)
        {
            foreach (var item in texts)
            {
                //boş ise girer
                if (item.Any(char.IsWhiteSpace) || string.IsNullOrWhiteSpace(item) || item.Length < 2)
                {
                    return false;
                }
            }
            //boş değil
            return true;
        }

        /// <summary>
        /// parametreler(string) rakam içeriyor mu  diye bakar. içermiyorsa "True" döner
        /// </summary>
        /// <param name="texts"></param>
        /// <returns></returns>
        public static bool SayiVarMi(params string[] texts)
        {
            foreach (var item in texts)
            {
                //sayi varsa girer
                if (item.Any(char.IsDigit))
                {
                    return false;
                }
            }
            //sayi yok
            return true;
        }

        /// <summary>
        /// e-mail kontrolü. Doğru formatta ise True döner
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool EmailKontrol(this string email)
        {
            //büyük küçük harfe duyarsız
            return Regex.IsMatch(email,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public static bool TelefonNoKontrol(this string telefonNo)
        {
            return Regex.IsMatch(telefonNo, @"^(5(\d{2})-(\d{3})-(\d{4}))$", RegexOptions.IgnoreCase);

        }


        public static bool TcKontrol(this string tc)
        {
            //return (tc.Length != 11 && tc.Substring(0, 1) != "0" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "3" && tc.Substring(10, 1) != "5" && tc.Substring(10, 1) != "7" && tc.Substring(10, 1) != "9")
            //	? true
            //	: false;
            #region uzun if

            if (tc.Length == 11 && tc.Substring(0, 1) != "0" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "3" && tc.Substring(10, 1) != "5" && tc.Substring(10, 1) != "7" && tc.Substring(10, 1) != "9")
            {
                return true;
            }
            return false;
            #endregion

        }



        /// <summary>
        /// Mail formata uygun mu kontorlü?
        /// </summary>
        /// <returns></returns>
        //public static bool MailKontrol(string mail)
        //{
        //    if (!string.IsNullOrWhiteSpace(mail)
        //        && mail.Contains('@')
        //        && mail.EndsWith(".com"))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return true;
        //    }


        //}


        #region Girdiler Bos Mu uzun kontol
        //public static bool GirdilerBosmuKontolu(string a, string b, string c, string d)
        //{
        //    if ((!string.IsNullOrWhiteSpace(a))
        //        && (!string.IsNullOrWhiteSpace(b)
        //        && (!string.IsNullOrWhiteSpace(d))
        //        && (!string.IsNullOrWhiteSpace(c))))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
        //public static bool GirdilerBosmuKontolu(string a, string b)
        //{
        //    if ((!string.IsNullOrWhiteSpace(a))
        //        && (!string.IsNullOrWhiteSpace(b)
        //        ))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
        //public static bool GirdilerBosmuKontolu(string a)
        //{
        //    if ((!string.IsNullOrWhiteSpace(a)))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
        //public static bool GirdilerBosmuKontolu(string a, string b, string c)
        //{
        //    if ((!string.IsNullOrWhiteSpace(a))
        //        && (!string.IsNullOrWhiteSpace(b)
        //        && (!string.IsNullOrWhiteSpace(c))
        //        ))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
        #endregion

        //public static bool RakamKontorlu(string s)
        //{
        //    foreach (char item in s)
        //    {
        //        if (Char.IsDigit(item))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;

        //}






    }
}
