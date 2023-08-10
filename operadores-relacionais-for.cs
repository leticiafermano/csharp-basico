namespace LogicaDeProgramacao_P4_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Estrutura de repetição:
            PARA (FOR)
            Para uso de muitos dados sem a necessidade de usar varias linhas para isso
            Recomendado para quando se sabe a quantidade de repetições.
            */

            /* 
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);
            */

            for (int i = 1; i <= 10; i++)
                // i = inicio; i<= repetição; i++ = necessário para que o loop tenha um ponto de parada.
                Console.WriteLine(i);
            
        }
    }
}