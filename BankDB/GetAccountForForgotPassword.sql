CREATE PROCEDURE [dbo].[GetAccountForForgotPassword]
	@Username varchar(20),
	@Email varchar(50)
AS
BEGIN

	SET NOCOUNT ON;

    select * 
	from Accounts where Username = @Username and Email = @Email;
END
GO
