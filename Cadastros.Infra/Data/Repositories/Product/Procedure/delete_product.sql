﻿CREATE PROC delete_product
	@ID INT
AS
BEGIN
	DELETE product WHERE ID = @ID
END