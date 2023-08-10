using System;
using System.Globalization;

namespace ExercicioAula24_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            int quarto = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' '); //Como sera colocado tudo na mesma linha se usa o vetor e para separar as palavras se usa o split
            string name = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu nome completo: ");
            Console.WriteLine(nome);

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            Console.WriteLine(quarto);

            Console.WriteLine("Digite o valor de um produto: ");
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(name);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}