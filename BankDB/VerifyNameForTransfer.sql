CREATE PROCEDURE [dbo].[VerifyNameForTransfer]
	@Username varchar(20)
AS
BEGIN

	SET NOCOUNT ON;

    select * 
	from Accounts
	where Username = @Username
END
GO
