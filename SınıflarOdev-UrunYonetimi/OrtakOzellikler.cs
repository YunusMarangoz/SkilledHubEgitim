namespace SınıflarOdev_UrunYonetimi
{
    public class OrtakOzellikler//base class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }//? işareti değeri null yapar
        public DateTime CreatDate { get; set; }

    }
}
