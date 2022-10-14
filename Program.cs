string deporte = null;
int id=1;
int flag = 1;

NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

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
        alumno.Dni = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el curso del alumno");
        alumno.Curso = Convert.ToInt32(Console.ReadLine());
        alumno.Id = id;
        Console.WriteLine("Ingrese el deporte a inscribir: Voley, Futbol, Atletismo");
        deporte = Console.ReadLine();
        HelperdeArchivos.writeCSV(alumno,deporte + ".csv");
        Console.WriteLine("Quiere ingresar otro alumno?");
        flag = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Formato invalido, Ingrese de nuevo los datos.\n");

        var mensaje = "Error message: " + ex.Message;

                if (ex.InnerException != null)
                {
                    mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                }

                mensaje = mensaje + " Stack trace: " + ex.StackTrace;

                logger.Error(mensaje);
                logger.Debug(mensaje);
    }
} while (flag == 1);