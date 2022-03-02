USE [BankDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spBankDatabase_AddNewCustomer]    Script Date: 3/2/2022 2:21:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spBankDatabase_AddNewCustomer]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Email NVARCHAR(50),
	@JoinedOnDate NVARCHAR(50),
	@CurrentAccountBalance DECIMAL,
	@SavingsAccountBalance DECIMAL

AS
BEGIN

	SET NOCOUNT ON
	
	BEGIN TRANSACTION
		
	INSERT INTO Customers(FirstName, LastName, Email, JoinedOnDate)
	VALUES(@FirstName, @LastName, @Email, @JoinedOnDate)

	INSERT INTO CurrentAccounts(CurrentBalance,  CustomerEmail, Customer_Id)
	VALUES(@CurrentAccountBalance, @Email ,(SELECT Customers.Id FROM Customers WHERE Customers.Email = @Email))

	INSERT INTO SavingsAccounts(SavingsBalance, CustomerEmail, Customer_Id)
	VALUES(@SavingsAccountBalance, @Email, (SELECT Customers.Id FROM Customers WHERE Customers.Email = @Email))

	IF(@@ERROR > 0)

	BEGIN
	ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN
	COMMIT TRANSACTION
	END

END