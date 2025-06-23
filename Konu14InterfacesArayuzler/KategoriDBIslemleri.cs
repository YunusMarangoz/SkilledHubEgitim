using System.Xml.Linq;

namespace Konu14InterfacesArayuzler
{
    public class KategoriDBIslemleri : IVeritabaniIslemleri
    {
        public void Add(string Name)
        {
            Console.WriteLine(Name + " kategorisi eklendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Delete");
        }

        public void GetAll(int id)
        {
            Console.WriteLine();
        }

        public void Update(int id)
        {
            Console.WriteLine("Update");
        }
    }
}
