namespace ConsoleMentoria2
{
    public static class VerificadorEstacao
    {
        public static void Executar()
        {
            Console.WriteLine("=== Verificador de Estação do Ano===");
            Console.WriteLine("Digite o número do mês de 1 a 12: ");

            if (int.TryParse(Console.ReadLine(), out int mes))
            {
                string estacao = VerificarEstacao(mes);
                string mesDoAno = VerificarMes(mes);
                Console.WriteLine($"{mesDoAno}, a estação correspondente é: {estacao}");
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, digite um número entre 1 e 12");
            }
        }

        private static string VerificarEstacao(int mes)
        {
            if (mes == 12 || mes == 1 || mes == 2)
            {
                return "Verão";
            }
            else if (mes >= 3 && mes <= 5)
            {
                return "Outono";
            }
            else if (mes >= 6 && mes <= 8)
            {
                return "Inverno";
            }
            else if (mes >= 9 && mes <= 11)
            {
                return "Primavera";
            }
            else
            {
                return "Mês inválido! Por favor, digite um número entre 1 e 12.";
            }
        }

        private static string VerificarMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Estamos em Janeiro";
                case 2:
                    return "Estamos em Fevereiro";
                case 3:
                    return "Estamos em Março";
                case 4:
                    return "Estamos em Abril";
                case 5:
                    return "Estamos em Maio";
                case 6:
                    return "Estamos em Junho";
                case 7:
                    return "Estamos em Julho";
                case 8:
                    return "Estamos em Agosto";
                case 9:
                    return "Estamos em Setembro";
                case 10:
                    return "Estamos em Outubro";
                case 11:
                    return "Estamos em Novembro";
                case 12:
                    return "Estamos em Dezembro";
                default:
                    return "Mês inválido!";
            }
        }
    }
}
