using System;
using System.IO;

namespace split
{
    public class Kisi
    {
        private string adi;
        private string soyadi;
        private string tel;
        private string mail;

        public string Adi {get; set;}
        public string Soyadi {get; set;}
        public string Tel {get; set;}
        public string Mail {get; set;}

        public void Kaydet(string dosya)
        {
            FileStream fs = new FileStream(dosya, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"{Adi},{Soyadi},{Tel},{Mail},");
            sw.Close();
            Console.WriteLine();
            Console.WriteLine("Kaydetme basarı ile tamamlandi");
        }
       
}
}
