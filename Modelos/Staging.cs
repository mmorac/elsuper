using System;
using System.Collections.Generic;

namespace elsuper.Modelos;

public partial class Staging
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Producto { get; set; }

    public string? Marca { get; set; }

    public string? Supermercado { get; set; }

    public double? Precio { get; set; }

    public int? Cantidad { get; set; }

    public double? Total { get; set; }

    public double? Descuento { get; set; }

    public double? Final { get; set; }
}
