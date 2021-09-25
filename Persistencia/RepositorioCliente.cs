using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class RepositorioCliente: IRepositorioCliente
    {
        public readonly ApplicationDbContext _appContext;

        
        public RepositorioCliente(ApplicationDbContext appContext){

            _appContext=appContext;

        }

        IEnumerable<Cliente> IRepositorioCliente.getAllCliente(){
            return _appContext.clientes;
        }
        Cliente IRepositorioCliente.addCliente(Cliente cliente)
        {
            var new_cliente = _appContext.clientes.Add(cliente);
            _appContext.SaveChanges();
            return new_cliente.Entity;
        }
        Cliente IRepositorioCliente.updateCliente(Cliente cliente){

            var clienteEncontrado = _appContext.clientes.FirstOrDefault(p=> p.Id ==cliente.Id);

            if(clienteEncontrado!=null){

                clienteEncontrado.Nombre = cliente.Nombre;
                clienteEncontrado.Correo = cliente.Correo;
                clienteEncontrado.DocumentoId = cliente.DocumentoId;
                clienteEncontrado.Telefono = cliente.Telefono;
                _appContext.SaveChanges();

            }

            return clienteEncontrado;
        }

        Cliente IRepositorioCliente.getCliente(int idCliente){

            return _appContext.clientes.FirstOrDefault(p=> p.Id ==idCliente);
            
        }

        
        void IRepositorioCliente.deleteCliente(int idCliente){

            var clienteEncontrado = _appContext.clientes.FirstOrDefault(p=> p.Id ==idCliente);

            
            _appContext.Remove(clienteEncontrado);
            _appContext.SaveChanges();

           
        }
    }
}