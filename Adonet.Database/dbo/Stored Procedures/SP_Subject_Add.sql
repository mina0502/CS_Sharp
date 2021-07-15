CREATE PROCEDURE [dbo].[SP_Subject_Add]
	@SubjectName nvarchar(50)
AS
	INSERT 
		TB_Subject
		(
			SubjectName
		)
		VALUES
		(
			@SubjectName
		)
	RETURN SCOPE_IDENTITY()