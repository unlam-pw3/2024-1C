using System.ComponentModel.DataAnnotations;

namespace Clase4.MVC.Web.Models;
public class DiaEspecialModel
{
    [Required(ErrorMessage = "¡La fecha es requerida!")]
    [DataType(DataType.Date, ErrorMessage="La fecha ingresada no está en un formato válido")]
    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "¡El nombre es requerido!")]
    [StringLength(50, ErrorMessage = "¡El nombre no puede superar los 50 caracteres!")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras y espacios")]
    public string Nombre { get; set; }

    [StringLength(150, ErrorMessage = "La descripción no puede superar los 200 caracteres")]
    [Required(ErrorMessage = "¡La descripcion es requerida!")]
    public string Descripcion { get; set; }
}
