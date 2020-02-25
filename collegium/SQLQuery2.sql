DROP PROCEDURE [dbo].uspAddStudent;
DROP PROCEDURE [dbo].uspAddLog;
DROP PROCEDURE [dbo].uspAddUser;
DROP TABLE Logs;
DROP TABLE Students;
Drop Table Users;

go

CREATE TABLE dbo.Logs
(
    LogID INT IDENTITY(1,1) NOT NULL,
    LoginName VARCHAR(20),
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
        VALUES(@pLoginName, @pEvent, @pType, @pOperation, @pTable )

    END TRY
    BEGIN CATCH

    END CATCH

END

GO

CREATE TABLE dbo.Users
(
    UserID INT IDENTITY(1,1) NOT NULL,
    LoginName VARCHAR(20) NOT NULL,
    PasswordHash BINARY(64) NOT NULL,
    FirstName VARCHAR(20) NULL,
    LastName VARCHAR(20) NULL,
    isDeleted VARCHAR(1) NOT NULL default 'N', 
    CONSTRAINT [PK_User_UserID] PRIMARY KEY (UserID)
)

go

CREATE PROCEDURE dbo.uspAddUser
    @pLoginName VARCHAR(20), 
    @pPassword VARCHAR(50), 
    @pFirstName VARCHAR(20) = NULL, 
    @pLastName VARCHAR(20) = NULL,
    @pActiveUser VARCHAR(20) = NULL, 
    @responseMessage VARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY

        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @pLoginName, 
          @pType       = 'Info',
          @pOperation  = 'Insert',
          @pTable      = 'Users'
          
        INSERT INTO dbo.Users(LoginName, PasswordHash, FirstName, LastName)
        VALUES(@pLoginName, HASHBYTES('SHA2_512', @pPassword), @pFirstName, @pLastName);

        SET @responseMessage='Success';
      
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        EXEC dbo.uspAddLog
          @pLoginName  = @pActiveUser,  
          @pEvent      = @responseMessage, 
          @pType       = 'Error',
          @pOperation  = 'Insert',
          @pTable      = 'Users'
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
    Level VARCHAR(10) NOT NULL,
    Course VARCHAR(20) NOT NULL,
    StudentNumber INT NOT NULL,
    Created_at DATETIME NOT NULL
                DEFAULT CURRENT_TIMESTAMP, 
    isDeleted VARCHAR(1) NOT NULL default 'N',
    CONSTRAINT [PK_Student_StudentID] PRIMARY KEY (StudentID)	
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
    @pLevel VARCHAR(10),
    @pCourse VARCHAR(20),
    @pStudentNumber INT,
    @pActiveUser VARCHAR(20) = NULL, 
    @responseMessage VARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY
        
        INSERT INTO dbo.Students(FirstName, LastName, Email, Phone, AddressLine1, AddressLine2,City, County, Level, Course, StudentNumber)
        VALUES(@pFirstName, @pLastName, @pEmail, @pPhone, @pAddressLine1, @pAddressLine2,@pCity, @pCounty, @pLevel, @pCourse, @pStudentNumber);

        SET @responseMessage='Success';

        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @responseMessage, 
          @pType       = 'Info',
          @pOperation  = 'Insert',
          @pTable      = 'Students';

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @responseMessage, 
          @pType       = 'Error',
          @pOperation  = 'Insert',
          @pTable      = 'Students';
    END CATCH

END
go