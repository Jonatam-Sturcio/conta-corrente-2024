namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            Conta conta2 = new Conta();
            Cliente titular1 = new Cliente();
            Cliente titular2 = new Cliente();

            titular1.nome = "Jonas";
            titular1.sobrenome = "Correa";
            titular1.cpf = "111.111.111-11";

            titular2.nome = "Eduardo";
            titular2.sobrenome = "Tortelli";
            titular2.cpf = "222.222.222-22";

            conta1.CriarConta(1, 1000, false, titular1);
            conta2.CriarConta(2, 1000, false, titular2);

            conta1.VisualisarSaldo();
            conta1.Depositar(1000, false);
            conta1.Sacar(500, false);
            Console.WriteLine("Histórico");
            conta1.VisualizarExtrato();

            Console.WriteLine("------------------");

            conta2.VisualisarSaldo();
            conta2.Depositar(2000, false);
            conta2.Sacar(500, false);
            Console.WriteLine("Histórico");
            conta2.VisualizarExtrato();

            conta1.Transferir(100, conta2);

            Console.WriteLine("------------------");
            Console.WriteLine("Histórico");
            conta1.VisualizarExtrato();
            Console.WriteLine("------------------");
            Console.WriteLine("Histórico");
            conta2.VisualizarExtrato();

        }
    }
}
