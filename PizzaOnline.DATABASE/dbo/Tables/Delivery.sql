CREATE TABLE [dbo].[Delivery] (
    [Id]           INT       NOT NULL,
    [nameDelivery] CHAR (16) NULL,
    [time]         DATE      NULL,
    [price]        INT       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

