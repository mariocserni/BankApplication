CREATE PROCEDURE [dbo].[Accounts_Insert]
	@Username varchar(20),
	@FirstName varchar(20),
	@LastName varchar(20),
	@Password varchar(50),
	@Email varchar(50),
	@Age int,
	@Money decimal,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into Accounts(Username, FirstName, LastName, [Password], Email, Age, [Money])
	values (@Username, @FirstName, @LastName, @Password, @Email, @Age, @Money);

	select @id = SCOPE_IDENTITY()
END
GO