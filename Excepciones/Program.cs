using System;
using System.IO;
using System.Text;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileStream fs;
            try
            {
                fs = File.Create("E:\\aquiEstoy.txt");
            }
            catch (UnauthorizedAccessException e)
            {
                System.Diagnostics.Trace.TraceError(e.Message);
                Console.WriteLine("No hay acceso de lectura.");

                return;
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.TraceError(e.Message);
                Console.WriteLine("No hay acceso de lectura.");

                return;

            }
            Byte[] data = Encoding.UTF8.GetBytes("Un texto");
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();

            Console.WriteLine("Chao");

        }
    }
}
