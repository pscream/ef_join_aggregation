CREATE TABLE [TimesheetWeeks] 
(
    [Id] [uniqueidentifier] NOT NULL,
    [StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
    [CreatedById] [uniqueidentifier] NOT NULL,
    [UpdatedById] [uniqueidentifier] NOT NULL,
    [IsActive] [bit] NOT NULL,
    CONSTRAINT [PK_TimesheetWeeks] PRIMARY KEY ([Id] ASC) ON [PRIMARY]
);
GO

ALTER TABLE [TimesheetWeeks] ADD CONSTRAINT [FK_TimesheetWeeks_Users_CreatedById] FOREIGN KEY([CreatedById]) REFERENCES [Users] ([Id])
GO

ALTER TABLE [TimesheetWeeks] ADD CONSTRAINT [FK_TimesheetWeeks_Users_UpdatedById] FOREIGN KEY([UpdatedById]) REFERENCES [Users] ([Id])
GO

INSERT INTO [TimesheetWeeks] ([Id], [StartDate], [EndDate], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000001', '2022-02-28', '2022-03-06', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TimesheetWeeks] ([Id], [StartDate], [EndDate], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000002', '2022-03-07', '2022-03-13', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TimesheetWeeks] ([Id], [StartDate], [EndDate], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000003', '2022-03-14', '2022-03-20', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TimesheetWeeks] ([Id], [StartDate], [EndDate], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000004', '2022-03-21', '2022-03-27', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);

INSERT INTO [TimesheetWeeks] ([Id], [StartDate], [EndDate], [CreatedById], [UpdatedById], [IsActive])
VALUES ('00000000-0000-0000-0001-000000000005', '2022-03-28', '2022-04-03', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 1);
