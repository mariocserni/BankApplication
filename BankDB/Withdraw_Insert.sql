CREATE PROCEDURE [dbo].[Withdraw_Insert]
	@Amount decimal,
	@WithdrawDate nvarchar(50),
	@AccountId int,
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	insert into Withdraws(Amount, WithdrawDate, AccountId)
	values (@Amount, @WithdrawDate, @AccountId);

	select @id = SCOPE_IDENTITY()
    
END
GO
