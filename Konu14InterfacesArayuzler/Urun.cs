namespace Konu14InterfacesArayuzler
{
    public class Urun: ISinifGereksinimleri, IVeritabaniIslemleri//, ile ikinci bir interface iöplement ekleyebliriz.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        //Ürün clasına özel propertyler
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int KategoriId { get; set; }

        public void Add(string Name)
        {
            Console.WriteLine(Name+" ürünü eklendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine(id + " li ürün silindi");  
        }

        public void GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            Console.WriteLine(id + " li ürün güncellendi");
        }
    }
}
