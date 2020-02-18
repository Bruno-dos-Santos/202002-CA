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
    @pTable VARCHAR(20) = NULL,
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY

        INSERT INTO dbo.Logs (LoginName, EventInfo, TypeEvent, Operation, TableName)
        VALUES(@pLoginName, @pEvent, @pType, @pOperation, @pTable )

        SET @responseMessage='Success'

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

        INSERT INTO dbo.Users(LoginName, PasswordHash, FirstName, LastName)
        VALUES(@pLoginName, HASHBYTES('SHA2_512', @pPassword), @pFirstName, @pLastName);

        SET @responseMessage='Success';
        
        EXEC dbo.uspAddLog
          @pLoginName = @pActiveUser,  
          @pEvent      = @pLoginName, 
          @pType       = 'Info',
          @pOperation  = 'New register',
          @pTable      = 'User';
           
    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH

END
go

CREATE TABLE dbo.Student
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