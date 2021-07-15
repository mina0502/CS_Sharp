CREATE PROCEDURE [dbo].[SP_Subject_Delete]
	@SubjectId int
AS
	DELETE FROM
		TB_Subject
	WHERE
		SubjectId = @SubjectId