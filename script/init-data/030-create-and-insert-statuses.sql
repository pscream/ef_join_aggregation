CREATE TABLE [Statuses] 
(
    [Id] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](50) NOT NULL,
    [IsActive] [bit] NOT NULL,
    CONSTRAINT [PK_Statuses] PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
);
GO

INSERT INTO [Statuses] ([Id], [Name], [IsActive])
VALUES ('00000000-0000-0000-0000-000000000001', 'Open', 1);

INSERT INTO [Statuses] ([Id], [Name], [IsActive])
VALUES ('00000000-0000-0000-0000-000000000002', 'Submitted', 1);

INSERT INTO [Statuses] ([Id], [Name], [IsActive])
VALUES ('00000000-0000-0000-0000-000000000003', 'Auto-Approved', 1);

GO