CREATE TABLE [dbo].[Gasto] (
    [IdGasto]        INT             IDENTITY (1, 1) NOT NULL,
    [Fecha]          DATETIME        NOT NULL,
    [Importe]        DECIMAL (18, 2) NOT NULL,
    [Observaciones]  NVARCHAR (50)   NULL,
    [IdMedio]        INT             NOT NULL,
    [IdSubcategoria] INT             NOT NULL,
    CONSTRAINT [PK_Gasto] PRIMARY KEY CLUSTERED ([IdGasto] ASC),
    CONSTRAINT [FK_Gasto_Medio] FOREIGN KEY ([IdMedio]) REFERENCES [dbo].[Medio] ([IdMedio]),
    CONSTRAINT [FK_Gasto_Subcategoria] FOREIGN KEY ([IdSubcategoria]) REFERENCES [dbo].[SubcategoriaGasto] ([IdSubcategoria])
);

