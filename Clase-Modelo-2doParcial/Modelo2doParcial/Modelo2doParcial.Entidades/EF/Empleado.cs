using System;
using System.Collections.Generic;

namespace Modelo2doParcial.Entidades.EF
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public int IdSucursal { get; set; }

        public virtual Sucursal IdSucursalNavigation { get; set; } = null!;
    }
}
