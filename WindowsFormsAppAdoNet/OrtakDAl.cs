using System.Data;//veritabanı işlemleri için gerekli
using System.Data.SqlClient;//ado.net kütüphaneleri


namespace WindowsFormsAppAdoNet
{
    public class OrtakDAl
    {
        internal  SqlConnection _connection=new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=UrunYonetimiAdoNet;Integrated Security=True;");//veritabanımın bulunduğu server bilgisini conncetion string olarak burada tanımlıyorum.

        internal void ConnectionKontroll()//Veritabanı bağlantımızı kontrol edecek olan metot
        {
            if (_connection.State == ConnectionState.Closed)//Eğer veritabanımızın bağlantısı kapalı ise
            {
                _connection.Open();// veritabanı bağlantısını aç
            }
        }
    }
}
