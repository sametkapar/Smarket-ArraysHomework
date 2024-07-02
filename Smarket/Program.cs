using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = { "Domates", "Biber", "Soğan", "Yumurta", "Süt  ", "Ekmek" };
            double[] fiyatlar = { 48.5, 63, 9, 4.25, 38, 12 };
            string[] birimler = { "KG", "KG", "KG", "AD", "LT", "AD" };
            int[] urunsayac = new int[6];
            double[] aratoplam = new double[6];
            double geneltoplam = 0;

            Console.WriteLine(@"\\\\\\\\\ SMARKET /////////");
            Console.WriteLine("");
            Console.WriteLine("Alışveriş yapmak ve fiyat listesini görmek istiyor musunuz? E/H");
            string giris = Console.ReadLine();
            giris = giris.ToUpper();
            Console.Clear();
            bool devam = true;
            if (giris == "E")
            {

                while (devam == true)
                {
                    Console.WriteLine("*-*---Ürün Fiyat Listemiz---*-*");
                    Console.WriteLine("");
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ") " + urunler[i] + "\t1 " + birimler[i] + " : " + fiyatlar[i] + "\t TL");
                    }
                    Console.WriteLine("Almak istediğiniz ürün numarasını giriniz: ");
                    string urunno = Console.ReadLine();


                    if (urunno == "1")
                    {
                        urunsayac[0]++;
                        aratoplam[0] = urunsayac[0] * fiyatlar[0];
                        Console.WriteLine("--" + urunsayac[0] + " KİLOGRAM Domates alındı--");
                    }
                    else if (urunno == "2")
                    {
                        urunsayac[1]++;
                        aratoplam[1] = urunsayac[1] * fiyatlar[1];
                        Console.WriteLine("--" + urunsayac[1] + " KİLOGRAM Biber alındı--");

                    }
                    else if (urunno == "3")
                    {
                        urunsayac[2]++;
                        aratoplam[2] = urunsayac[2] * fiyatlar[2];
                        Console.WriteLine("--" + urunsayac[2] + " KİLOGRAM Soğan alındı--");
                    }
                    else if (urunno == "4")
                    {
                        urunsayac[3]++;
                        aratoplam[3] = urunsayac[3] * fiyatlar[3];
                        Console.WriteLine("--" + urunsayac[3] + " ADET Yumurta alındı--");
                    }
                    else if (urunno == "5")
                    {
                        urunsayac[4]++;
                        aratoplam[4] = urunsayac[4] * fiyatlar[4];
                        Console.WriteLine("--" + urunsayac[4] + " LİTRE Süt alındı--");
                    }
                    else if (urunno == "6")
                    {
                        urunsayac[5]++;
                        aratoplam[5] = urunsayac[5] * fiyatlar[5];
                        Console.WriteLine("--" + urunsayac[5] + " ADET Ekmek alındı--");
                    }


                    Console.WriteLine("Alışverişe devam etkmek istiyormusunuz=? E/H");
                    string cevap = Console.ReadLine();
                    cevap = cevap.ToUpper();
                    if (cevap == "E")
                    {
                        devam = true;
                    }
                    else
                    {
                        devam = false;
                    }
                    Console.Clear();
                }
                Console.WriteLine("**********TOPLAM ALDIKLARINIZ**********");
                for (int i = 0; i < aratoplam.Length; i++)
                {
                    Console.WriteLine(urunler[i] + "\t" + urunsayac[i] + " " + birimler[i] + ":\t" + aratoplam[i] + "\tTL");
                }
                for (int i = 0; i < aratoplam.Length; i++)
                {
                    geneltoplam = geneltoplam + aratoplam[i];
                }
                Console.WriteLine("**********TOPLAM ALDIKLARINIZ**********");
                Console.WriteLine(" ");
                Console.WriteLine("TOPLAM= " + geneltoplam + "\tTL");
                Console.WriteLine(" ");
                Console.WriteLine("SMARKET'İ TERCİH ETTİĞİNİZİ İÇİN TEŞEKKÜR EDERİZ.");
            }
            else
            {
                Console.WriteLine("YİNE BEKLER MİYİZ ??  o_O");
            }
        }
    }
}
