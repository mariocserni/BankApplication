CREATE PROCEDURE [dbo].[GetAllWithdraws]
	@Id int
AS
BEGIN

	SET NOCOUNT ON;

    select * from Withdraws where AccountId = @Id
END
GO
