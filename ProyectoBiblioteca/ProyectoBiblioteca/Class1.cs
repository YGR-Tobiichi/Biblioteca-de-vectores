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
    }
}