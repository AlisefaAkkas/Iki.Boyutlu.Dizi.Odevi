using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki.Boyutlu.Dizi.Odevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UYARI! SATIR SAYISINI BİRKAÇ DEFA, DiĞER DEĞERLERİ DE 2 VEYA 3 DEFA GİRMENİZ GEREKEBİLİR!");
            Console.WriteLine("Satır sayısı giriniz");
            byte satir = byte.Parse(Console.ReadLine());
            string[,] ogrenciler = new string[satir + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ortalama";
            ogrenciler[0, 5] = "Harf Notu";





            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());

            string harf1 = Console.ReadLine();
            string harf2 = Console.ReadLine();




            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("Öğrenci adı giriniz:");

                            break;
                        case 1:
                            Console.WriteLine("Öğrenci soyadı giriniz:");
                            break;
                        case 2:
                            Console.WriteLine("Vize notu giriniz:");
                            sayi1 = int.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Final notu giriniz:");
                            sayi2 = int.Parse(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Ortalamanız:" + Ortalama(sayi1, sayi2));
                            //Ortalama(sayi1, sayi2);
                            break;
                        case 5:
                            Console.WriteLine("Harf Notunuz:" + Harf(harf1, harf2));

                            break;
                        default:
                            break;
                    }
                    ogrenciler[i, j] = Console.ReadLine();


                }
            }

            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }


        static int Ortalama(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * 40 / 100 + sayi2 * 60 / 100;

            return sonuc;





        }
        static int Harf(string harf1, string harf2)
        {
            int sonuc = int.Parse(Console.ReadLine());
            return sonuc;


            if (sonuc <= 100)
            {
                Console.WriteLine("AA");
            }
            else if (sonuc >= 89)
            {
                Console.WriteLine("BA");
            }
            else if (sonuc >= 79)
            {
                Console.WriteLine("BB");
            }
            else if (sonuc >= 69)
            {
                Console.WriteLine("CB");
            }
            else if (sonuc >= 59)
            {
                Console.WriteLine("CC");
            }
            else if (sonuc >= 49)
            {
                Console.WriteLine("DC");
            }
            else if (sonuc >= 39)
            {
                Console.WriteLine("DD");
            }
            else if (sonuc >= 30)
            {
                Console.WriteLine("FD");
            }
            else if (sonuc >= 24)
            {
                Console.WriteLine("FF");
            }
            else
            {
                Console.WriteLine("Dersi geçtiniz.");
            }


        }


    }
}


























