USE [BankDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spBankDatabase_DeleteCustomer]    Script Date: 3/2/2022 2:27:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spBankDatabase_DeleteCustomer]

	@CustomerId INT
AS
BEGIN
	
SET NOCOUNT ON
	
		BEGIN TRANSACTION
				
		DELETE FROM Customers
		WHERE Customers.Id = @CustomerId
		
		IF(@@ERROR > 0)
		
		BEGIN
		ROLLBACK TRANSACTION
		END
		ELSE
		BEGIN
		COMMIT TRANSACTION
		END

END