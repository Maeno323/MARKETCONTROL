using System;
using Persistencia;
using Dominio;

namespace Aplicacion
{
    class Program
    {   
        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado(new Persistencia.ApplicationDbContext());
        private static IRepositorioInventario _repoInventario = new RepositorioInventario(new Persistencia.ApplicationDbContext());
        
        static void Main(string[] args)
        {
            //EJECUTAR CONSULTA DEL CRUD EMPELADO
            //AddEmpleado();
            //upDateEmpleado();
            //getEmpleado(2);
            //deleteEmpleado(6);

            //EJECUTAR CONSULTA DEL CRUD INVENTARIO
            //AddInventario();
            //updateInventario();
            //getInventario(4);
            deleteInventario(2);
            Console.WriteLine("REVISE SU BASE DE DATOS");
            
        }
        //CRUD DE EMPLEADO
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
        //CRUD INVENTARIO
        public static void AddInventario(){
        
            Console.WriteLine("REGISTRO DE PRODUCTO EXITOSO");
            
            var producto = new Inventario{nombreProducto = "Tomate", disponibilidadProducto = "si", stock = 25, precio=600};
            
            _repoInventario.addInventario(producto);
        }
        public static void updateInventario(){

            
            var inventario = new Inventario{Id = 4, nombreProducto = "Papa", disponibilidadProducto = "si", stock = 60, precio=500};
            _repoInventario.updateInventario(inventario);
            Console.WriteLine("SE ACTUALIZÓ EL PRODUCTO CON ID " + inventario.Id); 
        }
        public static void getInventario(int idInventario){
           
            var inventario = _repoInventario.getInventario(idInventario);
            if(inventario==null){

                Console.WriteLine("NO SE ENCONTRÓ EL PRODUCTO CON ID "+idInventario);
            }
            Console.WriteLine("EL PRODUCTO CON ID "+idInventario+" CONSULTADO ES: "+ "Nombre: "+ inventario.nombreProducto +", "+"Disponibilidad: "+ inventario.disponibilidadProducto +", "+ "Precio: "+inventario.precio +", "+ "stock: "+inventario.stock);

        }
        public static void deleteInventario(int idInventario){

            _repoInventario.deleteInventario(idInventario);

            Console.WriteLine("EL PRODUCTO CON ID "+idInventario+" HA SIDO REMOVIDO");
            
        }

    }
    

}
    
