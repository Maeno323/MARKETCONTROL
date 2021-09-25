using System;
using Persistencia;
using Dominio;

namespace Aplicacion
{
    class Program
    {   
        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado(new Persistencia.ApplicationDbContext());
        private static IRepositorioInventario _repoInventario = new RepositorioInventario(new Persistencia.ApplicationDbContext());
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.ApplicationDbContext());
        //private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new Persistencia.ApplicationDbContext());
        //private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.ApplicationDbContext());
        //private static IRepositorioEmpresa _repoEmpresa = new RepositorioEmpresa(new Persistencia.ApplicationDbContext());
        static void Main(string[] args)
        {
            //EJECUTAR CONSULTA DEL CRUD EMPELADO
            //AddEmpleado();
            //upDateEmpleado();
            //getEmpleado(2);
            //deleteEmpleado(6);
            //getAllEmpleado();

            //EJECUTAR CONSULTA DEL CRUD INVENTARIO
            //AddInventario();
            //updateInventario();
            //getInventario(4);
            //deleteInventario(2);
            //getAllInventario();

            //EJECUTAR CONSULTA DEL CRUD INVENTARIO
            //AddCliente();
            //getCliente(2);
            //upDateCliente();
            deleteCliente(4);
            Console.WriteLine("REVISE SU BASE DE DATOS");
            
        }
        //CRUD DE EMPLEADO

        public static void getAllEmpleado(){
            var empleado = _repoEmpleado.getAllEmpleado();
            Console.WriteLine("LISTA DE EMPLEADOS:");
            foreach(var e in empleado){

                Console.WriteLine("ID "+e.Id+", "+" Nombre: "+ e.Nombre +", "+"Correo: "+ e.Correo +", "+ "DocumentoID: "+e.DocumentoId +", "+ "Salaraio Bruto: "+e.SalarioBruto+", "+"Fecha de nacimiento: "+e.FechaDeNacimiento);
            }
            
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
        //CRUD INVENTARIO

        public static void getAllInventario(){
            var inventario = _repoInventario.getAllInventario();
            Console.WriteLine("LISTA DE PRODUCTOS:");
            foreach(var i in inventario){

                Console.WriteLine("ID "+i.Id+", "+"Nombre: "+ i.nombreProducto +", "+"Disponibilidad: "+ i.disponibilidadProducto +", "+ "Precio: "+i.precio +", "+ "stock: "+i.stock);
            }

        }
        public static void AddInventario(){
        
            var producto = new Inventario{nombreProducto = "Tomate", disponibilidadProducto = "si", stock = 25, precio=600};
            
            _repoInventario.addInventario(producto);

            Console.WriteLine("REGISTRO DE PRODUCTO EXITOSO");
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

        //CRUD CLIENTE
        public static void getAllCliente(){
            var cliente = _repoCliente.getAllCliente();
            Console.WriteLine("LISTA DE CLIENTES:");
            foreach(var c in cliente){

                Console.WriteLine("ID "+c.Id+", "+" Nombre: "+ c.Nombre +", "+"Correo: "+ c.Correo +", "+ "DocumentoID: "+c.DocumentoId +", "+"Teléfono: "+c.Telefono);
            }
            
        }
        public static void AddCliente(){
        
            Console.WriteLine("REGISTRO DE CLIENTE EXITOSO");
            
            var cliente = new Cliente{Nombre = "FuturoFruits", Correo = "futuro.gerencia@gmail.com", DocumentoId = "107834423231", Telefono="5783426cd"};
            
            _repoCliente.addCliente(cliente);
        }
        public static void upDateCliente(){

            
            var cliente = new Cliente{Id = 2, Nombre = "Mercabastos", Correo = "MercaAministracion@gmail.com", DocumentoId = "101209348745", Telefono="=5902365"};
            _repoCliente.updateCliente(cliente);
            Console.WriteLine("SE ACTUALIZÓ EL EMPLEADO CON ID " + cliente.Id); 
        }
        public static void getCliente(int idCliente){
           
            var cliente = _repoCliente.getCliente(idCliente);
            if(cliente==null){

                Console.WriteLine("NO SE ENCONTRÓ EL EMPLEADO CON ID "+idCliente);
            }
            Console.WriteLine("EL EMPLEADO CON ID "+idCliente+" CONSULTADO ES: "+ "Nombre: "+ cliente.Nombre +", "+"Correo: "+ cliente.Correo +", "+ "DocumentoID: "+cliente.DocumentoId +", "+ "Télefono: "+cliente.Telefono);

        }
        public static void deleteCliente(int idCliente){

            _repoCliente.deleteCliente(idCliente);

            Console.WriteLine("EL USUARIO CON ID "+idCliente+" HA SIDO REMOVIDO");
            
        }

    }
    

}
    
