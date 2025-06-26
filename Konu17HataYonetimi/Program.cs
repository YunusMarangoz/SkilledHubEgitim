using ClassLibrary1;

namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu17HataYonetimi!");
            Console.WriteLine();
            Console.WriteLine("Kdv Hesaplamak için Fiyat Giriniz :");
            var sayi=Console.ReadLine();
            //KdvHesapla(int.Parse(sayi));
            try
            {
                KdvHesapla(int.Parse(sayi));//kodları çalıştırmayı dene
            }
            catch (Exception hata)//Exception a hata ismmini verdik, bu bize oluşan hatayı verir.
            {
                Console.WriteLine("Hata Oluştı! Lütfen sadece sayısal değer giriniz!");
                //throw;//bu yine hata fırlatır
                // oluşan hatayı loglayabiliriz
                Console.WriteLine(hata.Message);
            }
            finally
            {
                Console.WriteLine("try catch bloğundan sonra her seferinde çalışmasını istediğimiz bir işlem varsa bu blokta çalıştırabiliriz. Kullanımı zorunlu değildir");
                Console.WriteLine("Bir sayi giriniz :");
                var sayi2 = Console.ReadLine();
                KdvHesapla(double.Parse(sayi2));
            }
            //Classlibrary1 projesinden category eklemek için DEpendencies sağ tık add diyoruz
            //buna katmanlı mimari diyoruz
            Category category = new Category();
            category.Name = "Elektronik";
            Console.WriteLine(category.Name);

            Console.WriteLine();

            Product product = new Product();
            product.Name = "Oyun Bilgisayarı";
            Console.WriteLine("Ürün Adı: ");
            Console.WriteLine(product.Name);
        }
        static void KdvHesapla(double fiyat) 
        {
            Console.WriteLine("Fiyat : "+fiyat);
            Console.WriteLine("Kdv : "+(fiyat*0.20));
            Console.WriteLine("Kdv Dahil Toplam Tutar : "+(fiyat+(fiyat*0.20)));
        }    
    }
}
