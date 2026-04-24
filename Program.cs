using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        // List<int> numeros = new List<int> {50, 55, 78, 90 , 100, 1, 20};

        // var pasan = from numero in numeros
        //             where numero > 50
        //             orderby numero ascending
        //             select numero;

        // foreach (var numero in pasan)
        // {
        //     System.Console.WriteLine(numero);
        // }

        // List<string> nombres = new List<string> {"Daniel", "Emanuel", "Messi", "Cris", "Ada" };

        // var found = from nombre in nombres
        //             where (nombre.Contains('e'))
        //             select nombre;

        // foreach (var nombre in found)
        // {
        //     System.Console.WriteLine(nombre);
        // }

        // List<string> nombres2 = new List<string> {"Ada", "Guillermo", "Cris", "Lucas", "Roc"};

        // var largo = from nombre1 in nombres2
        //             orderby nombre1.Length
        //             select nombre1;

        // foreach (var nombre1 in largo)
        // {
        //     System.Console.WriteLine(nombre1);
        // }

        // System.Console.WriteLine("---------------------------------");



        // List<Productos> productos = new List<Productos>
        // {
        //     new Productos {Nombre = "Lapiz", Precio = 21},
        //     new Productos {Nombre = "Pen", Precio = 30},
        //     new Productos {Nombre = "Libro", Precio = 100},
        //     new Productos {Nombre = "Mochila", Precio = 105},
        //     new Productos {Nombre = "Juego", Precio = 44},

        // };


        // var orden = from producto in productos
        //             where producto.Precio < 100
        //             orderby producto.Precio ascending
        //             select producto;

        // foreach (var Productos in orden)
        // {
        //     System.Console.WriteLine(Productos);
        // }




        // List<Empleado> empleados = new List<Empleado>
        // {
        //     new Empleado{ Nombre = "Ana"}
        // };




        // var resultado = from empleado in empleados
        //                 where empleado.Experiencia > 5
        //                 orderby empleado.Experiencia descending
        //                 select empleado;

        // foreach (var item in empleados)
        // {
        //     System.Console.WriteLine(item);
        // }


        List<Empleado> empleados = new List<Empleado>
    {
    new Empleado ("Laura", 28, "Marketing"),
    new Empleado ("Carlos", 35, "Ventas"),
    new Empleado ("Sofía", 19, "Marketing"),
    new Empleado ("Javier", 42, "Finanzas"),
    new Empleado ("Marta", 31, "Ventas")
    };

        //Menores de 20
    var menores = from empleado in empleados
                where empleado.Edad < 20
                select empleado;

    foreach (var empleado in menores)
    {
        System.Console.WriteLine(empleado.Nombre);
    }

    // Promedio edad

    double promedio = (from media in empleados
                    select media.Edad).Average();
                    
    System.Console.WriteLine(promedio);

                        

}



    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Departamento { get; set; }
        public Empleado(string nombre, int edad, string
        departamento)
        {
            Nombre = nombre;
            Edad = edad;
            Departamento = departamento;
        }
    }




}
