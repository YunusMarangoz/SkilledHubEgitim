-- sql de tek sat�rl�k yorum i�in 2 tire kullan�l�r
/*
�oklu yorum sat�r�
i�in
yine /**/ kullan�l�r.
*/

/*

*SQL komutlar� kullan�m ama�lar�na g�re �� genel kategoriye ayr�l�r.Bunlar:
	1-Veri Tan�mlama Dili(DDL-Data Definition Language) Tablo olu�turma, de�i�tirme ve silme i�lemleri i�in kullan�yoruz.
	2-Veri ��leme Dili(DML-Data Manupilation Language) Veri girmek de�itirmek,silmek ve verileri almak i�in kullan�lan komutlar
	3-Veri Kontrol Dili (DCL - Data Control Language)Veritaban� kullan�c�s� veya rol� ile ilgili izinlerin d�zenlenmesini sa�lar.

*/
		--SQL KOMUTLARI
--	Temel Sql Komutlar�
-- Sql Komutlar� ile Veritaban� Olu�turma
--create database OrnekDb --komutu �al��r�mak i�in �st men�den execute veya k�sayolu f5
--Veritaban� isim de�i�tirme
--alter database OrnekDb Modify name=OrnekDatabase
-- Veritaban� Silme
--drop database OrnekDatabase
--Sql Kod ile Veritaban�na Tablo Ekleme
/*create database OrnekDb
go--git �al��t�r
use OrnekDb--olu�turulan OrnekDb veritaban�n� kullan
go
Create TABLE Personel (PersonelID int,Adi varchar(50),Soyadi varchar(50));--OrnekDb veritabana Personel ad�nda tablo ekle

use OrnekDb--ornekdb veritaban�n� kullan
go --sonraki ad�ma ge�
create table ogrenciler(Id int not null,Adi varchar(50)not null,Soyadi varchar(50) null);--tabloyu verdi�imiz alanlara g�re olu�tur alanlar�n bo� ge�ilme durunlar�n� da kulland�k. Soyad� bo� ge�ilebilir di�erleri bo� ge�ilmezz

--Sql ile tabloda de�i�iklik yapma 
Alter table Personel add Email varchar(250)

Alter table Personel Alter Column Email varchar(50)--column alan�n� de�i�time

Alter table Personel Add Ders varchar(50),Konu varchar(50)--Tek seferde birden fazla kolon eklemek i�in araya , konur

Alter Table Personel Alter Column PersonelId int not null

ALTER TABLE Personel DROP COLUMN Email;

ALTER TABLE Personel ALTER COLUMN Soyadi nvarchar(75);

ALTER TABLE Personel ADD TCNo varchar(11);*/
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