CREATE TABLE [dbo].[TB_Subject] (
    [SubjectId]   INT          IDENTITY (1, 1) NOT NULL,
    [SubjectName] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([SubjectId] ASC),
    UNIQUE NONCLUSTERED ([SubjectName] ASC)
);

