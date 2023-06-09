using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Peliculas.Entities;

namespace Peliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<CineOferta> CinesOfertas { get; set; }
        public DbSet<SalaDeCine> SalasDeCines { get; set; }
        public DbSet<PeliculaActor> PeliculasActores { get; set; }

        //Convenciones
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //Configuramos que todos los campos de tipo DateTime seran de tipo date
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }

        //Api Fluente
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Importando las configuraciones de las entidades
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //Declarando clave primaria desde el ApiFluente
            // modelBuilder.Entity<Genero>().HasKey(prop => prop.NombreDiferente);

            //Para definir el tamaño del campo
            //Tambien hacerlo requerido
            // modelBuilder.Entity<Genero>().Property(prop => prop.Nombre).HasMaxLength(150).IsRequired();
            //Si su nombre es cambiado manualmente se debe agregar .HasColumnName("NombreGenero")

            //Se puede cambiar el nombre de la tabla y de la base de datos
            // modelBuilder.Entity<Genero>().ToTable(name: "TablaGeneros", schema:"peliculas");    

            //Cambiando la fecha y hora a solo fecha
            // modelBuilder.Entity<Actor>().Property(prop => prop.FechaNacimiento)
            // .HasColumnType("date");

            //Poniendo la longitud del decimal
            // modelBuilder.Entity<Cine>().Property(prop => prop.Precio)
            // .HasPrecision(precision: 9, scale: 2);

            //Agregando el atributo Unicode
            // modelBuilder.Entity<Pelicula>().Property(prop => prop.PostURL)
            // .IsUnicode(false);

            //Agregando Valor por defecto
            // modelBuilder.Entity<SalaDeCine>().Property(prop => prop.TipoSalaDeCine)
            // .HasDefaultValue(TipoSalaDeCine.DosDimensiones);
        }

    }
}
