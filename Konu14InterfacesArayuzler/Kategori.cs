
namespace Konu14InterfacesArayuzler
{
    public class Kategori : ISinifGereksinimleri//interface den clasa implement etme

    {
        /*
        Lambadan implement interface ten class tanımladığımızda bunu ister bizden ama interface den interface istemez
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException();
        */

        //2.yol ISinifGereksinimleri buraya kopylamak
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        //Kategoriye ait özelllikler
        public bool UstMenudeGoster { get; set; }
        public bool YanMenudeGoster { get; set; }       
    }
}
