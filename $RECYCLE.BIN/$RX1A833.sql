CREATE TRIGGER INSERT_UPDATE_PENELTY
On PENELTY 
FOR INSERT, UPDATE AS
DECLARE @solan int 
select @solan = count(a.MAPHAT)
from PENELTY A , INSERTED B
WHERE A.MaCauThu = B.MaCauThu and 
A.NgayPhat = B.NgayPhat and 
B.LoaiThe = 'D'
GROUP BY B.MaCauThu,B.NgayPhat
if(@solan >1)
    BEGIN 
        ROLLBACK TRAN 
        Print'Khong thuc hien duoc ! Cau thu nay da bi phat roi'
    END
ELSE
    Print('Thanh cong')
GO
/*Cau3 */
ALTER Table CauThu ADD CONSTRAINT CHECK_TUOI CHECK( 17<= DATEDIFF(year,Convert(DATETIME,NgaySinh,103),GetDate()) AND DATEDIFF(year,Convert(DATETIME,NgaySinh,103),GetDate()) <=35)

SELECT * FROM CauThu
GO
/* Cau4 */
CREATE TRIGGER INSERT_UPDATE_NGAYPHAT
ON PENELTY
FOR INSERT, UPDATE 
AS DECLARE @solan int 
select @solan = count(A.MaPhat)
from PENELTY A , CauThu C
WHERE Convert([datetime],A.NgayPhat,103) > convert([datetime],C.NgaySinh,103) and A.MaCauThu = C.MaCauThu AND A.LoaiThe = 'D'
if(@solan > 1)
            BEGIN 
        ROLLBACK TRAN 
        Print'Khong thuc hien duoc ! Cau thu nay da bi phat roi'
    END
ELSE
    Print('Thanh cong')
GO  

/*cau 5 */
Alter table DoiBong ADD CONSTRAINT CHECK_NAMTL CHECK (NamTL <= year(GetDate()))

alter table DoiBong
drop CONSTRAINT CHECK_NamTL

Insert  DoiBong(MaDoi,TenDoi,NamTL)
VALUES (4,'Loser',2020)

UPDATE DoiBong
SET MaDoi = 4 , TenDoi ='NamNguyen', NamTL = 2020
GO
/*cau7*/
CREATE TRIGGER INSERT_UPDATE_TienPhat
ON PENELTY
FOR INSERT, UPDATE 
AS DECLARE @loaithe nvarchar(20),@tienphat int
select @loaithe = P.LoaiThe, @tienphat = P.TienPhat
From PENELTY P,CauThu C
WHERE p.LoaiThe = 'D' and P.TienPhat = 10000000 and P.MaCauThu = C.MaCauThu
if(@tienphat = '1000000' and @loaithe = 'D')
BEGIN
    ROLLBACK TRAN
    PRINT 'Tien phat vuot qua cho phep!! insert lai de'
    END
ELSE
    PRINT'Thanh cong'
    Go

Insert PENELTY (MaPhat,MaCauThu,TienPhat,LoaiThe,NgayPhat)
VALUES ('5','5','1000000','D','2018-02-14 00:00:00.000')

