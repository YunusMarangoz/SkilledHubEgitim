namespace Konu12KalitimInheritance
{
    internal class Program
    {
        class Arac
        {
            public string AracTuru;
            public void kornaCAL()
            {
                Console.WriteLine("Kornaya Basıldı!");
            }
        }
        class Otomobil:Arac//iki nokta üst üste dedeğimizde araç sınıfındaki içerikler otomobil sınıfında kullanılabilir.
        {
            public string Marka { get; set; }
            public string Model { get; set; }
        }
        class Yat : Arac
        {
            public int Uzunluk { get; set; }
            public int Kamara { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Konu12 Kalitim Inheritance!");
            Arac  arac= new Arac();
            arac.AracTuru = "Araba";
            Console.WriteLine("arac.AracTuru= "+arac.AracTuru);

            Otomobil otomobil= new Otomobil();
            otomobil.AracTuru = "Otomobil";//Normalde Otomobil clasında AracTuru yok

            otomobil.Marka = "TOG";
            otomobil.Model = "TX100";
            Console.WriteLine("otomobil.AracTuru : "+ otomobil.AracTuru);
            otomobil.kornaCAL();//KornaCal metodu bir üst sınıf olan Araç sınıfından geliyor
            Console.WriteLine();

            Kategori kategori = new()
            { 
                Name="Elektronik",
                UstMenudeGoster=true,
                CreatDate=DateTime.Now
            };
            if (kategori.UstMenudeGoster==true)
            {
                Console.WriteLine($"Kategori Bilgileri :\n Adı : {kategori.Name} - Eklenme Tarihi : {kategori.CreatDate}");
            }
            Console.WriteLine();
            Urun urun = new()
            { 
                Name="Klavye",
                Fiyat=999,
                Kdv=18,
                CreatDate = DateTime.Now
            };
            Console.WriteLine("Ürün Bilgileri");
            Console.WriteLine($"Adı :{urun.Name}");
            Console.WriteLine($"Fiyat :{urun.Fiyat}");
            Console.WriteLine($"KDV :{urun.Kdv}");
            Console.WriteLine($"Eklenme Tarihi :{urun.CreatDate}");

            Console.WriteLine();

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();
            foreach (var item in birCizici)
            {
                item.Ciz();//Ciz metodunu çalıştır
            }
        }
        //Polimorfizm -Çokbiçimcilik
        public class Cizici
        {
            public virtual void Ciz()// virtual keywordu ile bu metodu override-ezilebilir hale getiriyoruz
            {
                Console.WriteLine("Cizici");
            }
        
        }
        public class DogruCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Düz Çizgi");
            }
            
        }
        public class DaireCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Daire Çizgi");
            }
            
        }
        public class KareCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Kare Çizgi");
            }
            
        }
        // sonu Polimorfizm -Çokbiçimcilik
    }
}
