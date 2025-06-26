namespace SOLIDPrensipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLIDPrensipleri!");
            Console.WriteLine("Robert Cecil Martin tarafından öne sürülen geliştirilecek yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını hedefleyen, kod tekrarını önleyen prensipler bütünüdür.");//Anayasa

            Console.WriteLine("");
            Console.WriteLine("S-Single Responsibility(Tek Sorumlulk Prensibi)");
            Console.WriteLine("\t 1 sınıf veya medodun sadece 1 sorumluluğunun olması gerekir!");

            Console.WriteLine("O- Open Closed Principle");
            Console.WriteLine("\t Bir sınıf veya metod var olan özelliklerini korumalı değişikliğe izin vermemelidir");

            Console.WriteLine("L - Liskov Substitution");
            Console.WriteLine("Kodlarımızda herhangi bir değişiklik yapmaya gerek dıymadan alt sınıfları türedikleri üst sınıfların yerine kullanabilmeliyiz");

            Console.WriteLine("I - Inteface Segregation");
            Console.WriteLine("Sorumlulukların hespini tek bir arayüzde toplamak yerine özelleştirilmiş birden fazla arayüz kullanmalıyız");

            Console.WriteLine("D - Dependency Inversion");// dikkat mülakat
            Console.WriteLine("Sınıflar arası bağımlılıklar alabildiğince az olmalıdır.Özelllikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır");
        }
    }
}
