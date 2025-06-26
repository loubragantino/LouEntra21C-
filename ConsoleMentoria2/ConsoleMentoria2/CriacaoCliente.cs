using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMentoria2
{
    public class CriacaoCliente
    {
        public ObjetoCliente Objeto { get; set; }
        public CriacaoCliente(ObjetoCliente objeto) {
            Objeto = objeto;
        }

        public ObjetoCliente? CriarCliente()
        {
            if (Objeto == null)
            {
                Console.WriteLine("Objeto cliente não pode ser nulo.");
                return null;
            }
            if (string.IsNullOrWhiteSpace(Objeto.NomeCompleto) || Objeto.Idade <= 0 || string.IsNullOrWhiteSpace(Objeto.Email))
            {
                Console.WriteLine("Dados do cliente inválidos. Verifique o nome, idade e email.");
                return null;
            }
            Console.WriteLine($"Cliente cadastrado: {Objeto.NomeCompleto}, Idade: {Objeto.Idade}, Email: {Objeto.Email}");
            Objeto.ID = new Random().Next(1, 1000); // Simula a atribuição de um ID único
            return Objeto;
        }
    }
}
