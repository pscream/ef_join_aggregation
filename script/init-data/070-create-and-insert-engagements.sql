CREATE TABLE [Engagements] 
(
    [Id] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](256) NOT NULL,
    [IsActive] [bit] NOT NULL,
    CONSTRAINT [PK_Engagements] PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
);
GO

INSERT INTO [Engagements] ([Id], [Name], [IsActive])
VALUES ('00000000-0000-0000-0000-000000000001', 'Project One', 1);

INSERT INTO [Engagements] ([Id], [Name], [IsActive])
VALUES ('00000000-0000-0000-0000-000000000002', 'Project Two', 1);

INSERT INTO [Engagements] ([Id], [Name], [IsActive])
VALUES ('00000000-0000-0000-0000-000000000003', 'Project Three', 1);

GO