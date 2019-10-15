



CREATE PROCEDURE [dbo].[GetIngresos]
	@fechaDesde date,
	@fechaHasta date,
	@idCategoria int,
	@idMedio int
AS

SELECT
	IdIngreso,
	Fecha,
	Importe,
	Observaciones,
	categoria.Descripcion AS categoria
FROM
	ControlCuentas.dbo.Ingreso AS ingreso
	INNER JOIN ControlCuentas.dbo.CategoriaIngreso AS categoria
	ON ingreso.IdCategoriaIngreso = categoria.IdCategoriaIngreso

WHERE
	(@fechaDesde IS NULL OR Fecha >= @fechaDesde)
	and (@fechaHasta IS NULL OR Fecha <= @fechaHasta)
	and (@idCategoria IS NULL OR categoria.IdCategoriaIngreso = @idCategoria)
	and (@idMedio IS NULL OR ingreso.IdMedio = @idMedio)