CREATE TABLE [dbo].[Ingredients] (
    [Id]      INT       NOT NULL,
    [pizzaId] INT       NOT NULL,
    [cheese]  CHAR (12) NULL,
    [tomate]  CHAR (12) NULL,
    [sausage] CHAR (12) NULL,
    [sous]    CHAR (12) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([pizzaId]) REFERENCES [dbo].[Pizza] ([Id])
);

