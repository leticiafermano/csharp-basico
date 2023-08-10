namespace CSharp_ConversaoImplicitaeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Conversão implicita */
            float a = 4.1f; // Float = 4 bits
            double b = a; // Double = 8 bits
            Console.WriteLine(b);


            /* Casting - Conversão explicita */
            a = 5.4f;
            b = (float)a;
            Console.WriteLine(b);


            /* Nesse caso abaixo, haverá perda de informação devido ao truncamento */
            double c = 5.9;
            int d = (int)a;
            Console.WriteLine(d);


            int x = 5;
            int y = 2;

            double resultado = (double)x / y;
            Console.WriteLine(resultado);
        }
    }
}