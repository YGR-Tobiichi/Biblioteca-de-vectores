namespace ElProductoPunto
{
    using ProyectoBiblioteca;
    using System.Runtime.CompilerServices;

    internal class Program
    {
        static void Main(string[] args)
        {
            int operacion;
            bool continuar = true;
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
            Console.Clear();

            while (continuar)
            {
                Console.WriteLine("Seleccione la operación que desea realizar:");

                Console.WriteLine("1. Calcular el producto punto de los vectores.");
                Console.WriteLine("2. Calcular la proyección del vector 1 sobre el vector 2.");
                Console.WriteLine("3. Angulo entre los vectores");
                Console.WriteLine("4. Sumar los vectores.");
                Console.WriteLine("5. Restar los vectores.");
                Console.WriteLine("6. Salir.");

                operacion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (operacion)
                {
                    case 1:
                        Console.WriteLine("El producto punto de los vectores es: "
                            + Vector.CalcularProductoPunto(vector1, vector2));
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("La proyección del vector 1 sobre el vector 2 es: "
                            + Vector.CalcularProyeccionEscalar(vector1, vector2));
                        }
                        catch (Exception x)
                        {
                            Console.WriteLine(x.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("El ángulo entre los vectores es: "
                            + Vector.CalcularAngulo(vector1, vector2) + " grados");
                        }
                        catch (Exception x)
                        {
                            Console.WriteLine(x.Message);
                        }
                        break;
                    case 4:
                        Vector resultadoSuma = Vector.SumarVectores(vector1, vector2);
                        Console.WriteLine("La suma de los vectores es: (" 
                            + resultadoSuma.ComponenteX + ", " 
                            + resultadoSuma.ComponenteY + ")");
                        break;
                    case 5:
                        Vector resultadoResta = Vector.RestarVectores(vector1, vector2);
                        Console.WriteLine("La resta de los vectores es: (" 
                            + resultadoResta.ComponenteX + ", " 
                            + resultadoResta.ComponenteY + ")");
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 6.");
                        break;
                }

                Console.WriteLine("¿Desea realizar otra operación? (s/n)");
                if (Console.ReadLine().ToLower() != "s")
                {
                    continuar = false;
                }
                Console.Clear();
            }
        }
    }
}
