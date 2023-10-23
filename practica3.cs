namespace Practica3
{
    internal class Program
    {
        const int puedeConducir = 18;
        const string tieneCarnet = "S";

        static void Main()
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir, introduce tu edad");
            int edad = Int32.Parse(Console.ReadLine());

            string carnet = LeerRespuesta("¿Tienes carnet? (S/N)");

            if (edad >= puedeConducir && carnet == tieneCarnet)
            {
                Console.WriteLine("Puedes conducir");
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }
        }

        static string LeerRespuesta(string mensaje)
        {
            string respuesta;
            do
            {
                Console.WriteLine(mensaje);
                respuesta = Console.ReadLine().ToUpper();
                if (respuesta != "S" && respuesta != "N")
                {
                    Console.WriteLine("Se debe introducir N o S");
                }
            } while (respuesta != "S" && respuesta != "N");
            return respuesta;
        }
    }
}