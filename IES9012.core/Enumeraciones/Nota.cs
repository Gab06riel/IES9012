using System.ComponentModel.DataAnnotations;
namespace IES9012.core.Enumeraciones
{
    public enum Nota
    {
        Mal = 0,
        Deficiente = 20,
        Regular = 40,
        Bien = 60,
        MuyBien = 80,
        Sobresaliente = 100
    }
}
//De forma predeterminada los valores de constaste asociados de miembos de
//numeracion son de tipo int:
//Comienzan con cero y aumentan en uno despues del orden del texto de la definicion.
//Puede especificar explicitamente cualquier otro tipo de numerico enteto como
//un tipo subyacente de un tipo de enumeracion. Tambien puede especificar explicitamente
//los valores de constante asociados, como se muestra en el ejemplo anterior.