using System.ComponentModel.DataAnnotations;

namespace Clase4.MVC.Web.Models;
public class DiaEspecialModel
{
    [Required(ErrorMessage = "¡La fecha es requerida!")]
    [DataType(DataType.Date, ErrorMessage="La fecha ingresada no está en un formato válido")]
    public DateTime Fecha { get; set; }
    [Required(ErrorMessage = "¡El nombre es requerido!")]
    [StringLength(50, ErrorMessage = "¡El nombre no puede superar los 50 caracteres!")]
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
}
