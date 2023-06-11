using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Peliculas.Entities
{
    public class Pelicula
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Titulo { get; set; }
        public bool EnCartelera { get; set; }
        public DateTime FechaEstreno { get; set; }
        [MaxLength(500)]
        //Agregando el atributo Unicode
        [Unicode(false)]
        //Tambien se puede hacer desde el api fluente
        public string PosterURL { get; set; }
        public HashSet<Genero> Generos { get; set; }
        public HashSet<SalaDeCine> SalasDeCine { get; set; }
        public HashSet<PeliculaActor> PeliculasActores { get; set; }
    }
}