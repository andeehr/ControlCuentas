CREATE TABLE [dbo].[CategoriaGasto] (
    [IdCategoria] INT           NOT NULL,
    [Descripcion] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED ([IdCategoria] ASC)
);

