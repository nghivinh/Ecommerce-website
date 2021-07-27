CREATE TABLE [Account] (
    [ID] bigint NOT NULL IDENTITY,
    [UserName] nvarchar(20) NOT NULL,
    [Password] nvarchar(20) NOT NULL,
    [FirstName] nvarchar(20) NULL,
    [LastName] nvarchar(20) NULL,
    [PhoneNumber] nvarchar(10) NULL,
    [Avarta] nvarchar(max) NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY ([ID])
);
GO


CREATE TABLE [Category] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [ProductRating] (
    [Id] int NOT NULL IDENTITY,
    [Rating] real NOT NULL,
    [AccountID] bigint NULL,
    CONSTRAINT [PK_ProductRating] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ProductRating_Account_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [Account] ([ID]) ON DELETE NO ACTION
);
GO


CREATE TABLE [Product] (
    [Id] int NOT NULL IDENTITY,
    [Image] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Price] int NOT NULL,
    [SaleOff] int NOT NULL,
    [Featured] bit NOT NULL,
    [Description] nvarchar(max) NULL,
    [Store] int NOT NULL,
    [Sold] int NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [UpdatedDate] datetime2 NOT NULL,
    [CategoryId] int NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Product_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([Id]) ON DELETE NO ACTION
);
GO


CREATE INDEX [IX_Product_CategoryId] ON [Product] ([CategoryId]);
GO


CREATE INDEX [IX_ProductRating_AccountID] ON [ProductRating] ([AccountID]);
GO


