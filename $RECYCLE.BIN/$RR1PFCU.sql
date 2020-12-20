 


GO
 create or alter procedure sp_Max1 @so1 int, @so2 int, @Max int OUT as 
BEGIN
    if(@so1 < @so2)
    SET @Max = @so2
    print 'So lon nhat la :' + ' ' + CONVERT(nvarchar(20), @Max); 

    if(@so1 > @so2)
    SET @Max = @so1
    print 'So lon nhat la :' + ' ' + CONVERT(nvarchar(20), @Max) ;
END
DECLARE @S1 int, @S2 int , @M INT 
Set @S1 = 3; Set @S2 = 5
EXECUTE sp_Max1 @S1, @S2 , @M out 

Go 
/*cau 11 */
create or alter procedure sp_MaxMin @so1 int, @so2 int,@Max int out,@Min int out as 
BEGIN
   
    IF(@so1 < @so2)
        Begin
        Set @Max = @so2;
        END;
    ELSE
        BEGIN
       
        Set @Min = @so1
        end;
END
DECLARE @S1 int,@S2 INT,@Lon int , @Be int
Set @S1 = 5; Set @S2 = 3
EXECUTE sp_MaxMin @S1, @S2 , @Lon out , @Be out
PRINT('So lon nhat la : ' + ' ' +CONVERT(NVARCHAR(20), @Max));
PRINT('So be nhat la :' + '' + convert(nvarchar(20),@Min));
go 
/*Cau 12 */
CREATE or ALTER PROCEDURE sp_PrintN @n int OUT AS 
BEGIN
    DECLARE @printNumber int;
    Set @printNumber = 0;
    While @printNumber < @n
        BEGIN
            PRINT convert(nvarchar(20),@printNumber)
            Set @printNumber = @printNumber + 1 ;
            
        END;
END
DECLARE @SoN INT
Set @SoN = 10
EXECUTE sp_PrintN @SoN out
go
/*cau 13 */
CREATE or ALTER PROCEDURE sp_PrintNchan @N int, @sum int out   AS 
BEGIN
DECLARE @printNumber int = 2;

    While @printNumber < @N
            BEGIN
            
            Set @sum = @sum + @printNumber;
            Set @printNumber = @printNumber + 2 ;
            END;
            
 END
 DECLARE @soN INT, @sum1 int 
 SET @soN = 10 ; Set @sum1 = 0 
 EXECUTE sp_PrintNchan @soN ,@sum1 out
 print 'Tong so chan la ' + ' ' + CONVERT(nvarchar(20),@sum1);
Go
/* cau 14 */
CREATE or ALTER PROCEDURE sp_PrintNSum @N int ,@Sum int OUT, @Count int out   AS 
BEGIN
DECLARE @printNumber int = 2;

    While @printNumber <= @N
            BEGIN
            Set @sum = @sum + @printNumber;
            Set @printNumber = @printNumber + 2 ;
            Set @count = @count + 1 ;
            END;
            
 END
 DECLARE @soN INT, @sum1 INT,@count1 INT
 SET @soN = 10;Set @sum1 = 0; Set @count1 = 0
 EXECUTE sp_PrintNSum @soN , @sum1 out, @count1 out
  PRINT 'Tong so chan la :'+''+ CONVERT(nvarchar(20),@sum1)
  PRINT 'So luong cua so chan la : '+ ' ' + CONVERT(nvarchar(20),@count1)
GO
  /* Cau 20 */
  CREATE OR ALTER PROCEDURE spud_InBangCC @n int  out AS
  DECLARE @a int , @i int 
  SET @a = 1; 
  BEGIN
        WHILE @a <= 10
            BEGIN
                SET @i = @a * @n ;
                PRINT CAST(@n as nvarchar(20)) + 'x' + CAST(@a as nvarchar(20)) + '=' + CAST(@i as nvarchar(20))
            END
                 SET @a += 1;
            
    END;

  EXECUTE spud_InBangCC 2
 
  