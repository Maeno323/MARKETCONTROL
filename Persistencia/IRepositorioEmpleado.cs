using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> getAllEmpleado();
        Empleado addEmpleado(Empleado empleado);
        Empleado updateEmpleado(Empleado empleado);
        Empleado getEmpleado(int idEmpleado);
        void deleteEmpleado(int idEmpleado);
        
    }
}