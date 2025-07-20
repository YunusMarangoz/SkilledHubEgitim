		--SQL SORGULAMA
--Tablodaki tüm verileri Çekme
--select * from Products
--select * from Categories
--Tablodaki bazı sütunları çekme
--select ProductName,UnitPrice from Products--sadece bu iki sütunu seç--
--Tablodaki alanlara Alias(Takma isim) vererek çağırma
--select ProductName as [Urun Adı],UnitPrice as [Ürün Fiyatı] from Products--hata almamak için köşeli parantez kullanılır. Bitişik yazılırsa köşeli kullanmayabiliriz.
--Tabloya Alias(Takma isim) vererek çağırma
--select p.ProductName as[Urun Adı] ,p.UnitPrice as [Ürün Fiyatı] from Products p --buradaki p csharp classı gibi davranıyor
--select kat.CategoryName as KategoriAdı from Categories kat
/*	Select top ifadesi
	Sorgu sonunda tüm kayıtlar yerine belirli sayıda kaydı çekmemizi sağlar
	SELECT TOP (50) * FROM Products--üstten ilk 50 satırı göster

select top (10) Productname,Unitprice,UnitsInStock from Products--üürnler tablsounudan üstten 10 ürünü seç ve Productname,Unitprice,UnitsInStock alanlarını getir
			Order by ile Sıralama

SELECT *FROM  Products ORDER BY UnitsInStock asc --Ürünleri UnitsInStock alanınan göre küçükten büyüğe doğru sıralayarak getir

SELECT *FROM  Products ORDER BY UnitsInStock desc--Ürünleri UnitsInStock alanınan göre büyükten küçüğe doğru sıralayarak getir
		SQL OPERATORLERI
	1-Sql Aritmetik Operatorler

--Toplama(+)
Select 10+8
--Çıkarma(-)
Select (30-13)
--Çarpma(*)
Select 9*3
--Bölme(/)
Select 40/2
--Modulo%
Select 18 %2
		2 - SQL KARŞILAŞTIRMA OPERATORLERİ

--Eşittir
Select * From Products where UnitPrice =18; --Unitprice tablosunda değeri 18e eşit olanları getir

Select * from Products Where CategoryID=3--CategoryID si 3 eşit olanları getir

Select * from Products Where ProductName='Pavlova'--pavloya eşit olan tek tırnak yazılır

--Büyüktür (>)
Select * From Products where UnitPrice > 18 ;
--Küçüktür (<)
Select * From Products where UnitPrice < 18 ;

Select * From Products where UnitsInStock < 1 ;
--Büyük Eşittir (>=)
Select * From Products where UnitPrice >= 18 ;
Select * From Products where UnitsInStock >= 99;

--Küçük Eşittir (<=)
Select * From Products where UnitPrice <= 18 ;
Select * From Products where UnitsInStock <= 99;
--Eşit Değildir <>
Select * From Products where UnitPrice <> 18 ;--18 eşit olmayan herşeyi getir.
Select * From Products where UnitPrice != 18 ;--csharptaki gibi

		3 - Mantıksal Operatorler

-- And(&) Ve Operatorü ile çoklu filtre
Select * from Products where SupplierID =1 and CategoryID=1 --Supplier(Tedarikçi) Ürünlerden SupplierID si 1 olan ve kategori 1 olan ürünleri getir
-- Or (|)  Veya Operatorü ile çoklu filtre

Select * from Products where SupplierID =1 or CategoryID=1
--Not(değil) Operatörü
Select * from Products where not SupplierID =1 and CategoryID=1-- SupplierID olmayan ve CategoryID olan
		4-Diğer Operatorler
	___SQL BETWEEN Operatörü (arasında olan)

Select * from Products where UnitPrice Between 10 and 20;--arasında
Select * from Products where UnitPrice not Between 10 and 20;--arasında olmayan

--Like Operatörü ile Arama,Filtreleme İşlemi
select * from Products where ProductName like 'a%';--Ürünlerden adı a ile  başlayanları getir.

select * from Customers where ContactName LIKE 'a%';--Müşterilerden adı a ile başlayanları getir.

select * from Customers where ContactName LIKE '%a';--Müşterilerden adı a ile bitenleri getir.

select * from Customers where ContactName LIKE '%or%';--Müşterilerden adı or içerenleri getir.
		--SQL IN-NOT IN OPERATORÜ
ilgili sütünda istedğimiz değerleri içerenleri in ile içermeyenleri not in ile filtreleyebiliriz
select * from Customers Where Country In('Germany','France','UK');--Custemers tablosundaki müşterilerden Country kolonu Germany','France','UK' değerlerini içerenleri getir.

select * from Customers Where Country Not In('Germany','France','UK');

--İç İçe İlişkili veri okuma
select * from Customers where Country in(select Country from Suppliers)--Müşterilerden Country alanında Suppliers(Tedarikçi)tablosundan ülke alanında geçenleri getir.Parantez içine yazılır
 -- TAblodan veri Okurken Hesaplama
 *Ürün stokları eritildiğinde kazanılacak para

select p.ProductName as [Ürün Adi],p.Unitprice as [Ürün Fiyatı],p.UnitsInstock *p.Unitprice as[Toplam Kazanç]
from Products p
		--SQL NULL Değerler		
select Shipname,ShipRegion from Orders where ShipRegion is null--Siparişlerden Shipname ve ShipRegion alanlarını ShipRegion alanı null olana göre çek
select Shipname,ShipRegion from Orders where ShipRegion is not null

--SQL SELECT DISTINCT KULLANIMI:Sorgu sonucunda kayıt tekrarını engellemeyi sağlar.


Select Country from Customers order by Country--aynı isimleri getirme bir daha
Select DISTINCT Country from Customers order by Country
	
	--SQl Joins ile Tablolarda Birleşik Sorgu Oluşturma
--SQl JOIN Türleri 
 1-(INNER) JOIN : Her iki tabloda da eşleşen değerlere sahip kayıtları döndürür.
 2-LEFT(OUTER)JOIN:Soldaki tablodan tüm kayıtları ve sağ tablodan eşleşen kayıtları döndürür.
 3-RIGHT(OUTER)JOIN:Sağ tablodan tüm kayıtları ve soldaki tablodan eşleşen kayıtları döndürür.
 4-FULL(OUTER)JOIN : Sol veya sağ tabloda bir eşleşme olduğunda tüm kayıtları döndürür.

--SQL INNER JOIN

Select * from Products
select * from Categories

select ProductName ,UnitsInStock ,CategoryName 
from products
join--iki farklı tabloyu birleştirme
Categories
on products.CategoryID=Categories.CategoryID 

select Orders.OrderID,Customers.CustomerID,Orders.OrderDate
from Orders
INNER JOIN	
Customers ON Orders.CustomerID=Customers.CustomerID;

--JOİN İLE İKİDEN FAZLA TABLO BİRLEŞTİRME

SELECT Orders.OrderID, Customers.ContactName, Shippers.CompanyName
FROM ((Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID);



-- SQL LEFT JOIN=sadece soldaki tablo verilirini getir
select Customers.ContactName, Orders.OrderID --Customers tablosundan ContactName alanını, Orders tablosundan OrderID alanını getir
from Customers --Customers tablosundan
Left Join Orders --left join ile solda birleştirme işlemi yapılır ve Customers tablosunda olan ama orders tablosunda olmayan kayıtlar da getirilir, inner join den farkı budur inner join sadece eşleşen kayıtları getirir
on Customers.CustomerID = Orders.CustomerID --tablolarımızın ortak noktaları olan CustomerID ye göre eşleştirdik
order by Customers.ContactName

-- SQL RIGHT JOIN-- sadece sağdaki tablo verilerini getir

SELECT Orders.OrderID, Employees.LastName, Employees.FirstName
FROM Orders
RIGHT JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;

-- SQL FULL OUTER JOIN iki tablodaki tüm verileri getir
SELECT Customers.ContactName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.ContactName;

-- SQL UNION
-- UNION komutu, iki veya daha fazla SELECT deyiminin sonuç kümesini birleştirmek için kullanılır.
SELECT City FROM Customers
UNION --iki tablodan gösterilen sonucu tek tabloda birleiştirdi. tekrar eden veriler engellenir. dikkat edilmesi gereken yer iki tablo satır sayısı aynı olmalı
SELECT City FROM Suppliers
ORDER BY City;

SELECT City FROM Customers
UNION all-- all tekrar eden kayıtları da getirir.
SELECT City FROM Suppliers
ORDER BY City;

-- SQL GROUP BY -- guruplama yapma
SELECT Country FROM Customers
GROUP BY Country;


--Hata Denetimi
BEGIN TRY
	SELECT 4/0--hatasını bulmaya çalıştığımız alan
END TRY
BEGIN CATCH--hata verdeğinde yapılacak
SELECT--oluşan hatayı yakalamak için
	ERROR_NUMBER() AS Hata_Numarasi,
	ERROR_SEVERITY() AS Hata_Duzeyi,
	ERROR_STATE() AS Hata_Durum_No,
	ERROR_LINE() AS Hata_Satir_No,
	ERROR_MESSAGE() AS Hata_Mesaj
END CATCH



create database Bilisim
go
use bilisim
CREATE TABLE Bolumler(
Bolum_No int NOT NULL,
Bolum_Adi nchar(50) NULL,
PRIMARY KEY (Bolum_No))

create table Calisanlar(
TC_No nvarchar(11) not null,
Adi nvarchar(100) not null,
Bolum_No int null,
Cinsiyet nchar(1) null
primary key (TC_No),
foreign key (Bolum_No) references Bolumler(Bolum_No)--yabancı anahtar iki tablo arasında ilişki kurmak istediğimizde yazarız
)
create table Urunler(
Urun_No int not null,
Urun_Adi nvarchar (50) not null,
Urun_Sayisi int null,
Urun_Fiyati decimal(18,2) null,
Bolum_No int NOT NULL,
primary key (Urun_No),
foreign key (Bolum_No) references Bolumler(Bolum_No)
)
create table Satislar(
Satis_No int not null,
Urun_No int null,
Calisan_TC_No nvarchar(11) null,
Miktar int null,
Fiyat decimal(18,2) null,
Tarih Date null,
primary key (Satis_No),
foreign key (Urun_No) references Urunler(Urun_No),
foreign key (Calisan_TC_No) references Calisanlar(TC_No)
)

-- Commit ve Rollback--hata yapılırsa yapılan güncellemeyi geri al
begin
begin try
 begin transaction
	update Calisanlar set Adi = 'Ali' where TC_No = '213451454'
	update Bolumler Set Bolum_Adi = 'Ev Aleti' where Bolum_No = 5
	commit tran
	Print 'Kayıt güncellendi'
 end try
 begin catch
	rollback transaction --eğer yukarıdaki kodlarda hata oluşursa değişiklikleri geri al
	Print 'Kayıt güncellenemedi hata oluştu!'
 end catch
end
*/

	-- SQL Constraints(Kisitlayicilar)
 --Kisitlayici Çeşitleri
 -- PRIMARY KEY Birincil anahtar Kisitlayici

 -- FOREIGN KEY – YABANCI ANAHTAR KISITLAYICI-eşleştirme

 -- UNIQUE Tekil alan Kisitlayicisi--benzersiz olması tc gibi

 -- truncate table kullanicilar-tabloyu yenileme hatalara karşı yazılabilir
/*
 -- Triggers-Tetikleyiciler : yapilan bir eylem sonrası başka bir eylemin yapılması tetiklenebilinir.

	MsSql de 2 çeşit tetikleyici vardır
		1- Ardı sıra tetikleyiciler;
		2- Yerine Tetikleyiciler ;
 

 
	-- STORED PROCEDURE (Saklı Yordam) ve Fonksiyon Kullanımı--c#metodu gibi
-- Yeni Stored Procedure (Sakı yordam oluşturma)

CREATE PROCEDURE sp_CalisanBolum --sp_CalisanBolum isminde bir SP oluşturduk
AS
BEGIN
select Bolumler.Bolum_adi, Calisanlar.Adi From Bolumler INNER JOIN
 Calisanlar ON Bolumler.Bolum_No = Calisanlar.Bolum_No
--sp_CalisanBolum ün yapacağı işlem için ilgili select kodunu yazdık
END
GO

exec sp_CalisanBolum -- STORED PROCEDURE Çalıştırma

CREATE PROCEDURE sp_UrunListele
(@UrunSayisiParametresi int)--SP ye dışarıdan gelecek ürün sayısı parametresine göre Ürünleri listeleteceğiz
AS
BEGIN
select * from Urunler where Urun_Sayisi > @UrunSayisiParametresi
END


exec sp_UrunListele 5--değer istiyor

-- SP Güncelleme
Alter PROCEDURE sp_UrunListele
(@UrunSayisiParametresi int = 0)--SP ye dýþarýdan gelecek ürün sayısı parametresine göre Ürünleri listeleteceğiz
AS
BEGIN
select * from Urunler where Urun_Sayisi > @UrunSayisiParametresi
END

CREATE PROCEDURE sp_BolumEkle
(
@BolumAdi nvarchar(50)
)
AS
BEGIN
INSERT INTO Bolumler(Bolum_Adi) VALUES (@BolumAdi)
END

-- KULLANIMI
--identıtıy oluşturma için bolum no sıralı artsın
--1 dizayn ekranında sağ tık property ordan identy column diyoruz. 
--2 Column porperty den Identıty increment yes
exec sp_BolumEkle 'Aksesuar'


	-- FONKSÝYONLAR

-- Kullanıcı tanımlı fonksiyonlar, kullanıcılar tarafından tanımlanan tek bir değer veya tablo döndürmek için kullanılan ilişkisel veritabanı nesneleridir.

	CREATE FUNCTION : Fonksiyon oluşturmak için kullanılır
	ALTER FUNCTION : Fonksiyonda değişiklik yapmak için kullanılır.
	DROP FUNCTION : Mevcut olan fonksiyonu silmek için kullanılır.


CREATE FUNCTION UrunAdet(@urunAdi nvarchar(50))
RETURNS int
AS
BEGIN
DECLARE @urunAdedi int --veri tipi int olan bir değişken oluşturduk
SET @urunAdedi=(SELECT Urun_Sayisi FROM Urunler WHERE Urun_Adi=@urunAdi)
RETURN @urunAdedi --select sorgusuyla bulunan urunadedi değiken değerini döndür
END


-- Fonksiyon kullanımı:
select dbo.UrunAdet('Bilgisayar') as UrunAdedi

-- Tablo Deðerli Fonksiyonlar
create function fn_CalisanlariListele()
returns table
as
return select * from Calisanlar


-- Fonksiyon kullanımı:
select * from fn_calisanlariListele()

	-- SQL Server Fonksiyonları
-- Sql String Fonksiyonları

SELECT Left('Left kullanımı', 6)
 SELECT Right('Left kullanımı', 6)

SELECT Len('Len kullanımı')

SELECT ProductName, Len(ProductName) as [Ürün adi karakter sayisi] from Products order by [Ürün adi karakter sayisi] asc
*/
/*SELECT Lower('Küçük HARFE Çevir') as KüçükHarf

SELECT ProductName, Lower(ProductName) as [Ürün adını küçük harfe çevir], Len(ProductName) as [Ürün adi karakter sayisi] from Products

SELECT Upper('Büyük HARFE Çevir') --Metni büyük harfe çeviren fonksiyon

SELECT ProductName, Upper(ProductName) as [Ürün adini büyük harfe çevir] from Products

--AVG() Fonksiyonu : bir ifadenin ortalama değerini döndürür.
SELECT AVG(UnitPrice) AS OrtalamaÜrünFiyati FROM Products;

SELECT Min(UnitPrice) AS EnDüşükÜrünFiyati FROM Products;

SELECT Max(UnitPrice) AS EnYüksekÜrünFiyati FROM Products;*/