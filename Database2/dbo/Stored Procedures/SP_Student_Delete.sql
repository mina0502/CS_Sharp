CREATE PROCEDURE [dbo].[SP_Student_Delete]
	@StudentId int
AS
	DELETE  FROM
		TB_Student
	WHERE
		StudentId = @StudentId