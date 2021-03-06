using System;

namespace ClassMethod_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 65467;
            musteri1.Name = " Steven ";
            musteri1.TelNo = 5386471588;
            musteri1.BirthPlace = "Yalova";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 85469;
            musteri2.Name = " Sara";
            musteri2.TelNo = 5478415487;
            musteri2.BirthPlace = "İzmir";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 74581;
            musteri3.Name = "Ganny";
            musteri3.TelNo = 5487523654;
            musteri3.BirthPlace = "Antalya";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 78315;
            musteri4.Name = "Noah";
            musteri4.TelNo = 2583694581;
            musteri4.BirthPlace = "Samsun";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.Ekle(musteri1);
            musteriEkle.Ekle(musteri2);
            musteriEkle.Ekle(musteri3);
            musteriEkle.Ekle(musteri4);

            Console.WriteLine( "-----------------------------------" );

            MusteriManager musteriSil = new MusteriManager();
            musteriSil.Sil(musteri1);
            musteriSil.Sil(musteri2);
            musteriSil.Sil(musteri3);
            musteriSil.Sil(musteri4);

            Console.WriteLine( "-----------------------------------" );


            Console.WriteLine( " Musteri Listesi : " );


            foreach (var musteriList in musteriler)
            {
                Console.WriteLine( musteriList.Name + " -- " + musteriList.TelNo + " -- " + musteriList.BirthPlace + " -- " + musteriList.Id );

            }
        }
    }
}

