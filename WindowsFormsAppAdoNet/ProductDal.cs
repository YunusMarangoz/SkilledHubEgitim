using System;
using System.Collections.Generic;
using System.Data;//veritabanı işlemleri için gerekli
using System.Data.SqlClient;//ado.net kütüphaneleri

namespace WindowsFormsAppAdoNet
{
    internal class ProductDal:OrtakDAl
    {
        public List<Product> GetAll()
        { 
            var products=new List<Product>();
            ConnectionKontroll();          
            SqlCommand command = new SqlCommand("select * from Urunler", _connection);
            SqlDataReader reader=command.ExecuteReader();
            while (reader.Read())//reader nesnesi içerisindeki okuncak kayıt olduğu süreece 
            {
                var product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                   UrunAdi = reader["ÜrünAdi"].ToString(),
                    StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
                    UrunFiyati= Convert.ToDecimal(reader["UrunFiyati"]),
                    Durum = Convert.ToBoolean(reader["Durum"])

                };
                products.Add(product); //db den okunan ürünü listeye ekle
            }
            reader.Close();//veritabanından okuyucuyu kapat
            _connection.Close();//veritabanı bağlantısını kapat
            command.Dispose();//sql komut nesnesini yok et

            return products;
        
        }
    }
}
