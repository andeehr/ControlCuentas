CREATE TABLE [dbo].[CategoriaIngreso] (
    [IdCategoriaIngreso] INT           NOT NULL,
    [Descripcion]        NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_CategoriaIngreso] PRIMARY KEY CLUSTERED ([IdCategoriaIngreso] ASC)
);

