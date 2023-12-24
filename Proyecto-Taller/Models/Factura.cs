using System;
using System.Collections.Generic;

namespace Proyecto_Taller.Models;

public partial class Factura
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Total { get; set; }

    public int ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; } = new List<DetalleFactura>();
}
