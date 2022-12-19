CREATE TABLE [Tickets] 
(
    [Id] [uniqueidentifier] NOT NULL,
    [Code] [nvarchar](100) NOT NULL,
    [OpenedById] [uniqueidentifier] NOT NULL,
    [CreatedById] [uniqueidentifier] NOT NULL,
    [UpdatedById] [uniqueidentifier] NOT NULL,
    [IsActive] [bit] NOT NULL,
    CONSTRAINT [PK_Tickets] PRIMARY KEY ([Id] ASC) ON [PRIMARY]
);
GO

ALTER TABLE [Tickets] ADD CONSTRAINT [FK_Tickets_Resources_OpenedById] FOREIGN KEY([OpenedById]) REFERENCES [Resources] ([Id])
GO

ALTER TABLE [Tickets] ADD CONSTRAINT [FK_Tickets_Users_CreatedById] FOREIGN KEY([CreatedById]) REFERENCES [Users] ([Id])
GO

ALTER TABLE [Tickets] ADD CONSTRAINT [FK_Tickets_Users_UpdatedById] FOREIGN KEY([UpdatedById]) REFERENCES [Users] ([Id])
GO

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000001', 'TCK0001', '00000000-0000-0000-0001-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000002', 'TCK0002', '00000000-0000-0000-0001-000000000002', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002', 1);

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000003', 'TCK0003', '00000000-0000-0000-0001-000000000003', '00000000-0000-0000-0000-000000000003', '00000000-0000-0000-0000-000000000003', 1);

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000004', 'TCK0004', '00000000-0000-0000-0001-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000005', 'TCK0005', '00000000-0000-0000-0001-000000000002', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002', 1);

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000006', 'TCK0006', '00000000-0000-0000-0001-000000000003', '00000000-0000-0000-0000-000000000003', '00000000-0000-0000-0000-000000000003', 1);

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000007', 'TCK0007', '00000000-0000-0000-0001-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000008', 'TCK0008', '00000000-0000-0000-0001-000000000002', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002', 1);

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000009', 'TCK0009', '00000000-0000-0000-0001-000000000003', '00000000-0000-0000-0000-000000000003', '00000000-0000-0000-0000-000000000003', 1);

INSERT INTO [Tickets] ([Id], [Code], [OpenedById], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000010', 'TCK0010', '00000000-0000-0000-0001-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);