namespace SınıflarOdev_UrunYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar:Odev-Urun Yonetimi!");
           
            Console.WriteLine("***Ürün Kategori Takibi***");
            Console.WriteLine("Kategori Adını Giriniz");
            var kategoriadı=Console.ReadLine();            

            Kategori kategori = new Kategori();
            kategori.Name = kategoriadı;
            Console.WriteLine($"Eklenen Kategori Adı = {kategori.Name}");

            Console.WriteLine();

            
            Console.WriteLine("Eklenek Ürün Bilgilerini Giriniz");
            Console.Write("Eklenek İstedğiniz Ürün Adını Girin : ");
            var Urunadı = Console.ReadLine();
            Console.Write("Eklenek İstedğiniz Ürün Fiyatını  Girin : ");
            var Urunfiyat = Console.ReadLine();
            Console.Write("Eklenek İstedğiniz Ürün Açılmaasını Girin : ");
            var Urunacıklama = Console.ReadLine();
            Urun urun = new()
            {
                Name = Urunadı,
                Fiyat = int.Parse(Urunfiyat),
                Description=Urunacıklama,
            };

            Console.WriteLine("**Ürün Bilgileri**");
            // Console.Write($"Ürün Adı : {urun.Name} ürün Fiyat : {urun.Fiyat} ürün Açıklaması {urun.Description}");
            Console.WriteLine("Eklenen Ürün Adı :"+urun.Name);
            Console.WriteLine("Eklenen Ürün Fiyatı :"+urun.Fiyat);
            Console.WriteLine("Eklenen Ürün Açıklması :"+urun.Description);

        }
        
    }
}
