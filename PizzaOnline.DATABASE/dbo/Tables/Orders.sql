CREATE TABLE [dbo].[Orders] (
    [Id]         INT NOT NULL,
    [customerId] INT NOT NULL,
    [pizzaId]    INT NOT NULL,
    [pizzeriaId] INT NOT NULL,
    [deliveryId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([customerId]) REFERENCES [dbo].[Customers] ([Id]),
    FOREIGN KEY ([deliveryId]) REFERENCES [dbo].[Delivery] ([Id]),
    FOREIGN KEY ([pizzaId]) REFERENCES [dbo].[Pizza] ([Id]),
    FOREIGN KEY ([pizzeriaId]) REFERENCES [dbo].[Pizzeria] ([Id])
);

