CREATE PROCEDURE [dbo].[SP_Student_Add]
	@StudentName nvarchar(50),
	@Address nvarchar(200)
AS
	INSERT 
		TB_Student
		(
			StudentName,
			Address
		)
		VALUES
		(
			@StudentName,
			@Address
		)
	RETURN SCOPE_IDENTITY()