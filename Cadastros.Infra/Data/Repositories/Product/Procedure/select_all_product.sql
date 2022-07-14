CREATE PROC select_all_product
AS
BEGIN
		SELECT id, created_at, name_product, price, brand, update_at 
		FROM product
END