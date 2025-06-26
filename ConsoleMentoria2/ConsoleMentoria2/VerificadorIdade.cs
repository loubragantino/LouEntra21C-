namespace ConsoleMentoria2
{
    public static class VerificadorIdade
    {
        public static void Executar()
        {
            Console.WriteLine("=== Verificador de Idade ===");
            Console.WriteLine("Digite sua idade: ");

            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                string resultado = VerificarIdade(idade);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Idade inválida! Por favor, insira um número inteiro.");
            }
        }

        private static string VerificarIdade(int idade)
        {
            if (idade < 0 || idade > 120)
                return "Idade inválida! A idade deve estar entre 0 e 120 anos.";
            else if (idade < 18)
                return "Você é menor de idade.";
            else if (idade < 65)
                return "Você é adulto.";
            else
                return "Você é idoso.";
        }
    }
}