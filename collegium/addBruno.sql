USE [C:\USERS\BRUNO DBS\DESKTOP\CA\202002-CA\COLLEGIUM\COLLEGIUM\MYDB.MDF]
GO

DECLARE	@return_value Int,
		@responseMessage varchar(250)

EXEC	@return_value = [dbo].[uspAddUser]
		@pLoginName = N'bruno',
		@pPassword = N'bruno',
		@pFirstName = N'Bruno',
		@pLastName = N'Santos',
		@pActiveUser = N'admin',
		@responseMessage = @responseMessage OUTPUT

SELECT	@responseMessage as N'@responseMessage'

SELECT	@return_value as 'Return Value'

GO

select * from Logs