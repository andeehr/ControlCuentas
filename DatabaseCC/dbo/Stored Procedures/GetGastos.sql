


CREATE PROCEDURE [dbo].[GetGastos]
	@fechaDesde date,
	@fechaHasta date,
	@idCategoria int,
	@idMedio int
AS

SELECT
	IdGasto,
	Fecha,
	Importe,
	Observaciones,
	categoria.Descripcion AS categoria,
	subcategoria.Descripcion AS subcategoria
FROM
	ControlCuentas.dbo.Gasto AS gasto
	INNER JOIN ControlCuentas.dbo.SubcategoriaGasto AS subcategoria
	ON gasto.IdSubcategoria = subcategoria.IdSubcategoria
	INNER JOIN ControlCuentas.dbo.CategoriaGasto AS categoria
	ON subcategoria.IdCategoria = categoria.IdCategoria
WHERE
	(@fechaDesde IS NULL OR Fecha >= @fechaDesde)
	and (@fechaHasta IS NULL OR Fecha <= @fechaHasta)
	and (@idCategoria IS NULL OR categoria.IdCategoria = @idCategoria)
	and (@idMedio IS NULL OR gasto.IdMedio = @idMedio)