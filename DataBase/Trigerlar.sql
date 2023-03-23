
create trigger TRG_FiyatEklendi
on Fiyat
after insert 
as 
begin
declare @varlikID int
declare @fiyatID int
    select @varlikID = VarlikID from inserted
    select @fiyatID = FiyatID from inserted
    update Fiyat 
    set AktifMi = 'False'
    where VarlikID= @varlikID

    update Fiyat
    set AktifMi = 'True'
    where FiyatID = @fiyatID
end 
------------------------------------
-- Varlikdepoya eklenirken urundurumu depoda yapacak.
create trigger TRG_DepoEklendi
on VarlikDepo
after insert 
as 
begin
declare @varlikID int
    select @varlikID = VarlikID from inserted

    update Varlik 
    set VarlikDurumuID = 1
    where VarlikID= @varlikID
end 
---------------------------------------------
-- Zimmete varl�k eklendi�inde varl�kdepodan aktifli�i false yapan trigger.
create trigger TRG_ZimmetEklendi
on Zimmet
after insert 
as 
begin
declare @varlikID int
declare @varlikDepoID int
    select @varlikDepoID = VarlikDepoID from inserted

    update VarlikDepo 
    set AktifMi = 'false'
    where VarlikDepoID= @varlikDepoID
end 
---------------------------------------------
-- Varl�kdepo tablosunda aktifli�i false olan varl�klar�n durumunu zimmette olarak de�i�tiren trigger.
create trigger TRG_VarlikDurumZimmetlendiYap
on VarlikDepo
after update 
as 
begin
declare @varlikID int
declare @aktifMi bit
    select @varlikID = VarlikID from inserted
    select @aktifMi = AktifMi from inserted

    if @aktifMi = 'False'
    begin
    update Varlik 
    set VarlikDurumuID = 2
    where VarlikID= @varlikID
    end
end 

-----------------------------------------------
-- Varlik t�ketildi�inde varlik durumunu sat�ld� olarak i�aretleyecek.
create trigger TRG_VarlikTuket
on MusteriVarlik
after insert 
as 
begin
declare @varlikID int
    select @varlikID = Varl�kID from inserted

    update Varlik 
    set VarlikDurumuID = 3
    where VarlikID= @varlikID
end