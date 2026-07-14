using System;
using System.Collections.Generic;

namespace EFCorePractice.App.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string NombreProducto { get; set; } = null!;

    public decimal Precio { get; set; }

    public int? CategoriaId { get; set; }

    public virtual Categoria? Categoria { get; set; }
}
