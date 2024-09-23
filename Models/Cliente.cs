using System;
using System.Collections.Generic;

namespace Tienda.Models;

public partial class Cliente
{
    public int Documento { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
