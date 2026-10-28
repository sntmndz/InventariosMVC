using System;
using System.Collections.Generic;

namespace InventariosMVC.Models;

public partial class Producto
{
    public Guid Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public int Existencia { get; set; }

    public int IdMarca { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Marca IdMarcaNavigation { get; set; } = null!;
}
