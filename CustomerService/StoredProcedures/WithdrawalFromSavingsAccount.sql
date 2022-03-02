USE [BankDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spBankDatabase_WithdrawalFromSavingsAccount]    Script Date: 3/2/2022 2:33:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spBankDatabase_WithdrawalFromSavingsAccount]

@CustomerId INT,
@RequestedFunds decimal

AS
BEGIN

	SET NOCOUNT ON
		BEGIN TRANSACTION
		

		UPDATE SavingsAccounts		
		SET SavingsBalance = SavingsBalance - @RequestedFunds
		WHERE SavingsAccounts.Customer_Id = @CustomerId

		iF(@@ERROR > 0)
		BEGIN ROLLBACK TRANSACTION
		END
		ELSE
		BEGIN
		COMMIT TRANSACTION
		END
	
END