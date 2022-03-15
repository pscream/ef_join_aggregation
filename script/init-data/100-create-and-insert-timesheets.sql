CREATE TABLE [Timesheets] 
(
    [Id] [uniqueidentifier] NOT NULL,
    [ResourceId] [uniqueidentifier] NOT NULL,
    [StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[StatusId] [uniqueidentifier] NOT NULL,
    [CreatedById] [uniqueidentifier] NOT NULL,
    [UpdatedById] [uniqueidentifier] NOT NULL,
    [IsActive] [bit] NOT NULL,
    CONSTRAINT [PK_Timesheets] PRIMARY KEY ([Id] ASC) ON [PRIMARY]
);
GO

ALTER TABLE [Timesheets] ADD CONSTRAINT [FK_Timesheets_Resources_ResourceId] FOREIGN KEY([ResourceId]) REFERENCES [Resources] ([Id])
GO

ALTER TABLE [Timesheets] ADD CONSTRAINT [FK_Timesheets_Statuses_StatusId] FOREIGN KEY([StatusId]) REFERENCES [Statuses] ([Id])
GO

ALTER TABLE [Timesheets] ADD CONSTRAINT [FK_Timesheets_Users_CreatedById] FOREIGN KEY([CreatedById]) REFERENCES [Users] ([Id])
GO

ALTER TABLE [Timesheets] ADD CONSTRAINT [FK_Timesheets_Users_UpdatedById] FOREIGN KEY([UpdatedById]) REFERENCES [Users] ([Id])
GO

INSERT INTO [Timesheets] ([Id], [ResourceId], [StartDate], [EndDate], [StatusId], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000001', '00000000-0000-0000-0001-000000000001', '2022-02-28', '2022-03-06', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [Timesheets] ([Id], [ResourceId], [StartDate], [EndDate], [StatusId], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000002', '00000000-0000-0000-0001-000000000002', '2022-02-28', '2022-03-06', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [Timesheets] ([Id], [ResourceId], [StartDate], [EndDate], [StatusId], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0002-000000000001', '00000000-0000-0000-0001-000000000001', '2022-03-14', '2022-03-20', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);
