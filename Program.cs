using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Ahmet,Bayat,05363662323,a.bayat@hotmail.com";
            string[] strDizi = str.Split(",");

            for (int i = 0; i < strDizi.Length; i++)
                Console.WriteLine(strDizi[i]);

            Kisi kisi = new Kisi();

            for (int i = 0; i < strDizi.Length; i++)
            {
                kisi.Adi = strDizi[0];
                kisi.Soyadi = strDizi[1];
                kisi.Tel = strDizi[2];
                kisi.Mail = strDizi[3];
            }

            Console.WriteLine();

            Console.WriteLine("Adi    :" + kisi.Adi);
            Console.WriteLine("Soyadi :" + kisi.Soyadi);
            Console.WriteLine("Tel    :" + kisi.Tel);
            Console.WriteLine("Mail   :" + kisi.Mail);

            kisi.Kaydet("MyText.txt");

        }
    }
}
