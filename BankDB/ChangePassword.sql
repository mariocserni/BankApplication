CREATE PROCEDURE [dbo].[ChangePassword] 
	@NewPassword nvarchar(50),
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update Accounts
	set [Password] = @NewPassword
	where Id = @Id
END
GO