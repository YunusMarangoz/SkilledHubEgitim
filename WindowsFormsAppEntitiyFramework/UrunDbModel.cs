using System.Data.Entity;//Entity Framework kütüphanesini ekledik
//Entitiy eklemek için 1. adım Proje sağ tık Manage Nuget Package diyoruz sonra kütüphaneyi buraya çapırıyıruz
using WindowsFormsAppAdoNet;

namespace WindowsFormsAppEntitiyFramework
{
    public class UrunDbModel: DbContext//Entity Frameworkün DbContext sınıfından miras alıyoruz 2. adım
    {
        public UrunDbModel() : base("name=UrunDbModel")// Entity Frameworkün DbContext sınıfındaki base e Conection string ismini gönderdik
         //app config ile connectionStrings bağlantı ayarı yaptık
        {

        }
       public virtual DbSet<Category> Categories{ get; set; }
       public virtual DbSet<Product> Products { get; set; }
        

    }
}
