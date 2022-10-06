public class HelperdeArchivos
{
    public static void writeCSV(Alumno alumno,string archivo)
    {
        using (StreamWriter sw = new StreamWriter(File.Open(archivo,FileMode.Append)))
        {
            sw.WriteLine($"{alumno.Apellido},{alumno.Nombre},{alumno.Dni},{alumno.Id},{alumno.Curso}\n");
            sw.Close();
        }
    }

    public static void clearCSV(string archivo)
    {
        File.WriteAllText(archivo,"");
    }
}