namespace ConsoleMentoria2
{
    public static class VerificadorCNH
    {
        public static void Executar()
        {
            Console.WriteLine("=== Verificador de CNH ===");
            Console.WriteLine("Você possui CNH? (Sim/Não)");
            string? resposta = Console.ReadLine()?.Trim().ToLower();

            string resultado = (resposta == "sim") ? "Você pode dirigir!" : "Você não pode dirigir.";

            Console.WriteLine(resultado);
        }
    }
}
