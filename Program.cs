using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ahmet,mehmet,orhan,sami";
            string[] strDizi = str.Split(",");
            for (int i = 0; i < strDizi.Length; i++)
                Console.WriteLine(strDizi[i]);
        }
    }
}
