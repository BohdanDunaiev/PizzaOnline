CREATE PROCEDURE [dbo].[GetAllOrders]
@P_tableName nvarchar(50) = null
AS
BEGIN
	SET NOCOUNT ON;
	
	declare @V_table nvarchar(50) = null
	if (@P_tableName is not null)
		select @V_table = QUOTENAME( TABLE_NAME )
		FROM INFORMATION_SCHEMA.TABLES
		WHERE TABLE_NAME = @P_tableName

	declare @V_sql as nvarchar(MAX) = null
	if (@V_table is not null)
		select @V_sql = 'select * from ' + @V_table + ';'

	if(@V_sql is not null)
		exec(@V_sql)
	else
		select -1;
END