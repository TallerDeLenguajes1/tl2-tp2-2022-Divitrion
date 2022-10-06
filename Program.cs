string deporte;
int id=1;

do
{
    Alumno alumno = new Alumno();
    try
    {
        Console.WriteLine("Ingrese el apellido del alumno");
        alumno.Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del alumno");
        alumno.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el DNI del alumno");
        alumno.Dni = Console.ReadLine();
        Console.WriteLine("Ingrese el curso del alumno");
        alumno.Curso = Console.ReadLine();
        alumno.Id = id;
        Console.WriteLine("Ingrese el deporte a inscribir: Voley, Futbol, Atletismo");
        deporte = Console.ReadLine();
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato invalido, Ingrese de nuevo los datos.\n")
    }
    HelperdeArchivos.writeCSV(alumno,deporte + ".csv");
} while (true);