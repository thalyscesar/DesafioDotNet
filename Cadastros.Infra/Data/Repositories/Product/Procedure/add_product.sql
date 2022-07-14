CREATE PROC dbo.add_product
	@CREATEDAT     DATE,
    @NAME          VARCHAR (50) ,
    @PRICE		   MONEY,
    @BRAND         VARCHAR (30),
    @UPDATEAT	   DATE
AS
BEGIN
	INSERT INTO dbo.product(created_at, name_product, price, brand, update_at) 
	VALUES (@CREATEDAT, @NAME, @PRICE, @BRAND, @UPDATEAT)

	SELECT SCOPE_IDENTITY()
END