using NLog;

public class Alumno
{
public static Logger logger = LogManager.GetCurrentClassLogger();
public int Id { get; set; }
public string Nombre { get; set; }
public string Apellido { get; set; }
public int Dni { get; set; }
public int Curso { get; set; }
}
