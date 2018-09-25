IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822064740_Initial')
BEGIN
    CREATE TABLE [Orders] (
        [Id] int NOT NULL IDENTITY,
        [Total] decimal(18, 2) NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822064740_Initial')
BEGIN
    CREATE TABLE [Products] (
        [SKU] nvarchar(450) NOT NULL,
        [Name] nvarchar(20) NOT NULL,
        [UnitsInStock] int NOT NULL,
        [Discontinoued] bit NOT NULL,
        [Price] decimal(18, 2) NOT NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([SKU])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822064740_Initial')
BEGIN
    CREATE TABLE [OrderDetail] (
        [Id] int NOT NULL IDENTITY,
        [Quantity] int NOT NULL,
        [Price] decimal(18, 2) NOT NULL,
        [ProductSKU] nvarchar(450) NOT NULL,
        [Total] decimal(18, 2) NOT NULL,
        [OrderId] int NULL,
        CONSTRAINT [PK_OrderDetail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OrderDetail_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_OrderDetail_Products_ProductSKU] FOREIGN KEY ([ProductSKU]) REFERENCES [Products] ([SKU]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822064740_Initial')
BEGIN
    CREATE INDEX [IX_OrderDetail_OrderId] ON [OrderDetail] ([OrderId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822064740_Initial')
BEGIN
    CREATE INDEX [IX_OrderDetail_ProductSKU] ON [OrderDetail] ([ProductSKU]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822064740_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180822064740_Initial', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822071515_update1')
BEGIN
    ALTER TABLE [Orders] ADD [Date] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822071515_update1')
BEGIN
    ALTER TABLE [Orders] ADD [Status] tinyint NOT NULL DEFAULT CAST(0 AS tinyint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822071515_update1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180822071515_update1', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180823083320_ProductAddPicture')
BEGIN
    ALTER TABLE [Products] ADD [FileName] nvarchar(256) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180823083320_ProductAddPicture')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180823083320_ProductAddPicture', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    ALTER TABLE [OrderDetail] DROP CONSTRAINT [FK_OrderDetail_Orders_OrderId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    ALTER TABLE [OrderDetail] DROP CONSTRAINT [FK_OrderDetail_Products_ProductSKU];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    ALTER TABLE [OrderDetail] DROP CONSTRAINT [PK_OrderDetail];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    EXEC sp_rename N'[OrderDetail]', N'OrderDetails';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    EXEC sp_rename N'[OrderDetails].[IX_OrderDetail_ProductSKU]', N'IX_OrderDetails_ProductSKU', N'INDEX';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    EXEC sp_rename N'[OrderDetails].[IX_OrderDetail_OrderId]', N'IX_OrderDetails_OrderId', N'INDEX';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    ALTER TABLE [OrderDetails] ADD [Discount] decimal(18, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    ALTER TABLE [OrderDetails] ADD [PromotionId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    ALTER TABLE [OrderDetails] ADD CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([Id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    CREATE TABLE [Promotions] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(255) NOT NULL,
        [IsEnabled] bit NOT NULL,
        [Discriminator] nvarchar(max) NOT NULL,
        [Quantity] int NULL,
        [DiscoiuntPrice] decimal(18, 2) NULL,
        [ProductSKU] nvarchar(450) NULL,
        CONSTRAINT [PK_Promotions] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Promotions_Products_ProductSKU] FOREIGN KEY ([ProductSKU]) REFERENCES [Products] ([SKU]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    CREATE INDEX [IX_OrderDetails_PromotionId] ON [OrderDetails] ([PromotionId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    CREATE INDEX [IX_Promotions_ProductSKU] ON [Promotions] ([ProductSKU]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    ALTER TABLE [OrderDetails] ADD CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    ALTER TABLE [OrderDetails] ADD CONSTRAINT [FK_OrderDetails_Products_ProductSKU] FOREIGN KEY ([ProductSKU]) REFERENCES [Products] ([SKU]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    ALTER TABLE [OrderDetails] ADD CONSTRAINT [FK_OrderDetails_Promotions_PromotionId] FOREIGN KEY ([PromotionId]) REFERENCES [Promotions] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180824024715_AddPromotion')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180824024715_AddPromotion', N'2.1.2-rtm-30932');
END;

GO

