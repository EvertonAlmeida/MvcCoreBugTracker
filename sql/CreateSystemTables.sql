IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Severities] (
    [Id] uniqueidentifier NOT NULL,
    [Name] varchar(200) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Severities] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Status] (
    [Id] uniqueidentifier NOT NULL,
    [Name] varchar(200) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Status] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Bugs] (
    [Id] uniqueidentifier NOT NULL,
    [Number] int NOT NULL,
    [Name] varchar(200) NOT NULL,
    [Description] varchar(100) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [StatusId] uniqueidentifier NOT NULL,
    [SeverityId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Bugs] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Bugs_Severities_SeverityId] FOREIGN KEY ([SeverityId]) REFERENCES [Severities] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Bugs_Status_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [Status] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Bugs_SeverityId] ON [Bugs] ([SeverityId]);

GO

CREATE INDEX [IX_Bugs_StatusId] ON [Bugs] ([StatusId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210220083217_Initial', N'3.1.12');

GO

