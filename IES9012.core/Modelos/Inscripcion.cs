using IES9012.core.Enumeraciones;
using System.ComponentModel.DataAnnotations;

namespace IES9012.core.Modelos
{
    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        //La propiedad MateriaId es una clave externa y la propiedad de
        //navegacion correspondiente es Materia.
        //Una entidad Inscripcion esta asociada con una entidad Materia.
        public int MateriaId { get; set; }
        //La propiedad MateriaId es una clave externa y la propiedad de
        //navegacion correspondiente es Estudiante.
        //Una entidad Inscripcion esta asociada con una entidad Estudiante.
        public int EstudianteId { get; set; }
        [DisplayFormat(NullDisplayText = "Sin Nota")]
        public Nota? Nota { get; set; }
        public Materia? Materia { get; set; }
        public Estudiante? Estudiante { get; set; }

    }
}