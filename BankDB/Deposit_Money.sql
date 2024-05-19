CREATE PROCEDURE [dbo].[Deposit_Money] 
	@AccountId int,
	@Amount decimal
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update Accounts
	set [Money] = [Money] + @Amount
	where Id = @AccountId
END
GO
