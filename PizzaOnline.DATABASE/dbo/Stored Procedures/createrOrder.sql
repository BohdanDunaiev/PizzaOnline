CREATE PROCEDURE createrOrder	
	@Id int,
	@orderId int,
	@customerId	int,
	@pizzaId int,
	@pizzeriaId int,
	@deliveryId int
AS
INSERT INTO Orders VALUES(@Id, @orderId, @customerId, @pizzaId, @pizzeriaId, @deliveryId)
