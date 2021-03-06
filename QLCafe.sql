CREATE DATABASE QLCAFE
GO


USE QLCAFE
GO

CREATE TABLE Tablefood(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	status NVARCHAR(100) DEFAULT N'Trống'
)
GO

CREATE TABLE Account(
	id INT IDENTITY PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL,
	UserName NVARCHAR(100),
	Password NVARCHAR(1000),
	Type INT
	
)
GO	
CREATE TABLE FoodCategory(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)
)
GO

CREATE TABLE Food(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	idCategory INT,
	price DECIMAL DEFAULT 0
	
)
GO	

CREATE TABLE Bill(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE,
	DateCheckOut DATE,
	idTable INT,
	status INT
	FOREIGN KEY (idTable) REFERENCES dbo.Tablefood(id)
	
	
)
GO	
 CREATE TABLE BillInfo(
	id INT IDENTITY PRIMARY KEY,
	idBill INT,
	idFood	INT,
	count1 INT
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
 )
GO

------------------------------Create proc-----------------------------------------


--CREATE PROC insertdata
--AS
--BEGIN
--DECLARE @i INT;
--SET @i=0;
--WHILE @i<10
--	BEGIN
--	INSERT	INTO dbo.Account
--	        ( 
--	          DisplayName ,
--	          UserName 
	          
--	        )
--	VALUES  ( 
--	          N'LaiQuangSon' , -- DisplayName - nvarchar(100)
--	          N'LaiQuangSon' -- UserName - nvarchar(100)
	          
--	        )
--	        SET @i=@i+1;
--	END;

--END;
--GO

--EXEC dbo.insertdata
------------------Account---------------------------
CREATE PROC getAccount(@DisplayName NVARCHAR(50),@UserName NVARCHAR(50))
AS
BEGIN
SELECT * FROM dbo.Account WHERE DisplayName=@DisplayName AND UserName=@UserName
END;
GO


------------------End Account--------------------------
-------Bill-----------------
CREATE PROC getBillById(
@id INT)
AS
	SELECT * FROM dbo.Bill WHERE id=@id
GO

---EXEC dbo.getBillById @id = 1 -- int
CREATE PROC getBillByDateCheckIn(
@startDate DATE,
@endDate DATE)
AS
SELECT * FROM dbo.Bill WHERE DateCheckIn>=@startDate AND DateCheckIn<=@endDate
GO

---EXEC dbo.getBillByDateCheckIn @startDate = '2020-03-03', -- date @endDate = '2020-03-03' -- date
 CREATE PROC getBillByDateCheckout(
@startDate DATE,
@endDate DATE)
AS
SELECT * FROM dbo.Bill WHERE DateCheckOut>=@startDate AND DateCheckout<=@endDate
GO


CREATE PROC getBillByTableStatus
(
	@idTable INT,
	@status INT
)
AS
BEGIN
	IF @status=0
	SELECT * FROM dbo.Bill WHERE idTable=@idTable
	ELSE
	SELECT * FROM dbo.Bill WHERE idTable=@idTable AND
	 status=@status
END
GO

 EXEC dbo.getBillByTableStatus @idTable = 1, -- int
     @status = 0 -- int
 

----End Bill------------
------BillInfo-
CREATE PROC getBillInfoIdBill(
@idBill int)
AS
SELECT * FROM dbo.BillInfo WHERE idBill=@idBill
GO

----End Billinfo-
----------Table--------------------
CREATE PROC getTable
AS
SELECT * FROM dbo.Tablefood
GO

EXEC dbo.getTable

----------End Table--------------------
----------FoodCategory------------------
CREATE PROC	getFoodCategory
AS
SELECT * FROM dbo.FoodCategory
GO


----------End FoodCategory------------------
----------Food------------------
CREATE PROC getFoodById(
	@id INT
)
AS
	SELECT * FROM dbo.Food WHERE id=@id
GO

EXEC dbo.getFoodById 1 -- int

alter proc getFoodByCate(
@id int)
as
select * from Food where idCategory=@id
go


----------End Food------------------

-------------Insert--------------