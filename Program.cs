
internal class Program
{
    private static void Main(string[] args)
    {
        

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


     // Ordena la lista de empleados por departamento en orden ascendente
    var ordenados = from empleado in empleados
                    orderby empleado.Departamento ascending
                    select empleado;
    
    foreach (var empleado in ordenados)
    {
        System.Console.WriteLine($"{empleado.Nombre}, {empleado.Departamento}");
    }

    // Selecciona el empleado de mayor edad
    var empleadoMayorEdad = (from empleado in empleados
                            orderby empleado.Edad descending
                            select empleado).FirstOrDefault();

    System.Console.WriteLine(empleadoMayorEdad.Nombre);

    // Selecciona el primer empleado que tenga más de 30 años
    var empleadoMayor30 = (from empleado in empleados
                            where empleado.Edad > 30
                            select empleado).First();

    System.Console.WriteLine(empleadoMayor30.Nombre);


    // Selecciona los 2 primeros empleados
    var dosPrimeros = (from empleado in empleados
                       select empleado).Take(2);

    foreach (var empleado in dosPrimeros)
    {
        System.Console.WriteLine(empleado.Nombre);
    }

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
