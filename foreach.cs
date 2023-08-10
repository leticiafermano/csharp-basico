namespace LogicaDeProgramacao_FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "Luiza", "Cornelio", "Luna" };
            foreach (string nome in nomes)
                Console.WriteLine(nome);
        }
    }
}