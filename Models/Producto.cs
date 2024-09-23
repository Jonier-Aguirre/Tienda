using System;
using System.Collections.Generic;

namespace Tienda.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
