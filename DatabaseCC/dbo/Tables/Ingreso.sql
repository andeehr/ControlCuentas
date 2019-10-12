CREATE TABLE [dbo].[Ingreso] (
    [IdIngreso]          INT             IDENTITY (1, 1) NOT NULL,
    [Fecha]              DATETIME        NOT NULL,
    [Importe]            DECIMAL (18, 2) NOT NULL,
    [IdMedio]            INT             NOT NULL,
    [Observaciones]      NVARCHAR (50)   NULL,
    [IdCategoriaIngreso] INT             NOT NULL,
    CONSTRAINT [PK_Ingreso] PRIMARY KEY CLUSTERED ([IdIngreso] ASC),
    CONSTRAINT [FK_Ingreso_CategoriaIngreso] FOREIGN KEY ([IdCategoriaIngreso]) REFERENCES [dbo].[CategoriaIngreso] ([IdCategoriaIngreso]),
    CONSTRAINT [FK_Ingreso_Medio] FOREIGN KEY ([IdMedio]) REFERENCES [dbo].[Medio] ([IdMedio])
);

