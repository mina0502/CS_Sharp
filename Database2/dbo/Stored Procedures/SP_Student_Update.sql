CREATE PROCEDURE [dbo].[SP_Student_Update]
	@StudentId int,
	@StudentName nvarchar(50),
	@Address nvarchar(200)
AS
	UPDATE
		TB_Student
	SET
		StudentName=@StudentName,
		Address = @Address
	WHERE
		StudentId = @StudentId