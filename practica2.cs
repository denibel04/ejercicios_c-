namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int puedeConducir = 18;
            const string tieneCarnet = "S";
            Console.WriteLine("Vamos a evaluar si puedes conducir, introduce tu edad");
            int edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("¿Tienes carnet? (S/N)");
            string carnet = Console.ReadLine().ToUpper();

            if (edad >= puedeConducir && carnet == tieneCarnet)
            {
                Console.WriteLine("Puedes conducir");
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }
        }
    }
}