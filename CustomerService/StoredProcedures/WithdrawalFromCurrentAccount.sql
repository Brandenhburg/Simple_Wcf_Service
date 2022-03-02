USE [BankDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spBankDatabase_WithdrawalFromCurrentAccount]    Script Date: 3/2/2022 2:31:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spBankDatabase_WithdrawalFromCurrentAccount]

	@CustomerId INT,
	@Funds DECIMAL

AS
BEGIN
		SET NOCOUNT ON 
		BEGIN TRANSACTION

			
		UPDATE CurrentAccounts
		SET CurrentBalance = CurrentBalance - @Funds
		WHERE CurrentAccounts.Customer_Id = @CustomerId

		IF (@@ERROR > 0)
		BEGIN ROLLBACK TRANSACTION
		END
		ELSE
		BEGIN
		COMMIT TRANSACTION
		END
END