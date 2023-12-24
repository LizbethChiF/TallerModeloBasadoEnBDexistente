using System;
using System.Collections.Generic;

namespace Proyecto_Taller.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public int ProveedorId { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; } = new List<DetalleFactura>();

    public virtual Proveedor Proveedor { get; set; } = null!;
}
