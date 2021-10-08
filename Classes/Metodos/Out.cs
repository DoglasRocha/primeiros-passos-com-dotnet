namespace Classes.Metodos
{
    public class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto) // out é a variável a ser preenchida (um retorno implícito) 
        {
            resultado = x / y;
            resto = x % y;
        }

        public static void Dividir()
        {
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto); // escreve "3 1", interpolação de string
        }
    }
}