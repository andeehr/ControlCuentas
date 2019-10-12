CREATE TABLE [dbo].[SubcategoriaGasto] (
    [IdSubcategoria] INT           NOT NULL,
    [Descripcion]    NVARCHAR (50) NOT NULL,
    [IdCategoria]    INT           NOT NULL,
    CONSTRAINT [PK_Subcategoria] PRIMARY KEY CLUSTERED ([IdSubcategoria] ASC),
    CONSTRAINT [FK_Subcategoria_Categoria] FOREIGN KEY ([IdCategoria]) REFERENCES [dbo].[CategoriaGasto] ([IdCategoria])
);

