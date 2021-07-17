CREATE TABLE [Accounts] (
    [Id] int NOT NULL IDENTITY,
    [UserName] nvarchar(20) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [FullName] nvarchar(max) NOT NULL,
    [PhoneNumber] nvarchar(10) NOT NULL,
    [Avarta] nvarchar(max) NULL,
    CONSTRAINT [PK_Accounts] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Categorys] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Categorys] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Products] (
    [Id] int NOT NULL IDENTITY,
    [Image] nvarchar(max) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NULL,
    [Price] int NOT NULL,
    [SaleOff] int NOT NULL,
    [Store] int NOT NULL,
    [Sold] int NOT NULL,
    [Featured] bit NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [UpdatedDate] datetime2 NOT NULL,
    [CategoryId] int NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Products_Categorys_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categorys] ([Id]) ON DELETE NO ACTION
);
GO


CREATE TABLE [ProductRatings] (
    [Id] int NOT NULL IDENTITY,
    [Rating] real NOT NULL,
    [ProductId] int NULL,
    [AccountId] int NULL,
    CONSTRAINT [PK_ProductRatings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ProductRatings_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProductRatings_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE NO ACTION
);
GO


CREATE INDEX [IX_ProductRatings_AccountId] ON [ProductRatings] ([AccountId]);
GO


CREATE INDEX [IX_ProductRatings_ProductId] ON [ProductRatings] ([ProductId]);
GO


CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
GO


