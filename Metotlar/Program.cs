using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyabakir Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            Console.WriteLine("------------------");
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }
            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);

            sepetManager.ekle2("Armut", "Deveci Armutu", 15, 10);
            sepetManager.ekle2("Elma", "Yesil Elma", 12, 7);
            sepetManager.ekle2("Karpuz", "Diyarbakir Karpuzu", 50, 5);
        }
    }
}
