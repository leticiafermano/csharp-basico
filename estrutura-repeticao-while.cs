namespace LogicaDeProgramacao_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Estrutura de repetição:
            REPITA/ ENQUANTO (WHILE)
             */

            int cont = 0;
            while (cont < 20)  //Quantidade de repetição
            {
                Console.WriteLine("Julia");
                cont++; //Deverá ser colocado para que haja prosseguimento e adicione um valor ao 0, pra não roda infinitamente, assim como funciona o i++.
            }
        }
    }

    // DO WHILE -> Repita ate
    int cont = 10; //Executa
            do
            {
                Console.WriteLine("Ravi");
                cont++;
            }

            while (cont < 5); //Verifica
            Console.WriteLine(cont);
}