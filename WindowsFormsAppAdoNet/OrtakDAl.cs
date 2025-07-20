using System.Data;//Veritabanı İşlemleri için Gerekli
using System.Data.SqlClient;// ado net kütüphaneleri


namespace WindowsFormsAppAdoNet
{
    public class OrtakDAL
    {
        internal SqlConnection _connection= new SqlConnection(@"server=(localdb)\MSSQLLocalDB; database=UrunYonetimiAdoNet; Integrated Security=True;");//bu serverdaki bu database-güvenli bağlantı aktif-veritabanımın bulunduğu server bilgisini conncetion string olarak burada tanımlıyorum.
        internal void ConnectionKontrol()//veritabanı bağlantımızı kontrol edecek olan metot
        {
            if (_connection.State == ConnectionState.Closed)//Eğer veritabanı bağlantımız kapalı ise
            { 
                _connection.Open();//veritabanı bağlantısını aç
            }
        }
    }
}
