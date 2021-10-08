namespace Classes.Heranca 
{
    public class Ponto3D : Ponto
    {
        public int z;

        public Ponto3D(int x, int y, int z) : base(x, y) // "base" serve para chamar a super classe
        {
            this.z = z;
            int[] p1 = {1, 2};
            int[] p2 = {3, 4};
            CalcularDistancia(p1, p2);
        }

        public static void Calcular()
        {
            // do something
        }

        public override void CalcularDistancia3()
        {
            // do something
        }
    }
}