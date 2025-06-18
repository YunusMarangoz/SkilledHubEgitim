namespace Konu12KalitimInheritance
{
    public class Kategori : OrtakOzellikler//Ortak Özelilklerin tüm özelliklerini alır
    {
        public string? KategoriBanner { get; set; }//string yanına ? değişkeni null yapar
        public bool UstMenudeGoster { get; set; }
        public bool YanMenudeGoster { get; set; }
        public bool AltMenudeGoster { get; set; }
    }
}
