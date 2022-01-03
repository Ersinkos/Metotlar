using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
       public void ekle(Urun urun)
       {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urun.Adi);
       }
       public void ekle2(string urunAdi,string aciklama,double fiyati,int stokAdedi)
       {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urunAdi);
       }
    }
}
