CREATE PROCEDURE [dbo].[spProduct_GetAll]
	
AS
begin
set nocount on;

	SELECT Id, ProductName,[Location]
	FROM dbo.Product
	ORDER BY ProductName;
end
