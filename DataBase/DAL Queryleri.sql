--Aktif olan tüm varlýklarý getiren sorgu

select v.VarlikID as [Kayýt Numarasý],v.Barkod, vg.VarlikGrubuAdi as[Ürün Tipi], mm1.MarkaModelAdi as Marka ,mm.MarkaModelAdi as Model , fy.ParaMiktari as Fiyat
from Varlik v
inner join VarlikGrubu vg on v.VarlikGrubuID=vg.VarlikGrubuID
inner join MarkaModel mm on v.MarkaModelID=mm.MarkaModelID
inner join MarkaModel mm1 on mm.UstMarkaModelID=mm1.MarkaModelID
inner Join Fiyat fy on fy.VarlikID=v.VarlikID
where v.AktifMi = 1

select * from Varlik
-- belli bir personel ýd ye göre zimmet çeken 
select pz.KullaniciZimmetID as [Kayýt Numarasý],v.Barkod, vg.VarlikGrubuAdi as [Ürün Tipi],fy.ParaMiktari as Fiyat ,mm1.MarkaModelAdi+' '+mm.MarkaModelAdi as [Marka Model] 
from PersonelZimmet pz 
inner join Personel p on pz.PersonelID=p.PersonelID
inner join Zimmet z on pz.ZimmetID=z.ZimmedID
inner join VarlikDepo vd on z.VarlikDepoID=vd.VarlikDepoID
inner join Varlik v on vd.VarlikID=v.VarlikID
inner join VarlikGrubu vg on v.VarlikGrubuID=vg.VarlikGrubuID
inner join Fiyat fy on fy.VarlikID= v.VarlikID
inner join MarkaModel mm on v.MarkaModelID=mm.MarkaModelID
inner join MarkaModel mm1 on mm.UstMarkaModelID=mm1.MarkaModelID
where pz.PersonelID=2

--belli bir ekip id ye göre zimmet çeken

select sez.SirketEkipID as [Kayýt Numarasý],v.Barkod, vg.VarlikGrubuAdi as [Ürün Tipi],fy.ParaMiktari as Fiyat ,mm1.MarkaModelAdi+' '+mm.MarkaModelAdi as [Marka Model] 
from SirketEkipZimmet sez 
inner join SirketEkip se on sez.SirketEkipID=se.SirketEkipID
inner join Zimmet z on sez.ZimmetID=z.ZimmedID
inner join VarlikDepo vd on z.VarlikDepoID=vd.VarlikDepoID
inner join Varlik v on vd.VarlikID=v.VarlikID
inner join VarlikGrubu vg on v.VarlikGrubuID=vg.VarlikGrubuID
inner join Fiyat fy on fy.VarlikID= v.VarlikID
inner join MarkaModel mm on v.MarkaModelID=mm.MarkaModelID
inner join MarkaModel mm1 on mm.UstMarkaModelID=mm1.MarkaModelID
where sez.SirketEkipID=2

--Tüm varlýklar

select v.VarlikID as [Kayýt Numarasý],v.Barkod, vg.VarlikGrubuAdi as[Ürün Tipi], mm1.MarkaModelAdi+' '+mm.MarkaModelAdi as [Marka Model] , fy.ParaMiktari as Fiyat
from Varlik v
inner join VarlikGrubu vg on v.VarlikGrubuID=vg.VarlikGrubuID
inner join MarkaModel mm on v.MarkaModelID=mm.MarkaModelID
inner join MarkaModel mm1 on mm.UstMarkaModelID=mm1.MarkaModelID
inner Join Fiyat fy on fy.VarlikID=v.VarlikID

--bir personele ait belli id deki zimmet

select pz.KullaniciZimmetID as [Kayýt Numarasý],
v.Barkod, 
vg.VarlikGrubuAdi as [Ürün Tipi],
mm1.MarkaModelAdi as Marka,
mm.MarkaModelAdi as Model,
IIf(v.GarantiliMÝ = 1,'Var','Yok') as [Garanti Durumu] ,
v.CikisTarihi as [Giris Tarihi],
v.EmeklilikTarihi as[Emeklilik Tarihi],
v.MaliyetFiyati as [Urun Maliyeti],
pb.ParaBirimAdi as [Maliyet Para Birimi],
fy.ParaMiktari as [Guncel Fiyat],
pb1.ParaBirimAdi as [Guncel Fiyat Para Birimi]
from PersonelZimmet pz 
inner join Personel p on pz.PersonelID=p.PersonelID
inner join Zimmet z on pz.ZimmetID=z.ZimmedID
inner join VarlikDepo vd on z.VarlikDepoID=vd.VarlikDepoID
inner join Varlik v on vd.VarlikID=v.VarlikID
inner join VarlikGrubu vg on v.VarlikGrubuID=vg.VarlikGrubuID
inner join ParaBirimi pb on v.MaliyetParaBirimiID=pb.ParaBirimiID
inner join Fiyat fy on fy.VarlikID= v.VarlikID
inner join ParaBirimi pb1 on fy.ParaBirimiID=pb1.ParaBirimiID
inner join MarkaModel mm on v.MarkaModelID=mm.MarkaModelID
inner join MarkaModel mm1 on mm.UstMarkaModelID=mm1.MarkaModelID
where pz.PersonelID=2



-- id ye göre  varlýk
select v.VarlikID as [Kayýt Numarasý],
v.Barkod, 
b.BirimID as [Birim ID],
b.BirimAdi as [Birim Adi],
v.Miktar ,
vg.VarlikGrubuID as [Ürün Tipi ID],
vg.VarlikGrubuAdi as [Ürün Tipi],
mm1.MarkaModelID as [Marka ID],
mm1.MarkaModelAdi as Marka,
mm.MarkaModelID as [Model ID],
mm.MarkaModelAdi as Model,
IIf(v.GarantiliMÝ = 1,'Var','Yok') as [Garanti Durumu] ,
v.CikisTarihi as [Giris Tarihi],
v.Aciklama ,
v.MaliyetFiyati as [Urun Maliyeti],
pb.ParaBirimiID as [Maaliyet Para Birimi ID],
pb.ParaBirimAdi as [Maliyet Para Birimi]
from Varlik v 
inner join VarlikGrubu vg on v.VarlikGrubuID=vg.VarlikGrubuID
left join Birim b on v.BirimID=b.BirimID
inner join ParaBirimi pb on v.MaliyetParaBirimiID=pb.ParaBirimiID
inner join Fiyat fy on fy.VarlikID= v.VarlikID
inner join ParaBirimi pb1 on fy.ParaBirimiID=pb1.ParaBirimiID
inner join MarkaModel mm on v.MarkaModelID=mm.MarkaModelID
inner join MarkaModel mm1 on mm.UstMarkaModelID=mm1.MarkaModelID
where v.VarlikID =1 and fy.AktifMi='True'

-- Fiyat tablosundan bir varlýða ait fiyat bilgilierinin çekilmesi
select f.FiyatID, f.ParaMiktari,p.ParaBirimiID,p.ParaBirimAdi from Fiyat f 
inner join ParaBirimi p on f.ParaBirimiID=p.ParaBirimiID
where f.AktifMi = 'True' and f.VarlikID = 1

--Sadece Markalarý Getiren sorgu
select DISTINCT mm1.MarkaModelID,  mm1.MarkaModelAdi  from MarkaModel mm
inner join MarkaModel mm1 on mm.UstMarkaModelID=mm1.MarkaModelID where mm1.AktifMi = 'True'

--Sadece Modelleri getiren sorgu
select DISTINCT mm1.MarkaModelID,  mm1.MarkaModelAdi  from MarkaModel mm
inner join MarkaModel mm1 on mm1.UstMarkaModelID!=mm1.MarkaModelID where mm1.AktifMi = 'True' and mm1.UstMarkaModelID =1

--Soru ve duyuru
select Soru,cevap from Soru
select DuyuruBasligi,DuyuruMetni from Duyuru
select BirimAdi,BirimID from Birim

--Depo id ye göre ürünleri ve bu ürünlerin fiyatlarýný getiren sorgu
select vd.VarlikDepoID, mm1.MarkaModelAdi,mm.MarkaModelAdi,f.ParaMiktari , pb.ParaBirimAdi from VarlikDepo vd
inner join Varlik v on vd.VarlikID=v.VarlikID
inner join MarkaModel mm on v.MarkaModelID=mm.MarkaModelID
inner join MarkaModel mm1 on mm.UstMarkaModelID=mm1.MarkaModelID
inner join Fiyat f on f.VarlikID=v.VarlikID
inner join ParaBirimi pb on f.ParaBirimiID = pb.ParaBirimiID
where DepoID =1 and f.AktifMi='True';


--Belli Bir ParaBirimine Göre VArlýlarý LÝs
select mm1.MarkaModelAdi,mm.MarkaModelAdi,vg.VarlikGrubuAdi,f.ParaMiktari  from Varlik v
inner join MarkaModel mm on v.MarkaModelID=mm.MarkaModelID
inner join MarkaModel mm1 on mm.UstMarkaModelID=mm1.MarkaModelID
inner join Fiyat f on f.VarlikID=v.VarlikID
inner join ParaBirimi pb on f.ParaBirimiID = pb.ParaBirimiID
inner join VarlikGrubu vg on v.VarlikGrubuID = vg.VarlikGrubuID
where pb.ParaBirimAdi ='TL' and f.AktifMi = 'True'

