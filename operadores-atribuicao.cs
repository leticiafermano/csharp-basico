namespace CSharp_OperadoresDeAtribuição
{
    class Program
    {
        static void Main(string[] args)
        {
            /* OPERADORES DE ATRIBUIÇÃO
                a = 10; (a recebe 10)
                a += 2; (a recebe a+2)
                a -= 2; (a recebe a-2)
                a *= 2; (a recebe a*2)
                a/= 2; (a recebe a/2)
                a %= 3; (a recebe a %3)
            
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);
            */

            /* A+
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);
            */

            /* TAMBÉM É USUAL EM CASO DE STRING's
            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);
            */

            /* A++ OU A--
            int a = 10;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b); // lê-se o valor de a em b e acrescenta o valor em a
            */

            int a = 10;
            int b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b); // Primeiro incrementa-se a variavel A e depois incrementa na variavel B

        }
    }
}