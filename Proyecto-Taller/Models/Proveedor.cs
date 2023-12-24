using System;
using System.Collections.Generic;

namespace Proyecto_Taller.Models;

public partial class Proveedor
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
