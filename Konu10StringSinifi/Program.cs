using System.Threading.Tasks.Sources;

namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10StringSinifi");
            string degisken;
            char karakter = 'F'; //Tek karakter alır.
             string metinlericin = "metinler için mi kullanıyorduk?";
            Console.WriteLine(metinlericin);
            //Ornek1();
            //StringMetotlari();
            SplitMetodu();
        }
        static void Ornek1()

        {
            string birMetim = "Ankara başkenttir";
            string birSayi = "123456789";
            System.String birTarih = "02.05.2021";
            string kod = "//5456dfg\n"; // buradakai \n kodu enter görevi görür kendinden sonra gelecek olan metni bir alt satıra kaydırır.
            Console.WriteLine(birMetim.GetType());
            Console.WriteLine(birSayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);

            string s = "Barış Manço";
            Console.WriteLine("For DÖngüsü Çıktısı");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[" + i + "] = " + s[i]);
            }

            Console.WriteLine("Foreach DÖngüsü Çıktısı");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

        }
        static void StringMetotlari()
        {
            string metin = "Stringin birçok metodu vardır";
            Console.WriteLine("metin in karakter sayısı(metin.Length) : "+metin.Length);//Length metin değikenin kaç karakter olduğunu verir.
            var klon=metin.Clone();// Clone metodu metin değişkenin kolnlayıp klon üzerine atar.

            Console.WriteLine("metnin klonu : "+klon);
            metin = "My Name is Ali";
            Console.WriteLine(metin+ " EndsWith i : "  + metin.EndsWith("i"));
            Console.WriteLine(metin+ " EndsWith r : "  + metin.EndsWith("r"));

            Console.WriteLine();

            Console.WriteLine(metin + " StartsWith s : " + metin.StartsWith("s"));
            Console.WriteLine(metin + " StartsWith m : " + metin.StartsWith("m"));
            Console.WriteLine(metin + " StartsWith M : " + metin.StartsWith("M"));

            Console.WriteLine();
            Console.WriteLine(metin + " IndexOf name  : " + metin.IndexOf("name"));//Kaçıncı Sırada olduğunu bulur. Yoksa -1 döndürü
            Console.WriteLine(metin + " IndexOf Name  : " + metin.IndexOf("Name"));
            Console.WriteLine(metin + " LastIndexOf i  : " + metin.LastIndexOf("i"));// Ka.ıncı indexte olduğunu yazar

            Console.WriteLine();
            Console.WriteLine(metin + " LastIndexOf i  : " + metin.Insert(0,"Merhaba : "));//metnin değeri değişmiyor sadece başına merhaba ekliyor
            Console.WriteLine(metin);

            Console.WriteLine();
            Console.WriteLine(metin + " Substring 2:  : " + metin.Substring(2));// Girilen değer kadarını sil
            Console.WriteLine(metin + " Substring 2,5:  : " + metin.Substring(2,5));// Girilen 2.indekstem sonra 5 index yaz

            Console.WriteLine();
            Console.WriteLine(metin + " ToLower:  : " + metin.ToLower());//metni kçük karaktere çevirir
            Console.WriteLine(metin + " ToUpper:  : " + metin.ToUpper());//metni büyük karaktere çevirir
            Console.WriteLine(metin + " metin.ToLower().Replace: " + metin.ToLower().Replace(" ","-"));//metindeki boşlukarı - ile değiştir. 
            Console.WriteLine(metin + " Remove 2: " + metin.Remove(2)); // 2 indekten sonrasını sil
            Console.WriteLine(metin + " Remove 2,5: " + metin.Remove(2,5));// 2 indekten sonra 5 karakter sil
        }
        static void SplitMetodu()
        {
            string sehirler = "İstanbul,Ankara,İzmir,Bursa,Adana,Antalya";
            string[] sehirlerArrray=sehirler.Split(",");
            Console.WriteLine("4. Sehir : " + sehirlerArrray[3]);
            foreach (var item in sehirlerArrray)
            {
                Console.WriteLine("Şehir : "+item);
            }
            Console.WriteLine();
            Console.WriteLine("tarih parçalama");
            var tarih = DateTime.Now.ToShortDateString();
            Console.WriteLine("tarih: "+tarih);
            var tarihparcalari=tarih.Split(".");
            var gun=tarihparcalari[0];
            var ay=tarihparcalari[1];
            var yil=tarihparcalari[2];
            Console.WriteLine("gun:"+gun+"\nay: "+ay+"\nyil:"+yil);

        }

    }
}
