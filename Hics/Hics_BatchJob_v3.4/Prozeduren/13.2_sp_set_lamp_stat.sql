USE [itin18_akt]
GO


CREATE PROCEDURE sp_set_lamp_stat
	@username NVARCHAR(50),
	@password VARBINARY(MAX),
	@lamp_id	  INT,
	@bright	  	TINYINT,
	@stat 		BIT
AS
BEGIN
	DECLARE @user_id INT = NULL;
	
	SET @user_id = dbo.fn_check_user_scalar(@username,@password);
	
	 
	IF (NOT @user_id IS NULL) AND (@user_id > 0) AND (NOT @lamp_id IS NULL) AND (@lamp_id > 0)
	BEGIN
			INSERT INTO Lampstatus(stat,lamp_id,userlifetime,bright )
			VALUES (@stat,@lamp_id,@user_id,@bright);

	END;
END;

