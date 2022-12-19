CREATE TABLE [TicketSlaCache] 
(
    [Id] [uniqueidentifier] NOT NULL,
    [TicketSlaId] [uniqueidentifier] NOT NULL,
    [StartDate] [datetime2] NOT NULL,
	[EndDate] [datetime2] NOT NULL,
    [Timer1SlaMins] [int] NOT NULL,
    [Timer1StartMins] [int] NOT NULL,
    [Timer1EndMins] [int] NOT NULL,
    [Timer2SlaMins] [int] NOT NULL,
    [Timer2StartMins] [int] NOT NULL,
    [Timer2EndMins] [int] NOT NULL,
    [CreatedById] [uniqueidentifier] NOT NULL,
    [UpdatedById] [uniqueidentifier] NOT NULL,
    [IsActive] [bit] NOT NULL,
    CONSTRAINT [PK_TicketSlaCache] PRIMARY KEY ([Id] ASC) ON [PRIMARY]
);
GO

ALTER TABLE [TicketSlaCache] ADD CONSTRAINT [FK_TicketSlaCache_TicketSlas_TicketId] FOREIGN KEY([TicketSlaId]) REFERENCES [TicketSlas] ([Id])
GO

ALTER TABLE [TicketSlaCache] ADD CONSTRAINT [FK_TicketSlaCache_Users_CreatedById] FOREIGN KEY([CreatedById]) REFERENCES [Users] ([Id])
GO

ALTER TABLE [TicketSlaCache] ADD CONSTRAINT [FK_TicketSlaCache_Users_UpdatedById] FOREIGN KEY([UpdatedById]) REFERENCES [Users] ([Id])
GO

INSERT INTO [TicketSlaCache] ([Id], [TicketSlaId], [StartDate], [EndDate], [Timer1SlaMins], [Timer1StartMins], [Timer1EndMins], [Timer2SlaMins], [Timer2StartMins], [Timer2EndMins], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000001', '00000000-0000-0000-0001-000000000001', '2022-12-11 9:00', '2022-12-11 11:00', 180, 0, 120, 360, 0, 120,
'00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TicketSlaCache] ([Id], [TicketSlaId], [StartDate], [EndDate], [Timer1SlaMins], [Timer1StartMins], [Timer1EndMins], [Timer2SlaMins], [Timer2StartMins], [Timer2EndMins], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000002', '00000000-0000-0000-0001-000000000001', '2022-12-12 9:00', '2022-12-12 11:00', 180, 120, 240, 360, 120, 240,
'00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TicketSlaCache] ([Id], [TicketSlaId], [StartDate], [EndDate], [Timer1SlaMins], [Timer1StartMins], [Timer1EndMins], [Timer2SlaMins], [Timer2StartMins], [Timer2EndMins], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000003', '00000000-0000-0000-0001-000000000001', '2022-12-13 9:00', '2022-12-13 11:00', 180, 240, 360, 360, 240, 360,
'00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TicketSlaCache] ([Id], [TicketSlaId], [StartDate], [EndDate], [Timer1SlaMins], [Timer1StartMins], [Timer1EndMins], [Timer2SlaMins], [Timer2StartMins], [Timer2EndMins], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0002-000000000001', '00000000-0000-0000-0001-000000000002', '2022-12-12 9:00', '2022-12-12 11:00', 180, 0, 120, 360, 0, 120,
'00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TicketSlaCache] ([Id], [TicketSlaId], [StartDate], [EndDate], [Timer1SlaMins], [Timer1StartMins], [Timer1EndMins], [Timer2SlaMins], [Timer2StartMins], [Timer2EndMins], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0002-000000000002', '00000000-0000-0000-0001-000000000002', '2022-12-13 9:00', '2022-12-13 11:00', 180, 120, 240, 360, 120, 240,
'00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TicketSlaCache] ([Id], [TicketSlaId], [StartDate], [EndDate], [Timer1SlaMins], [Timer1StartMins], [Timer1EndMins], [Timer2SlaMins], [Timer2StartMins], [Timer2EndMins], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0002-000000000003', '00000000-0000-0000-0001-000000000002', '2022-12-14 9:00', '2022-12-14 11:00', 180, 240, 360, 360, 240, 360,
'00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);
