CREATE TABLE [Slas] 
(
    [Id] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](100) NOT NULL,
    [CreatedById] [uniqueidentifier] NOT NULL,
    [UpdatedById] [uniqueidentifier] NOT NULL,
    [IsActive] [bit] NOT NULL,
    CONSTRAINT [PK_Slas] PRIMARY KEY ([Id] ASC) ON [PRIMARY]
);
GO

ALTER TABLE [Slas] ADD CONSTRAINT [FK_Slas_Users_CreatedById] FOREIGN KEY([CreatedById]) REFERENCES [Users] ([Id])
GO

ALTER TABLE [Slas] ADD CONSTRAINT [FK_Slas_Users_UpdatedById] FOREIGN KEY([UpdatedById]) REFERENCES [Users] ([Id])
GO

INSERT INTO [Slas] ([Id], [Name], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0000-000000000001', 'Support Level 1', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [Slas] ([Id], [Name], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0000-000000000002', 'Support Level 2', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);
