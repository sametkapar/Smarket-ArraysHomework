using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepetliMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"\*\*\*\SMARTSEPETE HOŞGELDİNİZ/*/*/*/");
            Console.WriteLine(" ");
            Console.WriteLine("Alışveriş yapmak ve ürün listesini görmek için ENTER'a basınız... ");
            string giris = Console.ReadLine();
            string[] urunler = { "DOMATES", "SÜT  ", "EKMEK" };
            double[] fiyatlar = { 30.5, 27, 12 };
            string[] birimler = { "KG", "LT", "AD" };
            double[] tutar = new double[3];
            double[] miktarlar = new double[3];
            double geneltutar = 0;

            bool devam = true;
            if (giris == "")
            {
                while (devam == true)
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Ürün Fiyat Listemiz");
                    Console.WriteLine("-------------------");
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ") " + urunler[i] + "\t1 " + birimler[i] + " = " + fiyatlar[i] + "\tTL");
                    }
                   
                    Console.Write("\nLütfen almak istediğiniz ürün numarasını yazını: ");
                    string secim = Console.ReadLine();
                    Console.Clear();
                    if (secim == "1")
                    {
                        Console.WriteLine("Kaç " + birimler[0] + " " + urunler[0] + " almak istiyorsunuz?");
                        double miktar = Convert.ToDouble(Console.ReadLine());
                        tutar[0] += (miktar * fiyatlar[0]);
                        Console.Clear();
                        Console.WriteLine("Ürün Tutarınız: " + tutar[0] + " TL");
                        miktarlar[0] += miktar;
                    }
                    else if (secim == "2")
                    {
                        Console.WriteLine("Kaç " + birimler[1] + " " + urunler[1] + " almak istiyorsunuz?");
                        double miktar = Convert.ToDouble(Console.ReadLine());
                        tutar[1] += (miktar * fiyatlar[1]);
                        Console.Clear();
                        Console.WriteLine("Ürün Tutarınız: " + tutar[1] + " TL");
                        miktarlar[1] += miktar;
                    }
                    else if (secim == "3")
                    {
                        Console.WriteLine("Kaç " + birimler[2] + " " + urunler[2] + " almak istiyorsunuz?");
                        double miktar = Convert.ToDouble(Console.ReadLine());
                        tutar[2] += (miktar * fiyatlar[2]);
                        Console.Clear();
                        Console.WriteLine("Ürün Tutarınız: " + tutar[2] + " TL");
                        miktarlar[2] += miktar;

                    }
                    
                    Console.WriteLine("\n---------------------");
                    Console.WriteLine("Sepetteki Ürünleriniz");
                    Console.WriteLine("---------------------");
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ") " + miktarlar[i] + " " + birimler[i] + " " + urunler[i] + " = " + tutar[i] + " TL");
                    }

                    Console.WriteLine("\nAlışverişe devam etkmek istiyormusunuz=? E/H");
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
                for (int i = 0; i < tutar.Length; i++)
                {
                    geneltutar = geneltutar + tutar[i];
                }
                Console.WriteLine("TOPLAM SEPET TUTARINIZ: " + geneltutar + " TL'dir\n");

                Console.WriteLine("BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜR EDERİZ.");
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız");
            }
        }
    }
}
