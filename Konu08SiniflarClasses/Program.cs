using System.Net.WebSockets;

namespace Konu08SiniflarClasses
{
    internal class Ev//Sınıf Tanımlama
    {
        internal string SokakAdi;// internal erişim belirleyici
        internal int KapiNo;
    }
    /*C# nesne yönelimli bir programlama dili olduğu için her şey sınıflar içinde tanımlanır.
    sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir.
    Öğelere erişimi kısıtlayan ya da yetki veren anahtar sözcüklere "Erişim Belirteçleri" (acces modifiers) denir.
    *Erişim belirteçleri 4 ana sınıfa ayrılır
    * public    : Erişim kısıtı yoktur, her yerden erişilebilir
    * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
    * internal  : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
    * private   : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
    * Bir öğe yalnızca 1 erişim belirteci alabilir
    * namespace erişim belirteci almaz çünkü o daima public tir
    * Sınıflar public yada internal nitelemesi alabilirler ama protected yada private nitelemesi alamazlar
    * enum erişim belirteci almaz çünkü daima public tir
    */
    public class deneme
    {
        public string UrunAdi = "public öğeye herkes erişebişir";
        protected class test //Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
        {
            string UrunAdi;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar - Classes");
            #region Ornek1


            Ev ilkev = new Ev();// soyut bir yapı olan ev sınıfından, somut bir nesne olan ilkevi oluşturduk
            ilkev.SokakAdi = "Çiçek SK";
            ilkev.KapiNo = 10;
            Console.WriteLine("İlkEv Sokak Adı : " + ilkev.SokakAdi);
            Console.WriteLine("İlkEv Kapi No : " + ilkev.KapiNo);

            Console.WriteLine();

            Ev yazlikEv = new Ev();
            yazlikEv.SokakAdi = "Deniz SK";
            yazlikEv.KapiNo = 15;

            Console.WriteLine("Yazlikev Sokak Adı : " + yazlikEv.SokakAdi);
            Console.WriteLine("Yazlik Kapi No : " + yazlikEv.KapiNo);

            Console.WriteLine();

            Ev koyevi = new()
            {
                SokakAdi = "Pınar SK",// bu kullamımda ; yerine öğeler arasına , koymanız gerekli
                KapiNo = 34
            };
            Console.WriteLine("Köyevi Sokak ADı" + koyevi.SokakAdi);
            Console.WriteLine("Köyevi Kapı No" + koyevi.KapiNo);
            #endregion
            Console.WriteLine();
            #region Ornek2

            kullanici kullanici = new()
            {
                Adi = "Nazar",
                Soyadi = "Marangoz",
                Email = "Nazar@gmail.com",
                Id = 1,
                KullaniciAdi = "Nazardeneme",
                Sifre = "1234"
            };


            kullanici yunus = new()
            {
                Adi = "Yunus",
                Soyadi = "Marangoz",
                Email = "yunusmarangoz@gmail.com",
                Id = 1,
                KullaniciAdi = "Yunusso",
                Sifre = "12345"
            };

            Console.WriteLine("Kullanıcı Bilgileri");
            Console.WriteLine("Adı: " + kullanici.Adi);
            Console.WriteLine("Soyadı: " + kullanici.Soyadi);

            Console.WriteLine();

            Console.WriteLine("Adı: " + yunus.Adi);
            Console.WriteLine("Soyadı: " + yunus.Soyadi);
            #endregion
            Console.WriteLine();
            /*
            Console.WriteLine("Kullanıcı Adınız: ");           
            var kullaniciAdi=Console.ReadLine();
            Console.WriteLine("Şifreniz: ");
            var sifre=Console.ReadLine();
            if (kullaniciAdi==kullanici.KullaniciAdi && sifre==kullanici.Sifre)
            {
                Console.WriteLine("Hoş Geldin: "+kullanici.Adi+" "+kullanici.Soyadi);
            }
            else            
                Console.WriteLine("Giriş Başarısız");
            */

            Araba araba = new()
            {
                id = 1,
                KasaTipi="Sedan",
                Marka="Dacia",
                Model="Logan",
                Renk="Bordo",
                VitesTipi="Manuel",
                YakitTipi="Dizel"              
            };
            Console.WriteLine("Araç Bilgisi");
            Console.WriteLine($"Marka :{araba.Marka} \nModel :{araba.Model} \nRenk :{araba.Renk}");

            Console.WriteLine( );

            Araba araba2 = new()
            {
                id = 2,
                KasaTipi = "Sedan",
                Marka = "Audi",
                Model = "A8 Long",
                Renk = "Siyah",
                VitesTipi = "Otomatik",
                YakitTipi = "Benzin"
            };
            Console.WriteLine("Araç Bilgisi");
            Console.WriteLine($"Marka :{araba2.Marka} \nModel :{araba2.Model} \nRenk :{araba2.Renk}");

            Console.WriteLine();

            Kategori kategori = new()
            {
                id = 1,
                KategoriAdi = "Elektronik"
            };

            Kategori kategori2 = new()
            {
                id = 2,
                KategoriAdi = "Bilgisayar"
            };

            Kategori kategori3 = new()
            {
                id = 3,
                KategoriAdi = "Telefon"
            };
            Console.WriteLine("Kategori : " +kategori.KategoriAdi);
            Console.WriteLine("Kategori 2: " +kategori2.KategoriAdi);
            Console.WriteLine("Kategori 3: " +kategori3.KategoriAdi);

        }
    }
    class kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }

    class Araba
    {
        internal int id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
    }
}
