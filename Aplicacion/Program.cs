using System;
using Persistencia;
using Dominio;

namespace Aplicacion
{
    class Program
    {   
        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado(new Persistencia.ApplicationDbContext());
        static void Main(string[] args)
        {
            //AddEmpleado();
            //upDateEmpleado();
            //getEmpleado(2);
            //deleteEmpleado(6);
            Console.WriteLine("REVISE SU BASE DE DATOS");
            
        }
        
        public static void AddEmpleado(){
        
            Console.WriteLine("REGISTRO DE EMPLEADO EXITOSO");
            
            var empleado = new Empleado{Nombre = "Peter Parker", Correo = "peter@spider.com", DocumentoId = "1057932884", SalarioBruto=2100000, FechaDeNacimiento=1992};
            
            _repoEmpleado.addEmpleado(empleado);
        }
        public static void upDateEmpleado(){

            
            var empleado = new Empleado{Id = 4, Nombre = "James Howlett", Correo = "agujadinamica@gmail.com", DocumentoId = "1012090443", SalarioBruto=5000000, FechaDeNacimiento=1875};
            _repoEmpleado.updateEmpleado(empleado);
            Console.WriteLine("SE ACTUALIZÓ EL EMPLEADO CON ID " + empleado.Id); 
        }
        public static void getEmpleado(int idEmpleado){
           
            var empleado = _repoEmpleado.getEmpleado(idEmpleado);
            if(empleado==null){

                Console.WriteLine("NO SE ENCONTRÓ EL EMPLEADO CON ID "+idEmpleado);
            }
            Console.WriteLine("EL EMPLEADO CON ID "+idEmpleado+" CONSULTADO ES: "+ "Nombre: "+ empleado.Nombre +", "+"Correo: "+ empleado.Correo +", "+ "DocumentoID: "+empleado.DocumentoId +", "+ "Salaraio Bruto: "+empleado.SalarioBruto+", "+"Fecha de nacimiento: "+empleado.FechaDeNacimiento);

        }
        public static void deleteEmpleado(int idEmpleado){

            _repoEmpleado.deleteEmpleado(idEmpleado);

            Console.WriteLine("EL USUARIO CON ID "+idEmpleado+" HA SIDO REMOVIDO");
            
        }

    }
    

}
    
