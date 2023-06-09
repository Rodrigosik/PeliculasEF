using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Peliculas.Entities
{
    //Se puede cambiar el nombre de la tabla y de la base de datos
    // [Table("TablaGeneros", Schema = "peliculas")]
    //Tambien se puede hacer desde el api fluente
    public class Genero
    {
        //Por defecto todas las variables que lleven o se nombre Id sera primarias
        //En dado caso que no se llamen asi se pueden atribuir con el atributo
        // [key]
        //Tambien se puede hacer desde el api fluente
        public int Id { get; set; }

        //Para definir el tamaño del campo
        [MaxLength(50)]
        //Tambien se puede ocupar [StringLength(50)]
        //Tambien se puede hacer desde el api fluente

        //Para hacer el campo obligatorio
        [Required]
        //Tambien se puede hacer desde el api fluente

        //Cambiar de nombre en la db
        // [Column("NombreGenero")]
        //Tambien se puede hacer desde el api fluente
        public string Nombre { get; set; }
        public HashSet<Pelicula> Peliculas { get; set; }
    }
}