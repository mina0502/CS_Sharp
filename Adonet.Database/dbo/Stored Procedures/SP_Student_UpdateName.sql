CREATE PROCEDURE [dbo].[SP_Student_UpdateName]
	@StudentId int,
	@StudentName nvarchar(50)
AS
	UPDATE
		TB_Student
	SET
		StudentName = @StudentName
	WHERE
		StudentId = @StudentId