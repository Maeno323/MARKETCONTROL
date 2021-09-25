using Dominio;
using System.Collections.Generic;
using System.Linq; 
namespace Persistencia
{
    public class RepositorioInventario:IRepositorioInventario
    {
        public readonly ApplicationDbContext _appContext;

        //Es es el constructor de la clase
        public RepositorioInventario(ApplicationDbContext appContext){

            _appContext=appContext;

        }

        Inventario IRepositorioInventario.addInventario(Inventario inventario)
        {
            var new_inventario = _appContext.inventarios.Add(inventario);
            _appContext.SaveChanges();
            return new_inventario.Entity;
        }

        IEnumerable<Inventario> IRepositorioInventario.getAllInventario(){

           return _appContext.inventarios;
        }
        
        Inventario IRepositorioInventario.updateInventario(Inventario inventario){

            var inventarioEncontrado = _appContext.inventarios.FirstOrDefault(p=> p.Id ==inventario.Id);

            if(inventarioEncontrado!=null){

                inventarioEncontrado.nombreProducto = inventario.nombreProducto;
                inventarioEncontrado.disponibilidadProducto = inventario.disponibilidadProducto;
                inventarioEncontrado.stock = inventario.stock;
                inventarioEncontrado.precio = inventario.precio;
               
                _appContext.SaveChanges();

            }

            return inventarioEncontrado;
        }
        
        Inventario IRepositorioInventario.getInventario(int idInventario){

            return _appContext.inventarios.FirstOrDefault(p=> p.Id ==idInventario);
            
        }

        
        void IRepositorioInventario.deleteInventario(int idInventario){

            var inventarioEncontrado = _appContext.inventarios.FirstOrDefault(p=> p.Id ==idInventario);

            
            _appContext.Remove(inventarioEncontrado);
            _appContext.SaveChanges();

           
        }
    }
}