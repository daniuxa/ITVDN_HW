IF OBJECT_ID(N'[__EFMigrationsHistori]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistori] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistori] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistori] ([MigrationId], [ProductVersion])
VALUES (N'20220823121351_test', N'6.0.8');
GO

COMMIT;
GO

