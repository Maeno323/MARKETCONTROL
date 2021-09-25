using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioInventario
    {
        IEnumerable<Inventario> getAllInventario();
        Inventario addInventario(Inventario inventario);
        
        Inventario updateInventario(Inventario inventario);
        Inventario getInventario(int idInventario);
        
        void deleteInventario(int idInventario); 
    }
}