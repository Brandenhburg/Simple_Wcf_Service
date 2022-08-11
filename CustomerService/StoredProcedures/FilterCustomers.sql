USE [BankDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spBankDatabase_FilterCustomers]    Script Date: 8/10/2022 7:37:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spBankDatabase_FilterCustomers]

@Column VARCHAR(50),
@SubStringValue VARCHAR(50)

AS

DECLARE @CMD NVARCHAR(1500)
DECLARE @InputParam VARCHAR(52)



SET @CMD = 'IF NOT EXISTS(SELECT Customers.Id, Customers.Firstname, Customers.Lastname, Customers.Email, Customers.JoinedOnDate, 
				CurrentAccounts.CurrentBalance , SavingsAccounts.SavingsBalance
				FROM Customers
				JOIN CurrentAccounts ON Customers.Id = CurrentAccounts.Customer_Id
				JOIN SavingsAccounts ON Customers.Id = SavingsAccounts.Customer_Id
				WHERE Customers.' + @Column + ' LIKE @SubStringValue)' +

			' SELECT Customers.Id, Customers.Firstname, Customers.Lastname, Customers.Email, Customers.JoinedOnDate, 
				CurrentAccounts.CurrentBalance , SavingsAccounts.SavingsBalance
				FROM Customers
				JOIN CurrentAccounts ON Customers.Id = CurrentAccounts.Customer_Id
				JOIN SavingsAccounts ON Customers.Id = SavingsAccounts.Customer_Id' + 

		   ' ELSE SELECT Customers.Id, Customers.Firstname, Customers.Lastname, Customers.Email, Customers.JoinedOnDate, 
				CurrentAccounts.CurrentBalance , SavingsAccounts.SavingsBalance
				FROM Customers
				JOIN CurrentAccounts ON Customers.Id = CurrentAccounts.Customer_Id
				JOIN SavingsAccounts ON Customers.Id = SavingsAccounts.Customer_Id
				WHERE Customers.' + @Column + ' LIKE @SubStringValue';

SET @InputParam  = '%' + @SubStringValue + '%'


EXEC sp_executesql @CMD, N'@SubStringValue VARCHAR(50)', @SubStringValue=@InputParam