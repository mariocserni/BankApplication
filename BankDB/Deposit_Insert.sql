CREATE PROCEDURE [dbo].[Deposit_Insert]
	@Amount decimal,
	@DepositDate nvarchar(50),
	@AccountId int,
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	insert into Deposits(Amount, DepositDate, AccountId)
	values (@Amount, @DepositDate, @AccountId);

	select @id = SCOPE_IDENTITY()
    
END
GO
