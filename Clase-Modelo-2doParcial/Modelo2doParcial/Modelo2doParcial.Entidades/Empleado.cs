using System.ComponentModel.DataAnnotations;

namespace Modelo2doParcial.Entidades.EF;

[MetadataType(typeof(EmpleadoMetadata))]
public partial class Empleado
{

}

public class EmpleadoMetadata
{
    [Required(ErrorMessage = "El campo NombreCompleto es obligatorio.")]
    public string NombreCompleto { get; set; }
}