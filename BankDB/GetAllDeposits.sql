CREATE PROCEDURE [dbo].[GetAllDeposits]
	@Id int
AS
BEGIN

	SET NOCOUNT ON;

    select * from Deposits where AccountId = @Id
END
GO
