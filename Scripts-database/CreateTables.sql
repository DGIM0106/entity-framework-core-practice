USE EFCorePracticeDb;
GO

CREATE TABLE Categorias
(
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    NombreCategoria VARCHAR(75) NOT NULL
);
GO

CREATE TABLE Productos
(
    ProductoId INT PRIMARY KEY IDENTITY(1,1),
    NombreProducto VARCHAR(75) NOT NULL,
    Precio DECIMAL(13,5) NOT NULL,
    CategoriaID INT REFERENCES Categorias(CategoriaID)
);
GO