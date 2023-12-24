using System;
using System.Collections.Generic;

namespace Proyecto_Taller.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; } = new List<Factura>();
}
