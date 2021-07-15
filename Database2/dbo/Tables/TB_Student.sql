CREATE TABLE [dbo].[TB_Student] (
    [StudentId]   INT            IDENTITY (1, 1) NOT NULL,
    [StudentName] NVARCHAR (50)  NULL,
    [Address]     NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC)
);

