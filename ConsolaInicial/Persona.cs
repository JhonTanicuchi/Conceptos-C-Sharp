namespace ConsolaInicial
{
    class Persona
    {
        string nombre;
        string apellido;
        int edad;
        string genero;
        string e_Civil;
        int telefono;
        decimal peso;
        decimal estatura;
        int identificacion;
        string lugarNacimiento;


        internal string Nombre { get { return nombre; } set { nombre = value; } }
        internal string Apellido { get { return apellido; } set { apellido = value; } }
        internal int Edad { get { return edad; } set { edad = value; } }
        internal string Genero { get { return genero; } set { genero = value; } }
        internal string E_Civil { get { return e_Civil; } set { e_Civil = value; } }
        internal int Telefono { get { return telefono; } set { telefono = value; } }
        internal decimal Peso { get { return peso; } set { peso = value; } }
        internal decimal Estatura { get { return estatura; } set { estatura = value; } }
        internal int Identificacion { get { return identificacion; } set { identificacion = value; } }
        internal string LugarNacimiento { get { return lugarNacimiento; } set { lugarNacimiento = value; } }
    }
}