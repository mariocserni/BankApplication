CREATE PROCEDURE [dbo].[Transfer_Money] 
	@AccountThatReceivesMoneyId int,
	@AccountThatSendsMoney int,
	@Amount decimal
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update Accounts
	set [Money] = [Money] + @Amount
	where Id = @AccountThatReceivesMoneyId

	update Accounts
	set [Money] = [Money] - @Amount
	where Id = @AccountThatSendsMoney
END
GO
