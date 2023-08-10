namespace LogicaDeProgramação_ConstantesEVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* OPERADOREA LÓGICOS:
            + = Soma
            - = Subtração
            * = Multiplicação
            / = Divisão
            % = Resto da divisão (Mode)
             */

            int x;
            int y;
            int soma;
            int subtracao;
            int multiplicacao;
            int divisao;

            // Soma 
            Console.WriteLine("Para a soma");
            Console.WriteLine("Escreva o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            soma = (x + y);
            Console.WriteLine("O resultado da soma é: ");
            Console.WriteLine(soma);
            Console.WriteLine(" ");

            // Subtração 
            Console.WriteLine("Para a subtração");
            Console.WriteLine("Escreva o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            subtracao = (x - y);
            Console.WriteLine("O resultado da subtracao é: ");
            Console.WriteLine(subtracao);
            Console.WriteLine(" ");

            // Multiplicação 
            Console.WriteLine("Para a multiplicação");
            Console.WriteLine("Escreva o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            multiplicacao = (x * y);
            Console.WriteLine("O resultado da multiplicação é: ");
            Console.WriteLine(multiplicacao);
            Console.WriteLine(" ");

            // Divisão 
            Console.WriteLine("Para a divisão");
            Console.WriteLine("Escreva o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            divisao = (x / y);
            Console.WriteLine("O resultado da divisão é: ");
            Console.WriteLine(divisao);
            Console.WriteLine(" ");


            /* int n1 = (3 + 2) * 2;
            int n2 = 17 % 3;
            double n3 = 10.0 / 8;

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow (b, 2.0) -4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            Console.WriteLine(" ");

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            */
        }
    }
}