using System;
using System.Collections.Generic;

namespace elsuper.Modelos;

public partial class Compra
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdProducto { get; set; }

    public int? IdMarca { get; set; }

    public int? IdSupermercado { get; set; }

    public double? Precio { get; set; }

    public int? Cantidad { get; set; }

    public double? Total { get; set; }

    public double? Descuento { get; set; }

    public double? Final { get; set; }

    public virtual Marca? IdMarcaNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Supermercado? IdSupermercadoNavigation { get; set; }
}
