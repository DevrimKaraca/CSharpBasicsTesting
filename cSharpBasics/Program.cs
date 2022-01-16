using System;
using System.Collections.Generic;

namespace cSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim-belirleyici_VarsaKeyword_geriDönüşTipi_Methodİsmi

            //Parametresiz methodlar(Parametre almaz),Parametreli methodlar(parametre Alır),
            //Geri Dönüşlü(object), Geri Dönüşsüz(void)

            //HepBunuYazarımKonsola();

            //string yazmakIstedigimSey1 = "nurgulYazmakİstedi.";
            //string yazmakIstedigimSey2 = "devrimYazmakİstedi.";
            //BenBirKonsolaSeninIstediginiYazanMethodum(yazmakIstedigimSey1);
            //BenBirKonsolaSeninIstediginiYazanMethodum(yazmakIstedigimSey2);

            //string bunuSoylemekIstiyorum = "Nurgul";
            //string yazdinmi = KonsolaBunuYaz(bunuSoylemekIstiyorum,5);
            //Karsilastir(yazdinmi);

            for (int i = 0; i < 150; i++)
            {
                string x1 = YaşınıSöyleSanaNeOlduğunuSöyleyeyim(i);
            }
        }

        /// <summary>
        /// asdfasdf
        /// </summary>
        private static void HepBunuYazarımKonsola()
        {
            Console.WriteLine("Hep Bunu Yazarım.");
        }

        private static void BenBirKonsolaSeninIstediginiYazanMethodum(string senNeYazdırmakIstersin)
        {
            Console.WriteLine(senNeYazdırmakIstersin);
        }

        private static string KonsolaBunuYaz(string senNeYazdırmakIstersin, int kacKereYazdırmakIstersin)
        {
            string mesaj = "";
            for (int i = 0; i < kacKereYazdırmakIstersin; i++)
            {
                Console.WriteLine(senNeYazdırmakIstersin);
                if (kacKereYazdırmakIstersin >= 10) { mesaj = "RamDoldu"; }
                if (kacKereYazdırmakIstersin >= 100) { mesaj = "BittikMkCpuDondu"; break; }
            }
            return mesaj;
        }

        private static void Karsilastir(string yazdimidiyegelensonuc)
        {
            if (yazdimidiyegelensonuc == "Yazdım")
            {
                Console.WriteLine("Yazmış.");
            }
            else
            {
                Console.WriteLine("Yazmamış.");
            }
        }

        /// <summary>
        /// 2022 de geçerli olarak gördüğümüz x bir insanın Yaş Durumu
        /// </summary>
        enum İnsanYaşDurumu
        {
            Genç = 40,
            OrtaYaşlı = 60,
            Yaşlı = 80
        }

        private static string YaşınıSöyleSanaNeOlduğunuSöyleyeyim(int yas)
        {
            //Intelisense otomatik kod tamamlama, Resharper Ram çok kullanır ama kullanışlı.
            //Kodu Düzeltmeye Refactor denir.
            //Magic Numberlardan Kurtul,Magic string,Enum Kullanabilirsin.
            //Validasyon,
            //SOLİD daha sonra bak, Single Responsibility
            //Linkedin online eğitimler,instagram hashtag, akbankın eğitimi varmı? google,
            //Sahibinden.com,trendyol.com,...
            //breakpoint=stop ediyo kodu orda (Debug etmek)
            //int gunumuzdekiGencBirInsanınYaşı = 20;//Kod tekrarı yapmak zorunda bıraktı. 
            //int gunumuzdekiYasliBirInsanınYaşı = 50;

            string sonuc = "";

            if (yas <= (int)İnsanYaşDurumu.Genç)
            {
                sonuc = İnsanYaşDurumu.Genç.ToString();
            }
            else if (yas > (int)İnsanYaşDurumu.Genç && yas < (int)İnsanYaşDurumu.Yaşlı)
            {
                sonuc = İnsanYaşDurumu.OrtaYaşlı.ToString();
            }
            else if (yas >= (int)İnsanYaşDurumu.Yaşlı)
            {
                sonuc = İnsanYaşDurumu.Yaşlı.ToString();
            }

            return sonuc;
        }
        private static string YaşınıSöyleSanaNeIbneSöyleyeyim()
        {
            int gunumuzdekiGencBirInsanınYaşı = (int)İnsanYaşDurumu.Genç;
            return "";
        }
    }
}
