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

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[authors]') AND [c].[name] = N'SomeNum');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [authors] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [authors] ALTER COLUMN [SomeNum] int NOT NULL;
GO

ALTER TABLE [authors] ADD [MyProperty] int NOT NULL DEFAULT 0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220822142939_frth', N'6.0.8');
GO

COMMIT;
GO

