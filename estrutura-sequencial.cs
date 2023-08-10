using System;
using System.Globalization;

namespace Exercicios_01___Estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXERCICIO 01
            int x;
            int y;
            double soma;

            Console.WriteLine("Para soma: ");
            Console.WriteLine("Escreva o valor de x: ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor para y: ");
            y = int.Parse(Console.ReadLine());

            soma = (x + y);
            Console.WriteLine("O resultado da soma é: ");
            Console.WriteLine(soma);
            */

            /* EXERCICIO 02
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double p = 3.14159;
            double area = (p * (raio * raio));

            Console.WriteLine("Para o valor do raio: ");
            Console.WriteLine(raio);
            Console.WriteLine("Temos uma área do circulo de: ");
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
            */

            /* EXERCICIO 03
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            double C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            double diferenca = ((A * B) - (C * D));

            Console.WriteLine("A diferença dos valores é: ");
            Console.WriteLine(diferenca);
            */

            /* EXERCICIO 04 
            int funcionario = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorporhora = double.Parse(Console.ReadLine());
            double salario = (horas * valorporhora);

            Console.WriteLine(" ");
            Console.WriteLine("O numero do funcionario é: ");
            Console.WriteLine(funcionario);
            Console.WriteLine("Seu salario totaliza um valor de: ");
            Console.WriteLine(salario.ToString("F2"));
            */

            /* EXERCICIO 05 
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;
            
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = ((preco1 * qte1) + (preco2 * qte2));

            Console.WriteLine("Valor a pagar: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
            */

            /* EXERCICIO 06 */
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Escreva o valor de A, B e C:");

            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2.0;
            circulo = 3.1459 * (c * c);
            trapezio = (((a + b) * c) / 2);
            quadrado = (b * b);
            retangulo = (a * b);

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}