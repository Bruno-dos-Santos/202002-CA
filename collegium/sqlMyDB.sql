DROP PROCEDURE uspAddLog;
DROP PROCEDURE uspAddStudent;
DROP PROCEDURE uspAddUser;
DROP PROCEDURE uspDeleteStudent;
DROP PROCEDURE uspDeleteUser;
DROP PROCEDURE uspGetAllStudents;
DROP PROCEDURE uspUpdateStudent;
DROP PROCEDURE uspUpdateUser;
DROP PROCEDURE uspLogin;

DROP TABLE Logs;
DROP TABLE Students;
Drop Table Users;

go

CREATE TABLE dbo.Logs
(
    LogID INT IDENTITY(1,1) NOT NULL,
    LoginName VARCHAR(20) NOT NULL,
    EventDateTime DATETIME NOT NULL
                DEFAULT CURRENT_TIMESTAMP,
    TypeEvent VARCHAR(20) NULL,
    Operation VARCHAR(10) NULL, 
    TableName VARCHAR(20) NULL,  
    EventInfo VARCHAR(100) NOT NULL,
    CONSTRAINT [PK_Log_LogID] PRIMARY KEY (LogID)
)

GO
CREATE PROCEDURE dbo.uspAddLog
    @pLoginName VARCHAR(20),
    @pEvent VARCHAR(100),
    @pType VARCHAR(20) = NULL, 
    @pOperation VARCHAR(10) = NULL, 
    @pTable VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY

        INSERT INTO dbo.Logs (LoginName, EventInfo, TypeEvent, Operation, TableName)
        VALUES(@pLoginName, @pEvent, @pType, @pOperation, @pTable );

        DECLARE @responseMessage varchar(100);
        SET @responseMessage='Success';

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH

END

GO

CREATE TABLE dbo.Users
(
    UserID INT IDENTITY(1,1) NOT NULL,
    LoginName VARCHAR(20) NOT NULL,
	Salt UNIQUEIDENTIFIER NOT NULL,
    PasswordHash BINARY(64) NOT NULL,
    FirstName VARCHAR(20) NULL,
    LastName VARCHAR(20) NULL,
    isDeleted bit NOT NULL default 0,
    CONSTRAINT [PK_User_UserID] PRIMARY KEY (UserID),
	CONSTRAINT [AK_User_LoginName] UNIQUE (LoginName)
)

go
CREATE PROCEDURE dbo.uspAddUser
    @pLoginName VARCHAR(20), 
    @pPassword VARCHAR(50), 
    @pFirstName VARCHAR(20) = NULL, 
    @pLastName VARCHAR(20) = NULL,
    @pActiveUser VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON

	DECLARE @salt UNIQUEIDENTIFIER=NEWID() 
    
	BEGIN TRY

        INSERT INTO dbo.Users(LoginName, PasswordHash, Salt, FirstName, LastName)
        VALUES(@pLoginName, HASHBYTES('SHA2_512', @pPassword+CAST(@salt AS NVARCHAR(36))), @salt, @pFirstName, @pLastName);

        DECLARE @responseMessage varchar(20)
        SET @responseMessage='Success';
        
        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,
          @pEvent      = @pLoginName,
          @pType       = 'Info',
          @pOperation  = 'Insert',
          @pTable      = 'User';
           
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @responseMessage, 
          @pType       = 'Error',
          @pOperation  = 'Insert',
          @pTable      = 'User';
    END CATCH

END
go

CREATE TABLE dbo.Students
(
    StudentID INT IDENTITY(1,1) NOT NULL,
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    Email VARCHAR(40) NOT NULL,
    Phone VARCHAR(10) NOT NULL,
    AddressLine1 VARCHAR(40) NOT NULL,
    AddressLine2 VARCHAR(40) NULL,
    City VARCHAR(20) NOT NULL,
    County VARCHAR(20) NOT NULL,
	Country VARCHAR(20) NOT NULL, 
    Level VARCHAR(10) NOT NULL,
    Course VARCHAR(20) NOT NULL,
    StudentNumber INT NOT NULL,
    Created_at DATETIME NOT NULL
                DEFAULT CURRENT_TIMESTAMP, 
    isDeleted int NOT NULL default 0,
    CONSTRAINT [PK_Student_StudentID] PRIMARY KEY (StudentID),
	CONSTRAINT [AK_Student_StudentNumber] UNIQUE (StudentNumber)
)

go
CREATE PROCEDURE dbo.uspAddStudent
    @pFirstName VARCHAR(20),
    @pLastName VARCHAR(20),
    @pEmail VARCHAR(40),
    @pPhone VARCHAR(10),
    @pAddressLine1 VARCHAR(40),
    @pAddressLine2 VARCHAR(40),
    @pCity VARCHAR(20),
    @pCounty VARCHAR(20),
	@pCountry VARCHAR(20),
    @pLevel VARCHAR(10),
    @pCourse VARCHAR(20),
    @pStudentNumber INT,
    @pActiveUser VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY
        
        INSERT INTO dbo.Students(FirstName, LastName, Email, Phone, AddressLine1, AddressLine2,City, County, Country, Level, Course, StudentNumber)
        VALUES(@pFirstName, @pLastName, @pEmail, @pPhone, @pAddressLine1, @pAddressLine2,@pCity, @pCounty, @pCountry, @pLevel, @pCourse, @pStudentNumber);

        DECLARE @responseMessage varchar(100);
        SET @responseMessage='Success';

        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @pStudentNumber, 
          @pType       = 'Info',
          @pOperation  = 'Insert',
          @pTable      = 'Student';

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @responseMessage, 
          @pType       = 'Error',
          @pOperation  = 'Insert',
          @pTable      = 'Student';
    END CATCH

END
go

CREATE PROCEDURE dbo.uspGetAllStudents
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY
        select * from Students where isDeleted = 0

    END TRY
    BEGIN CATCH
    END CATCH

END
go

CREATE PROCEDURE dbo.uspUpdateStudent
    @pFirstName VARCHAR(20),
    @pLastName VARCHAR(20),
    @pEmail VARCHAR(40),
    @pPhone VARCHAR(10),
    @pAddressLine1 VARCHAR(40),
    @pAddressLine2 VARCHAR(40),
    @pCity VARCHAR(20),
    @pCounty VARCHAR(20),
	@pCountry VARCHAR(20),
    @pLevel VARCHAR(10),
    @pCourse VARCHAR(20),
    @pStudentNumber INT,
    @pActiveUser VARCHAR(20) = NULL

AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY
      
        UPDATE Students
        SET FirstName = @pFirstName,
            LastName = @pLastName,
            City = @pCity,
            Email = @pEmail,
            Phone = @pPhone,
            AddressLine1 = @pAddressLine1,
            AddressLine2 = @pAddressLine2,
            County = @pCounty,
			Country = @pCountry,
            Level = @pLevel,
            Course = @pCourse
        where
            StudentNumber = @pStudentNumber;

        DECLARE @responseMessage varchar(100);
        SET @responseMessage='Success';

        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @pStudentNumber, 
          @pType       = 'Info',
          @pOperation  = 'Update',
          @pTable      = 'Students';

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @responseMessage, 
          @pType       = 'Error',
          @pOperation  = 'Update',
          @pTable      = 'Students';
    END CATCH

END
go

CREATE PROCEDURE dbo.uspDeleteStudent
    @pStudentNumber int,
	@pActiveUser VARCHAR(20) = NULL

AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY
        update Students
        set isDeleted = 1
        where StudentNumber = @pStudentNumber;

        DECLARE @responseMessage varchar(100);
        SET @responseMessage='Success';

        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @pStudentNumber, 
          @pType       = 'Info',
          @pOperation  = 'Delete',
          @pTable      = 'Students';
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @responseMessage, 
          @pType       = 'Error',
          @pOperation  = 'Delete',
          @pTable      = 'Students';
    END CATCH

END
go

CREATE PROCEDURE dbo.uspUpdateUser
    @pUserID int,
    @pLoginName VARCHAR(20), 
    @pPassword VARCHAR(50), 
    @pFirstName VARCHAR(20) = NULL, 
    @pLastName VARCHAR(20) = NULL,
	@pActiveUser VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY

        UPDATE Users
        SET LoginName = @pLoginName,
            PasswordHash = HASHBYTES('SHA2_512', @pPassword),
            FirstName = @pFirstName,
            LastName = @pLastName
        WHERE
            UserID = @pUserId

        DECLARE @responseMessage varchar(20)
        SET @responseMessage='Success';
        
        EXEC dbo.uspAddLog
		  @pLoginName = @pActiveUser,  
          @pEvent      = @pLoginName, 
          @pType       = 'Info',
          @pOperation  = 'Update',
          @pTable      = 'User';
           
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        EXEC dbo.uspAddLog
		  @pLoginName  = @pActiveUser,  
          @pEvent      = @responseMessage,
          @pType       = 'Error',
          @pOperation  = 'Update',
          @pTable      = 'User';
    END CATCH

END
go

CREATE PROCEDURE dbo.uspDeleteUser
    @pUserID int,
    @pLoginName VARCHAR(20), 
	@pActiveUser VARCHAR(20) = NULL

AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY
        update Users
        set isDeleted = 1
        where UserID = @pUserID;

        DECLARE @responseMessage varchar(100);
        SET @responseMessage='Success';

        EXEC dbo.uspAddLog
		  @pLoginName  = @pActiveUser,  
          @pEvent      = @pLoginName,
          @pType       = 'Info',
          @pOperation  = 'Delete',
          @pTable      = 'Users';
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        EXEC dbo.uspAddLog
		  @pLoginName  = @pActiveUser,  
          @pEvent      = @responseMessage, 
          @pType       = 'Error',
          @pOperation  = 'Delete',
          @pTable      = 'Users';
    END CATCH

END

go

CREATE PROCEDURE dbo.uspLogin
    @pLoginName NVARCHAR(20),
    @pPassword NVARCHAR(50),
    @responseMessage NVARCHAR(100)='' OUTPUT
AS
BEGIN

    SET NOCOUNT ON

    DECLARE @userID INT

    IF EXISTS (SELECT TOP 1 UserID FROM [dbo].[Users] WHERE LoginName=@pLoginName)
    BEGIN
        SET @userID=(SELECT UserID FROM [dbo].[Users] WHERE LoginName=@pLoginName AND PasswordHash=HASHBYTES('SHA2_512', @pPassword+CAST(Salt AS NVARCHAR(36))))

       IF(@userID IS NULL)
          SET @responseMessage='Incorrect password'
       ELSE 
           SET @responseMessage='User successfully logged in'
    END
    ELSE
       SET @responseMessage='Invalid login'
	
	
    EXEC dbo.uspAddLog
		  @pLoginName  = @pLoginName,  
          @pEvent      = @responseMessage, 
          @pType       = 'Info',
          @pOperation  = 'Login',
          @pTable      = 'Users';
 
END

go

-- adding default data over the tables.
EXEC [dbo].[uspAddUser]
		@pLoginName = N'bruno',
		@pPassword = N'bruno',
		@pFirstName = N'Bruno',
		@pLastName = N'Santos',
		@pActiveUser = N'admin';

EXEC [dbo].[uspAddUser]
		@pLoginName = N'admin',
		@pPassword = N'admin',
		@pFirstName = N'Admin',
		@pLastName = N'DBS',
		@pActiveUser = N'bruno';

EXEC [dbo].[uspAddUser]
		@pLoginName = N'paul',
		@pPassword = N'paul',
		@pFirstName = N'Paul',
		@pLastName = N'Laird',
		@pActiveUser = N'bruno';


EXEC	[dbo].[uspAddStudent]
		@pFirstName = N'Joe ',
		@pLastName = N'Smith',
		@pEmail = N'joe.smith@gmail.com',
		@pPhone = N'0899858096',
		@pAddressLine1 = N'Address 1',
		@pAddressLine2 = N'Address 2',
		@pCity = N'Dublin',
		@pCounty = N'Dublin',
		@pCountry = N'Ireland',
		@pLevel = N'Undergrad',
		@pCourse = N'Software Development',
		@pStudentNumber = 1712345,
		@pActiveUser = N'admin';

EXEC	[dbo].[uspAddStudent]
		@pFirstName = N'Mary ',
		@pLastName = N'Jones',
		@pEmail = N'marry.jones@gmail.com',
		@pPhone = N'0861234411',		
		@pAddressLine1 = N'Address 1',
		@pAddressLine2 = N'Address 2',
		@pCity = N'Galway',
		@pCounty = N'Galway',
		@pCountry = N'Ireland',
		@pLevel = N'Undergrad',
		@pCourse = N'Arts',
		@pStudentNumber = 1712346,
		@pActiveUser = N'bruno';

EXEC	[dbo].[uspAddStudent]
		@pFirstName = N'John ',
		@pLastName = N'Doe',
		@pEmail = N'john.doe@gmail.com',
		@pPhone = N'0893212025',
		@pAddressLine1 = N'Address 1',
		@pAddressLine2 = N'Address 2',
		@pCity = N'Donegal',
		@pCounty = N'Donegal',
		@pCountry = N'Ireland',
		@pLevel = N'Undergrad',
		@pCourse = N'business',
		@pStudentNumber = 1712347,
		@pActiveUser = N'admin';