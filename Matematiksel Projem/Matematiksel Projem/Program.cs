using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematiksel_Projem
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayı1, sayı2;
            double sonuc;
            string islem;

            Console.Write("1. Sayıyı Giriniz: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz:  ");
            sayı2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yapmak İstedginiz İşlemin Sembölünü veya adını Girin: ");
            islem = Console.ReadLine();

            if (islem=="+" || islem=="toplam" || islem=="Toplam")
            {
                sonuc = sayı1 + sayı2;
                Console.WriteLine("Girdiginiz Sayıların Toplamı: " + sonuc);
            }
            if (islem=="-" || islem=="fark" || islem=="Fark")
            {
                sonuc = sayı1 - sayı2;
                Console.WriteLine("Girdiginiz sayılar Arasındaki Fark: " + sonuc);
            }
            if (islem=="*" || islem=="çarpım" || islem=="Çarpım")
            {
                sonuc = sayı1 * sayı2;
                Console.WriteLine("Girdiginiz sayıların çarpımı: " + sonuc);
            }
            if (islem=="/" || islem=="Bölüm" || islem=="bölüm")
            {
                sonuc = sayı1 / sayı2;
                Console.WriteLine("Girdiginiz sayıların Bölümü: " + sonuc);
            }
            if (islem=="//" || islem=="Ort" || islem=="Ortalama")
            {
                sonuc = (sayı1 + sayı2) / 2;
                Console.WriteLine("Girdiginiz sayıların ortalaması: " + sonuc);
            }
            Console.ReadKey();
        }
    }
}
