CREATE PROCEDURE [dbo].[SP_SubjectUpdateName]
	@SubjectId int,
	@SubjectName nvarchar(50)
AS
	UPDATE
		TB_Subject
	SET
		SubjectName = @SubjectName
	WHERE
		SubjectId = @SubjectId