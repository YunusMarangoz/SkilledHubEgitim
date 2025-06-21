using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Konu13KapsullemeEncapsulation
{
    public class Bolum
    {
        private string BolumAdi;//Dışarıdan erişime kapalı değişkenimiz. 
        //Accesor(Getter)
        public string GetBolumAdi() 
        { 
            return BolumAdi; 
        }//Geriye private BolumAdi değişkenini döndüren Metot

        public void SetBolumADi(string istenenEgitimi)
        {
            if (istenenEgitimi =="Yazılım Mühendisliği")
            {
                Console.WriteLine("Üniveristemizde {0} Bölümü Bulunmamamaktadır!",istenenEgitimi);
            } 
            else BolumAdi = istenenEgitimi;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13:Kapsulleme-Encapsulation!");
            Bolum bolum = new Bolum();
            Console.WriteLine("Kurumumuzdaki Bölümler");
            Console.WriteLine("1-Elektronik");
            Console.WriteLine("2-Bilgisayar Mühendisliği");
            Console.WriteLine("3-Grafik Tasarım");
            Console.WriteLine("Lütfen Bölüm Adını Giriniz; ");
            //var bolumAdi=Console.ReadLine();//ekrandan alınan değeri varile oluştuduğumuz bolumadi değişkeninin üzerine atadık.
            //bolum.SetBolumADi(bolumAdi);// Bolum içerisindeki SetBolumADi metoduna bolum adini gonderdik,private değişkene atama yapıldı.
            //Console.WriteLine("Kayıt Olunacak Bolum Adı : "+bolum.GetBolumAdi());//bolum içerisindeki GetBolumAdi() metodunu direkt ekrana yazdırdık çünkü GetBolumAdi()

            Console.WriteLine();

            Fakulte fakulte = new Fakulte
            { 
                Bolum = "Yazılım Mühendisliği"         
            };
            Console.WriteLine("Fakülte={0}{1}",fakulte.Bolum," 2,değer");

            Console.WriteLine();
            Universite  universite=new ("Maliye");
            Console.WriteLine("Universite Bölümü: "+universite.Bolum);
            //universite.Bolum = "";//bu şekilde veri gödnerimi yapamayız çünkü property read only ve hata verir
        }
    }

    //Ozgen (Property) kullanarak Kapsulleme
    public class Fakulte
    {
        private string bolum;//Fakulte  sınıfının içindeki bolum değişkenini private tanımlayarak kapsullemiş olduk, böylece bir değişkene sadece aşağıdaki get,set metotlarıyla eişilebilir.
        public string Bolum         
        {
            get { return bolum; }// Bolum değeri okunmak istenirse get bolumu çalışır
            //get bloğu içindeki return(dön) komutundan anlaşılacağı üzere geriye içerdeği privare tanımladğımız kapsüllenen bolum değişkenine atanan veriyi döndürür
            set// Bolum veri ataması atnmak istenirse set bolumu çalışır
            {
                if (value == "Yazılım Mühendisliği")
                {
                    Console.WriteLine("Üniveristemizde {0} Bölümü Bulunmamamaktadır!", value);
                }
                else bolum = value;
            } // set bloğu ise dışarıya açık Bolum değişkenine atanan veriyi alıp içerde kapsulledeğimiz private bolum değişkenine atar
        }
    }
    //Yalnız okunur(Read Only property)
    public class Universite
    {
        private string bolum;
        public Universite(string str)
        {
            bolum = str;
        }
        public string Bolum { get{ return bolum; } }//set silindiğinde sadece read oluyor geriye değer döndürmüyor
    }
}
