			--CRUD ÝÞLEMLERÝ
--Tablolara kayýt ekleme,kayýtlarý çekme,kayýt güncelleme ve silme iþlemlerine kýsaca C(create) R(read) U(update) D(delete) deriz.
--Tabloya veri ekleme
--Insert Into Personel(PersonelID,Adi,Soyadi) values (1,'Memet','Ali')
-- Eklenee verileri seçme
--select * from Personel
--Tabloya Tüm Alanlara Veri Ekleme
--Insert Into Personel values (2,'Yunus','Marangoz',null,null,null);-- tablo kolonlarý yukardaki gibi sütun çaðýrýlarak doldurulur yada tüm alanlar null býrakýlarak girilir yoksa hata verir.
--Tabloda Güncelleme Yapma
--Update Personel set Adi='Yunus',Soyadi='Marangoz';--Tablodaki tüm deðerleri yunus marangoza çevirdi
--Update Personel set Adi='Alp',Soyadi='Doðan'where PersonelID=2;--sadece 2 numaralý id yi güncelle
--Kayýt Silme
--delete from Personel where PersonelID=3--3 numaralý id yi sil id belirtmezsel tümünü siler.
--Veritabanýnýn Yedeðini Alma
--BACKUP DATABASE OrnekDb TO DISK ='D:\DBYedek.bak';
--Veritabanýný Yedekten Geri Yükleme
/*
USE master;--Geri yüklemek için master veritabanýný kullanýyoruz.
GO
RESTORE DATABASE OrnekDB
FROM DISK='D:\DBYedek.bak'
WITH REPLACE;--Mevcut veritabanýný deðiþtir
*/
--Tablodaki Tüm Verileri Silme
--TRUNCATE TABLE personel;--delete komutundan daha hýzlý çalýþýr
--select * from Personel
--Tabloyu Silme
--Drop TABLE Personel;
		--SQL SORGULAMA
--Tablodaki tüm verileri Çekme
--select * from Products
--select * from Categories
--Tablodaki bazý sütunlarý çekme
--select ProductName,UnitPrice from Products--sadece bu iki sütunu seç--


