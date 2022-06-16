using System.ComponentModel.DataAnnotations;
namespace IES9012.core.Modelos
{
    public class Estudiante
    {
        //La propieda ID se convierte en la columna de clave principal de la
        //tabla de base de datos
        public int EstudianteId { get; set; }
        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }
        [Required]
        [StringLength(35)]
        public string? Apellido { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:dd/MM/yyyy", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Inscripción")]
        public DateTime FechaInscripcion { get; set; } = DateTime.Now;
        public ICollection<Inscripcion>? Inscripciones { get; set; }

    }
}
//Coleccion: Tipo de dato que va a contener otros tipos de datos.
//La propiedad inscripcion es una propiedad de navegacion.
//Las propiedades de navegacion contienen otras entidades relacionadas con esta entidad.
//La propiedad inscripones se define como Icollection<Inscripcion>
//porque puede haber varias entiedades Inscripcion relacionadas con Estudiante.