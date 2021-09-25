using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> getAllCliente();
        Cliente addCliente(Cliente cliente);
        
        Cliente updateCliente(Cliente cliente);
        Cliente getCliente(int cliente);
        
        void deleteCliente(int cliente); 
    }
}