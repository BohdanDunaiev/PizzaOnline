
CREATE PROCEDURE deleteOrder
	@Id int
	as
	delete from Orders where Id = @Id
