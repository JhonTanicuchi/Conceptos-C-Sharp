using System;

namespace ConsolaInicial
{
    class Programa_consola
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"┌{new string('─', 35)}┐");
            Console.WriteLine($"│ {"".PadRight(8)} {"DATOS PERSONALES".PadRight(24)} │");
            Console.WriteLine($"└{new string('─', 35)}┘");


            /*OBTENCION DE DATOS*/
            bool val = true;

            Console.WriteLine("» Ingresa tu nombre:");
            string nombre = Console.ReadLine();
           

            Console.WriteLine("» Ingresa tu apellido:");
            string apellido = (Console.ReadLine());

            int edad = 0;
            do
            {
                val = false;
                try
                {
                    Console.WriteLine("» Ingresa tu edad:");
                    edad = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    val = true;
                    Console.WriteLine("» Edad requiere de un valor entero");
                }
            } while (val);

            Console.WriteLine("» Ingresa tu género:");
            string genero = Console.ReadLine();

            Console.WriteLine("» Ingresa tu estado civil:");
            string e_civil = Console.ReadLine();

            int telefono = 0;
            do
            {
                val = false;
                try
                {
                    Console.WriteLine("» Ingresa tu teléfono:");
                    telefono = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    val = true;
                    Console.WriteLine("» Teléfono requiere de un valor entero");
                }
            } while (val);

            decimal peso = 0;
            do
            {
                val = false;
                try
                {
                    Console.WriteLine(" Ingresa tu peso:");
                    peso = decimal.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    val = true;
                    Console.WriteLine("» Peso requiere de un valor decimal");
                }
            } while (val);

            decimal estatura = 0;
            do
            {                   
                val = false;
                try
                {
                    Console.WriteLine("» Ingresa tu estatura:");
                    estatura = decimal.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    val = true;
                    Console.WriteLine("» Estatura requiere de un valor decimal");
                }
            } while (val);

            int identificacion = 0;
            do
            {
                val = false;
                try
                {
                    Console.WriteLine("» Ingresa tu identificación:");
                    identificacion = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    val = true;
                    Console.WriteLine("» Identificación requiere de un valor entero");
                }
            } while (val);
            
            Console.WriteLine("» Ingresa tu lugar de nacimiento:");
            string lugarNacimiento= Console.ReadLine();


            /*INSTANCIAS*/
            Persona persona1 = new Persona();
            persona1.Nombre = nombre;
            persona1.Apellido = apellido;
            persona1.Edad = edad;
            persona1.Genero = genero;
            persona1.E_Civil = e_civil;
            persona1.Telefono = telefono;
            persona1.Peso = peso;
            persona1.Estatura = estatura;
            persona1.Identificacion = identificacion;
            persona1.LugarNacimiento = lugarNacimiento;


            /*VISUALIZACIÓN DE DATOS*/
           
            Console.Clear();
            Console.WriteLine($"┌{new string('─', 35)}┐");
            Console.WriteLine($"│ {"".PadRight(8)} {"DATOS PERSONALES".PadRight(24)} │");
            Console.WriteLine($"├{new string('─', 22)}┬{new string('─', 12)}┤");


            Console.WriteLine($"│ {"Nombre:".PadRight(20)} │ {persona1.Nombre.PadRight(10)} │");  
            Console.WriteLine($"│ {"Apellido:".PadRight(20)} │ {persona1.Apellido.PadRight(10)} │");
            Console.WriteLine($"│ {"Edad:".PadRight(20)} │ {persona1.Edad.ToString().PadRight(10)} │");
            Console.WriteLine($"│ {"Genero:".PadRight(20)} │ {persona1.Genero.PadRight(10)} │");
            Console.WriteLine($"│ {"Estudiante:".PadRight(20)} │ {persona1.E_Civil.PadRight(10)} │");    
            Console.WriteLine($"│ {"Teléfono:".PadRight(20)} │ {persona1.Telefono.ToString().PadRight(10)} │");
            Console.WriteLine($"│ {"Peso:".PadRight(20)} │ {persona1.Peso.ToString().PadRight(10)} │");
            Console.WriteLine($"│ {"Estatura:".PadRight(20)} │ {persona1.Estatura.ToString().PadRight(10)} │");    
            Console.WriteLine($"│ {"N° Identificación:".PadRight(20)} │ {persona1.Identificacion.ToString().PadRight(10)} │");
            Console.WriteLine($"│ {"Lugar de nacimiento:".PadRight(20)} │ {persona1.LugarNacimiento.PadRight(10)} │");


            DateTime saveNow = DateTime.Now;
            DateTime date1 = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
            Console.WriteLine($"└{new string('─', 22)}┴{new string('─', 12)}┘");
            Console.WriteLine("\n" + new string('-', 37));
            Console.WriteLine($"  {"Fecha de registro:".PadRight(20)}   {(date1.ToString("MM/dd/yyyy")).PadRight(10)}");
            Console.WriteLine($"  {"Hora de registro:".PadRight(20)}   {(date1.ToString("hh: mm tt")).PadRight(10)}");
            Console.WriteLine("\n" + new string('-', 37));


            Console.WriteLine("\n" + "Presiona cualquier tecla para finalizar el programa :)");
            Console.Read();
        }
    }
}
