create PROCEDURE [dbo].[GetOrderById]
  -- Add the parameters for the stored procedure here
  @P_tableName nvarchar(50) = null,
  @P_Id bigint = null
AS
BEGIN
  SET NOCOUNT ON;
  
  Declare @V_sql as nvarchar(MAX) = null
  if (@P_Id is not null)
    select @V_sql = 'select * from ' + @P_tableName + ' where Id = ' + CAST(@P_Id AS NVARCHAR(10)) + ';'

  if(@V_sql is not null)
    exec(@V_sql)
  else
    select -1;
END