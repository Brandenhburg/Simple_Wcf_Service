USE [BankDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spBankDatabase_DepositToSavingsAccount]    Script Date: 3/2/2022 2:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spBankDatabase_DepositToSavingsAccount]

@CustomerId INT,
@Funds decimal

AS
BEGIN

	SET NOCOUNT ON
		BEGIN TRANSACTION

		UPDATE SavingsAccounts


		SET SavingsBalance = SavingsBalance + @Funds
		WHERE SavingsAccounts.Customer_Id = @CustomerId
		IF(@@ERROR > 0)
		BEGIN ROLLBACK TRANSACTION
		END
		ELSE
		BEGIN
		COMMIT TRANSACTION
		END

END

