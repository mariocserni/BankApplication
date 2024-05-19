CREATE PROCEDURE [dbo].[GetAccountForLogin]
	@Username varchar(20),
	@Password varchar(50)
AS
BEGIN

	SET NOCOUNT ON;

    select * 
	from Accounts where Username = @Username and [Password] = @Password;
END
GO
