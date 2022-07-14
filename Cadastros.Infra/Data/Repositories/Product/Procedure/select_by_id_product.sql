CREATE PROC select_by_id_product
	@ID INT
AS
BEGIN
		SELECT id, created_at, name_product, price, brand, update_at 
		FROM product 
		WHERE id = @ID
END