-- sql de tek satýrlýk yorum için 2 tire kullanýlýr
/*
çoklu yorum satýrý
için
yine /**/ kullanýlýr.
*/

/*

*SQL komutlarý kullaným amaçlarýna göre üç genel kategoriye ayrýlýr.Bunlar:
	1-Veri Tanýmlama Dili(DDL-Data Definition Language) Tablo oluþturma, deðiþtirme ve silme iþlemleri için kullanýyoruz.
	2-Veri Ýþleme Dili(DML-Data Manupilation Language) Veri girmek deðitirmek,silmek ve verileri almak için kullanýlan komutlar
	3-Veri Kontrol Dili (DCL - Data Control Language)Veritabaný kullanýcýsý veya rolü ile ilgili izinlerin düzenlenmesini saðlar.

*/
		--SQL KOMUTLARI
--	Temel Sql Komutlarý
-- Sql Komutlarý ile Veritabaný Oluþturma
--create database OrnekDb --komutu çalýþrýmak için üst menüden execute veya kýsayolu f5
--Veritabaný isim deðiþtirme
--alter database OrnekDb Modify name=OrnekDatabase
-- Veritabaný Silme
--drop database OrnekDatabase
--Sql Kod ile Veritabanýna Tablo Ekleme
/*create database OrnekDb
go--git çalýþtýr
use OrnekDb--oluþturulan OrnekDb veritabanýný kullan
go
Create TABLE Personel (PersonelID int,Adi varchar(50),Soyadi varchar(50));--OrnekDb veritabana Personel adýnda tablo ekle

use OrnekDb--ornekdb veritabanýný kullan
go --sonraki adýma geç
create table ogrenciler(Id int not null,Adi varchar(50)not null,Soyadi varchar(50) null);--tabloyu verdiðimiz alanlara göre oluþtur alanlarýn boþ geçilme durunlarýný da kullandýk. Soyadý boþ geçilebilir diðerleri boþ geçilmezz

--Sql ile tabloda deðiþiklik yapma 
Alter table Personel add Email varchar(250)

Alter table Personel Alter Column Email varchar(50)--column alanýný deðiþtime

Alter table Personel Add Ders varchar(50),Konu varchar(50)--Tek seferde birden fazla kolon eklemek için araya , konur

Alter Table Personel Alter Column PersonelId int not null

ALTER TABLE Personel DROP COLUMN Email;

ALTER TABLE Personel ALTER COLUMN Soyadi nvarchar(75);

ALTER TABLE Personel ADD TCNo varchar(11);*/
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