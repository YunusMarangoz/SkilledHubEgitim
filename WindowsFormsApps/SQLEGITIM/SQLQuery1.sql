			--CRUD ��LEMLER�
--Tablolara kay�t ekleme,kay�tlar� �ekme,kay�t g�ncelleme ve silme i�lemlerine k�saca C(create) R(read) U(update) D(delete) deriz.
--Tabloya veri ekleme
--Insert Into Personel(PersonelID,Adi,Soyadi) values (1,'Memet','Ali')
-- Eklenee verileri se�me
--select * from Personel
--Tabloya T�m Alanlara Veri Ekleme
--Insert Into Personel values (2,'Yunus','Marangoz',null,null,null);-- tablo kolonlar� yukardaki gibi s�tun �a��r�larak doldurulur yada t�m alanlar null b�rak�larak girilir yoksa hata verir.
--Tabloda G�ncelleme Yapma
--Update Personel set Adi='Yunus',Soyadi='Marangoz';--Tablodaki t�m de�erleri yunus marangoza �evirdi
--Update Personel set Adi='Alp',Soyadi='Do�an'where PersonelID=2;--sadece 2 numaral� id yi g�ncelle
--Kay�t Silme
--delete from Personel where PersonelID=3--3 numaral� id yi sil id belirtmezsel t�m�n� siler.
--Veritaban�n�n Yede�ini Alma
--BACKUP DATABASE OrnekDb TO DISK ='D:\DBYedek.bak';
--Veritaban�n� Yedekten Geri Y�kleme
/*
USE master;--Geri y�klemek i�in master veritaban�n� kullan�yoruz.
GO
RESTORE DATABASE OrnekDB
FROM DISK='D:\DBYedek.bak'
WITH REPLACE;--Mevcut veritaban�n� de�i�tir
*/
--Tablodaki T�m Verileri Silme
--TRUNCATE TABLE personel;--delete komutundan daha h�zl� �al���r
--select * from Personel
--Tabloyu Silme
--Drop TABLE Personel;
		--SQL SORGULAMA
--Tablodaki t�m verileri �ekme
--select * from Products
--select * from Categories
--Tablodaki baz� s�tunlar� �ekme
--select ProductName,UnitPrice from Products--sadece bu iki s�tunu se�--


