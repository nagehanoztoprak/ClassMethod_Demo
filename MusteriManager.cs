using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethod_Demo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine( musteri.Name + " adlı musteri eklendi. " );

        }


        public void Sil(Musteri musteri)
        {
            Console.WriteLine( musteri.Name + " adlı musteri silindi. " );

        }

    }
}
