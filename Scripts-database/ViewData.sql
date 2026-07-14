USE [EFCorePracticeDb]

DELETE FROM [dbo].[Categorias]
WHERE [CategoriaID] IN ('2','3');
GO

SELECT *
FROM [dbo].[Categorias]

SELECT *
FROM [dbo].[Productos]

SELECT PR.[NombreProducto], PR.[Precio], CA.[NombreCategoria]
FROM [dbo].[Productos] AS PR
INNER JOIN [dbo].[Categorias] AS CA ON PR.[CategoriaID] = CA.[CategoriaID];