--19.11
USE [itin18_akt]
GO


CREATE FUNCTION fn_check_lamp_delete_scalar(@username NVARCHAR(50), @password VARBINARY(MAX),@lamp_id INT)
	RETURNS INT
AS
BEGIN
	DECLARE @user_id INT = NULL;
	DECLARE @lampid INT = NULL;
	DECLARE @active BIT = NULL;

	
	
	SET @user_id = dbo.fn_check_user_scalar(@username, @password);

	IF (NOT @user_id IS NULL) AND (@user_id > 0) AND (NOT @lamp_id IS NULL) AND (@lamp_id > 0) 
	BEGIN
	 	SELECT @lampid = l.id 
			FROM Lamp AS l 
				JOIN Deletedlamp AS dl
				ON dl.id = l.id 
					WHERE @lamp_id = l.id

			IF (NOT @lampid IS NULL) 
				BEGIN 
					SET @active = 1;
				END
			ELSE 
				BEGIN 
					SET @active = 0;
				END
	END;	
	RETURN @active;
END;
GO

USE master;
GO