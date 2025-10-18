namespace _28._ProgramacionModular_
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
                MostrarMensaje();
                MostrarMensajes("Soy Jeslyn");
                MostrarMensajes($"Tengo{CalcularEdad()}años");
                MostrarMensajes($"Tengo{CalcularEdad(2025, 2006)}");
            }

            //Modulo 1- Procedimiento sin parametros 
            static void MostrarMensaje()
            {
                Console.WriteLine("bienvenido a la programacion modular");
            }

            //Modulo 2- Procedimiento con parametros 
            static void MostrarMensajes(string mensaje)
            {
                Console.WriteLine(mensaje);
            }
            //Modulo 3- Funsion sin parametros
            static int CalcularEdad()
            {
                int edad = 2025 - 2006;
                return edad;
            }
            //Modulo 4- Funcion con parametros 
            static int CalcularEdad(int añoActual, int añoNacimiento)
            {
                return añoActual - añoNacimiento;
            }
        
    }
    
}
