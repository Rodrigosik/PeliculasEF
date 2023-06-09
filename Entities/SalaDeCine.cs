using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Peliculas.Entities
{
    public class SalaDeCine
    {
        public int Id { get; set; }
        //Agregando Valor por defecto
        //Tambien se puede hacer desde el api fluente
        [DefaultValue(TipoSalaDeCine.DosDimensiones)]
        public TipoSalaDeCine TipoSalaDeCine { get; set; }
        //Poniendo la longitud del decimal
        //Tambien se puede hacer desde el api fluente
        [Precision(precision: 9, scale: 2)]
        public decimal Precio { get; set; }
        public int CineId { get; set; }
        public Cine Cine { get; set; }

        public HashSet<Pelicula> Pelculas { get; set; }
    }
}