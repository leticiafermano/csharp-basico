namespace LogicaDeProgramacao_P3_OperadoresRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ESTRUTURA DE DECISÃO:
            IF / ELSE
            Simples: Se, Então (IF)
            Composta: Se, Então, Se não (If, Else)

            SWITCH / CASE
            No caso se ter muitas opções para serem analisadas.
             */


            /* Forma não prática:

            string diaSemana = "Domingo";
            if (diaSemana == "Segunda")
            {
                Console.WriteLine("Hoje é Segunda-Feira"); 
            }            
            else if (diaSemana == "Terça")
            {
                Console.WriteLine("Hoje é Terça-Feira");
            }
            else if (diaSemana == "Quarta")
            {
                Console.WriteLine("Hoje é Quarta-Feira");
            }
            else if (diaSemana == "Quinta")
            {
                Console.WriteLine("Hoje é Quinta-Feira");
            }
            else if (diaSemana == "Sexta")
            {
                Console.WriteLine("Hoje é Sexta-Feira");
            }
            else if (diaSemana == "Sabado")
            {
                Console.WriteLine("Hoje é Sábado");
            }
            else /* Sempre termina em Else
            {
                Console.WriteLine("Hoje é Domingo");
            } */

            int diaSemana = 3;
            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Hoje é Segunda-Feira");
                    break; 
                case 2:
                    Console.WriteLine("Hoje é Terça-Feira");
                    break;
                case 3:
                    Console.WriteLine("Hoje é Quarta-Feira");
                    break;
                case 4:
                    Console.WriteLine("Hoje é Quinta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Hoje é Sexta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Hoje é Sábado");
                    break;
                case 7:
                    Console.WriteLine("Hojé é Domingo");
                    break;
            }

        }
    }
}