CREATE TABLE [TicketSlas] 
(
    [Id] [uniqueidentifier] NOT NULL,
    [TicketId] [uniqueidentifier] NOT NULL,
    [SlaId] [uniqueidentifier] NOT NULL,
    [CreatedById] [uniqueidentifier] NOT NULL,
    [UpdatedById] [uniqueidentifier] NOT NULL,
    [IsActive] [bit] NOT NULL,
    CONSTRAINT [PK_TicketSlas] PRIMARY KEY ([Id] ASC) ON [PRIMARY]
);
GO

ALTER TABLE [TicketSlas] ADD CONSTRAINT [FK_TicketSlas_Tickets_TicketId] FOREIGN KEY([TicketId]) REFERENCES [Tickets] ([Id])
GO

ALTER TABLE [TicketSlas] ADD CONSTRAINT [FK_TicketSlas_Slas_SlaId] FOREIGN KEY([SlaId]) REFERENCES [Slas] ([Id])
GO

ALTER TABLE [TicketSlas] ADD CONSTRAINT [FK_TicketSlas_Users_CreatedById] FOREIGN KEY([CreatedById]) REFERENCES [Users] ([Id])
GO

ALTER TABLE [TicketSlas] ADD CONSTRAINT [FK_TicketSlas_Users_UpdatedById] FOREIGN KEY([UpdatedById]) REFERENCES [Users] ([Id])
GO

INSERT INTO [TicketSlas] ([Id], [TicketId], [SlaId], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000001', '00000000-0000-0000-0001-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TicketSlas] ([Id], [TicketId], [SlaId], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000002', '00000000-0000-0000-0001-000000000001', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);