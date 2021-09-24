using Dominio;
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class ApplicationDbContext : DbContext
    {

        private const string connectionString =@"Data Source=localhost\sqlexpress;Initial Catalog = MARKETCONTROL;Integrated Security = True";

        public DbSet <Empresa> empresas {get; set;}

        public DbSet <Cliente> clientes {get; set;}

        public DbSet <Proveedor> proveedores {get; set;}

        public DbSet <Empleado> empleados {get; set;}

        public DbSet <Directivo> directivos {get; set;}

        public DbSet <Inventario> inventarios {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured){

                optionsBuilder.UseSqlServer(connectionString);

            

            }
            
        }


        
    }
}