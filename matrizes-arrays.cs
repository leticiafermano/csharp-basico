namespace LogicaDeProgramacao_P7_Matrizes_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Matrizes
            É uma estrutura encadeada de vetores
            um vetor permite a criação de uma lista de variaveis do msm tipo
            e uma matriz é uma lista de vetores do mesmo tipo
            0,0 0,1
            1,0 1,1
             */

            string[,] nome = new string[3, 3];
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    nome[linha, coluna] = Console.ReadLine();
                }
            }
            Console.WriteLine(" ");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(nome[linha, coluna] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}