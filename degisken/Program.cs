using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger =2;
            string degisken = " "; 
            Console.WriteLine(deger);
            byte b = 5; // 0 - 255 arası değer alır  1 byte yer kaplar
            sbyte c = 3; // -128, 127 arasında değer alır 1 byte yer kaplar
            short s = 5; // 2 byte yer kaplar. -32768, +32768
            ushort ss = 5; // 2byte yer kaplar. 0 - 65365

            Int16 i16 = 2; // 2 byte yer kaplar. 
            int i = 2; // 4 byte yer kaplar.
            Int32 e = 5; // 4byte yer kaplar. 
            Int64 i64 = 3; // 8 byte yer kaplar.
            uint u2 = 4; // 4 byte yer kaplar.
            long l = 4; // 8 byte yer kaplar. 
            ulong ll= 3; //- değer alamaz.


            float d = 2; // 4 byte yer kaplar. 
            double dd = 22; //8 byte yer kaplar.
            decimal dec = 11; // 16 byte yer kaplar. 

            char cc = '2'; // 2 byte
            string str = "Metin"; //sınırsız

            bool bl = true;
            bool bll = false; 

            DateTime dt = DateTime.Now; //tarih saati tutar.
                Console.WriteLine(dt);

                Object o1 = "x"; // string
                Object o2 = 'y'; // char
                Object o3 = 4; // string
                Object o4 = 4.3; //decimal

                // string 
                
                string str1 = string.Empty;
                str1 = "Gökhan Çüryan";
                string ad = "Gökhan";
                string soyad = "Çüryan";
                string tamisim = ad +" "+ soyad;
                    Console.WriteLine(tamisim);

                // int

                int int1 = 5;
                int int2 = 3; 
                int int3 = int1 * int2;

                /// boolean 

                bool bool1 = 10 > 2;  //true 

                // Degişken Donusumleri

                string str20 = "20";
                int int20 = 20;

                string yeniDeger = str20 + int20.ToString();
                Console.WriteLine(yeniDeger);

                int int21 = int20 + Convert.ToInt32(str20);
                Console.WriteLine(int21);

                int int22 = int20 + int.Parse(str20);

                string datetime = DateTime.Now.ToString("dd.MM.yyyy");
                Console.WriteLine(datetime);

        }
    }
}