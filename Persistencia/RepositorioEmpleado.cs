using Dominio;
using System.Collections.Generic;
using System.Linq; 
namespace Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        public readonly ApplicationDbContext _appContext;

        
        public RepositorioEmpleado(ApplicationDbContext appContext){

            _appContext=appContext;

        }

        Empleado IRepositorioEmpleado.addEmpleado(Empleado empleado)
        {
            var new_empleado = _appContext.empleados.Add(empleado);
            _appContext.SaveChanges();
            return new_empleado.Entity;
        }
        Empleado IRepositorioEmpleado.updateEmpleado(Empleado empleado){

            var empleadoEncontrado = _appContext.empleados.FirstOrDefault(p=> p.Id ==empleado.Id);

            if(empleadoEncontrado!=null){

                empleadoEncontrado.Nombre = empleado.Nombre;
                empleadoEncontrado.Correo = empleado.Correo;
                empleadoEncontrado.DocumentoId = empleado.DocumentoId;
                empleadoEncontrado.SalarioBruto = empleado.SalarioBruto;
                empleadoEncontrado.FechaDeNacimiento = empleado.FechaDeNacimiento;
                _appContext.SaveChanges();

            }

            return empleadoEncontrado;
        }

        Empleado IRepositorioEmpleado.getEmpleado(int idEmpleado){

            return _appContext.empleados.FirstOrDefault(p=> p.Id ==idEmpleado);
            
        }

        
        void IRepositorioEmpleado.deleteEmpleado(int idEmpleado){

            var empleadoEncontrado = _appContext.empleados.FirstOrDefault(p=> p.Id ==idEmpleado);

            
            _appContext.Remove(empleadoEncontrado);
            _appContext.SaveChanges();


           
        }
        
    }
}