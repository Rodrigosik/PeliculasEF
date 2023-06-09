using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Peliculas.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }
        public string Biografia { get; set; }

        //Cambiando la fecha y hora a solo fecha
        // [Column(TypeName = "Date")]
        //Tambien se puede hacer desde el api fluente
        //Tambien se define globalmente en las convenciones
        //con el ? definimos que puede ser nulo
        public DateTime? FechaNacimiento { get; set; }
        public HashSet<PeliculaActor> PeliculasActores { get; set; }
    }
}