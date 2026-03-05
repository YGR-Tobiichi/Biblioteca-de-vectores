namespace ProyectoBiblioteca
{
    public class Vector
    {
        private double componenteX;
        private double componenteY;

        public double ComponenteX { get => componenteX; set => componenteX = value; }
        public double ComponenteY { get => componenteY; set => componenteY = value; }

        public double Magnitud()
        {
            return Math.Sqrt(Math.Pow(ComponenteX, 2) + Math.Pow(ComponenteY, 2));
        }

        public static double CalcularProductoPunto(Vector vector1, Vector vector2)
        {
            return (vector1.ComponenteX * vector2.ComponenteX) + (vector1.ComponenteY * vector2.ComponenteY);
        }

        public static double CalcularProyeccionEscalar(Vector vector1, Vector vector2)
        {
            double productoPunto = CalcularProductoPunto(vector1, vector2);
            double magnitudVector2 = vector2.Magnitud();
            if (magnitudVector2 == 0)
            {
                throw new Exception("El vector de referencia no puede ser el vector cero.");
            }
            return productoPunto / magnitudVector2;
        }
        public static double CalcularAngulo(Vector vector1, Vector vector2)
        {
            double productoPunto = CalcularProductoPunto(vector1, vector2);
            double magnitudVector1 = vector1.Magnitud();
            double magnitudVector2 = vector2.Magnitud();

            if (magnitudVector1 == 0 || magnitudVector2 == 0)
            {
                throw new Exception("No se puede calcular el ángulo con un vector cero.");
            }
            double cosenoAngulo = productoPunto / (magnitudVector1 * magnitudVector2);
            return Math.Acos(cosenoAngulo) * (180.0 / Math.PI);
        }
        public static Vector SumarVectores(Vector vector1, Vector vector2)
        {
            return new Vector
            {
                ComponenteX = vector1.ComponenteX + vector2.ComponenteX,
                ComponenteY = vector1.ComponenteY + vector2.ComponenteY
            };
        }
        public static Vector RestarVectores(Vector vector1, Vector vector2)
        {
            return new Vector
            {
                ComponenteX = vector1.ComponenteX - vector2.ComponenteX,
                ComponenteY = vector1.ComponenteY - vector2.ComponenteY
            };
        }
    }
}