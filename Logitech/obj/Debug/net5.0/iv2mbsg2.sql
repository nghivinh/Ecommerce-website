CREATE TABLE [Accounts] (
    [ID] bigint NOT NULL IDENTITY,
    [UserName] nvarchar(20) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [PhoneNumber] nvarchar(10) NOT NULL,
    [Avarta] nvarchar(max) NULL,
    CONSTRAINT [PK_Accounts] PRIMARY KEY ([ID])
);
GO


CREATE TABLE [Categorys] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Categorys] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [ProductRatings] (
    [Id] int NOT NULL IDENTITY,
    [Rating] real NOT NULL,
    [AccountID] bigint NULL,
    CONSTRAINT [PK_ProductRatings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ProductRatings_Accounts_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [Accounts] ([ID]) ON DELETE NO ACTION
);
GO


CREATE TABLE [Products] (
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
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Products_Categorys_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categorys] ([Id]) ON DELETE NO ACTION
);
GO


CREATE INDEX [IX_ProductRatings_AccountID] ON [ProductRatings] ([AccountID]);
GO


CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
GO


