CREATE TABLE [dbo].[TB_CourseRegistration] (
    [StudentId]    INT  NOT NULL,
    [SubjectId]    INT  NOT NULL,
    [RegistedDate] DATE NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC, [SubjectId] ASC),
    CONSTRAINT [FK_TB_CourseRegistration_TB_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[TB_Student] ([StudentId]),
    CONSTRAINT [FK_TB_CourseRegistration_TB_Subject] FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[TB_Subject] ([SubjectId])
);

