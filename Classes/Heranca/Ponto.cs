namespace Classes.Heranca
{
    public class Ponto
    {
        public int x, y;
        private double distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected double CalcularDistancia(int[] p1, int[] p2)
        {
            if (p1.Length != 2 || p2.Length != 2) 
            {
                throw new System.InvalidOperationException("Os dois pontos devem ter uma abscissa e uma ordenada.");
            }

            int distX = p1[0] - p1[0];
            int distY = p1[1] - p1[1];

            distancia = System.Math.Sqrt(System.Math.Pow(distX, 2) + System.Math.Pow(distY, 2));
            return distancia;
        }

        private void CalcularDistancia2()
        {
            // do something;
        }

        public virtual void CalcularDistancia3()
        {
            // do something;
        }
    }
}