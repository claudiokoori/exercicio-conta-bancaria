namespace ExercicioContaBank
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ContaBancaria conta;

			Console.Write("Entre com o número da conta: ");
			int numeroConta = int.Parse(Console.ReadLine());
			Console.Write("Entre com o titular da conta: ");
			string titular = Console.ReadLine();
			Console.Write("Haverá depósito inicial (s/n)? ");
			char resposta = char.Parse(Console.ReadLine());

			if (resposta == 'n' || resposta == 'N')
			{
				conta = new ContaBancaria(numeroConta, titular);
			}
			else
			{
				Console.Write("Entre com o valor de depósito inicial: ");
				double valorDeposito = double.Parse(Console.ReadLine());
				conta = new ContaBancaria(numeroConta, titular, valorDeposito);
			}

			Console.WriteLine($"Dados da conta: {conta}");

			Console.WriteLine();
			Console.Write("Entre com um valor para depósito: ");
			double deposito = double.Parse(Console.ReadLine());
			conta.Deposito(deposito);
			Console.WriteLine($"Dados da conta atualizados: {conta}");

			Console.WriteLine();
			Console.Write("Entre um valor para saque:");
			double saque = double.Parse(Console.ReadLine());
			conta.Saque(saque);
			Console.WriteLine($"Dados da conta atualizados: {conta}");

		}
	}
}