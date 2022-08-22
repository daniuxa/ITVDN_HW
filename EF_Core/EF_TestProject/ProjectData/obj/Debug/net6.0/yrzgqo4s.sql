IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [authors] (
    [Id] int NOT NULL IDENTITY,
    [FName] nvarchar(max) NULL,
    [LName] nvarchar(max) NULL,
    CONSTRAINT [PK_authors] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [books] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [PublishingYear] int NOT NULL,
    [AuthorsId] int NULL,
    CONSTRAINT [PK_books] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_books_authors_AuthorsId] FOREIGN KEY ([AuthorsId]) REFERENCES [authors] ([Id])
);
GO

CREATE INDEX [IX_books_AuthorsId] ON [books] ([AuthorsId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220821163952_initial', N'6.0.8');
GO

COMMIT;
GO

