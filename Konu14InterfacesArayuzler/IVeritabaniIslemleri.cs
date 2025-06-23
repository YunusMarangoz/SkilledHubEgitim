namespace Konu14InterfacesArayuzler
{
    internal interface IVeritabaniIslemleri
    {
        // bu arayüzü kullancak claslar aşağıdakimetotları içermek zorundadır.!
        //CRUD metot imzaları
        void Add(string Name);//ekle
        void Update(int id);//Güncelle
        void Delete(int id);//Sil
        void GetAll(int id);//Listele
        //interface lerde metotlar açıkca yazılmaz, sadece geri dönüş tipi, adı ve parametresi belirtilir.

    }
}
