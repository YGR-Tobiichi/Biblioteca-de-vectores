namespace ElProductoPunto
{
    using ProyectoBiblioteca;
    using System.Runtime.CompilerServices;

    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector();
            Vector vector2 = new Vector();

            Console.WriteLine("Ingrese componente x del vector 1.");
            vector1.ComponenteX = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese componente y del vector 1.");
            vector1.ComponenteY = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese componente x del vector 2.");
            vector2.ComponenteX = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese componente y del vector 2.");
            vector2.ComponenteY = double.Parse(Console.ReadLine());

            Console.WriteLine("El producto punto de los vectores es: " 
                + Vector.CalcularProductoPunto(vector1, vector2));
            try
            {
                Console.WriteLine("La proyección del vector 1 sobre el vector 2 es: "
                + Vector.CalcularProyeccionEscalar(vector1, vector2));
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            Console.ReadLine();
        }
    }
}
