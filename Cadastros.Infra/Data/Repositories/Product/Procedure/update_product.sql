CREATE PROC dbo.update_product
	@CREATEDAT     DATE,
    @NAME          VARCHAR (50) ,
    @PRICE		   MONEY,
    @BRAND         VARCHAR (30),
    @UPDATEAT	   DATE,
	@ID            INT
AS
BEGIN
	UPDATE dbo.product SET 
		created_at = @CREATEDAT,
		name_product = @NAME,
		price = @PRICE, 
		brand = @BRAND, 
		update_at = @UPDATEAT
	WHERE id = @ID
END