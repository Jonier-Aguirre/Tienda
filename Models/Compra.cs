using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tienda.Models;

public partial class Compra
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProducto { get; set; }

    public int Cantidad { get; set; }

    public DateTime FechaCompra { get; set; }
    [Display(Name = "Cliente")]

    public virtual Cliente? IdClienteNavigation { get; set; }
    [Display(Name = "Producto")]

    public virtual Producto? IdProductoNavigation { get; set; }
}
