CREATE PROCEDURE [dbo].[AddMember]
	@ForeName Varchar(100),
	@SurName Varchar(100),
	@Email Varchar(150),
	@SMS Varchar(50), 
    @Address1 VARCHAR(250), 
    @Address2 VARCHAR(250), 
    @Address3 VARCHAR(250), 
    @Age VARCHAR(50), 
    @Type INT
AS
	DECLARE @MemberID INT = 0;

	IF EXISTS (SELECT 1 FROM Member WHERE Member.Email = @Email AND Member.SMS = @SMS AND Member.ForeName = @ForeName)
		BEGIN
			RAISERROR('Member Already exist',16,1)
		END
	BEGIN TRY
		INSERT INTO Member VALUES(@ForeName, @SurName, @Email, @SMS, @Address1, @Address2, @Address3, @Age, @Type, 1)
	END TRY
	BEGIN CATCH
			RAISERROR('Error Inserting Member Data', 16,1)
	END CATCH

	SELECT MAX(Member.MemberId) FROM Member WHERE Member.Email = @Email

RETURN 0
