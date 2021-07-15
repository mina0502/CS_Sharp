﻿CREATE PROCEDURE [dbo].[SP_CourseRegistration_Update]
	@StudentId int,
	@SubjectId int,
	@NewSubjectId int,
	@RegistedDate datetime
AS
	UPDATE
		TB_CourseRegistration
	SET
		SubjectId = @NewSubjectId,
		RegistedDate = @RegistedDate
	WHERE
		StudentId = @StudentId AND
		SubjectId = @SubjectId
