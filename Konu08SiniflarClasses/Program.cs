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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar - Classes");

            Ev ilkev = new Ev();// soyut bir yapı olan ev sınıfından, somut bir nesne olan ilkev i oluşturduk
            ilkev.SokakAdi = "Çiçek SK";
            ilkev.KapiNo = 10;
            Console.WriteLine("İlkEv Sokak Adı : "+ilkev.SokakAdi);
            Console.WriteLine("İlkEv Kapi No : "+ilkev.KapiNo);

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
            
        }
    }
}
