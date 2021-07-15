CREATE PROCEDURE [dbo].[SP_Student_GetById]
	@StudentId int
AS
	SELECT 
			StudentId,
			StudentName,
			Address
	FROM
		TB_Student
	WHERE 
			StudentId = @StudentId