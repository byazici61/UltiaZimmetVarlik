
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
-- Zimmete varlýk eklendiðinde varlýkdepodan aktifliði false yapan trigger.
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
-- Varlýkdepo tablosunda aktifliði false olan varlýklarýn durumunu zimmette olarak deðiþtiren trigger.
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
-- Varlik tüketildiðinde varlik durumunu satýldý olarak iþaretleyecek.
create trigger TRG_VarlikTuket
on MusteriVarlik
after insert 
as 
begin
declare @varlikID int
    select @varlikID = VarlýkID from inserted

    update Varlik 
    set VarlikDurumuID = 3
    where VarlikID= @varlikID
end