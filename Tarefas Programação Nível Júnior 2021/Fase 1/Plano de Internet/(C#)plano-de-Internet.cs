using System;
					
public class Program
{
	public static void Main()
	{
		// leitura da quota mensal de internet
		int quota = int.Parse(Console.ReadLine());
		Console.WriteLine();
		// leitura da quantidade de meses do plano
		int meses = int.Parse(Console.ReadLine());
		Console.WriteLine();
		// total que será utilizado nos meses seguintes
		int tot = 0;
		
		for (int i = 1; i <= meses; i++) {
			// leitura da quantidade de megabyte usada por mês
			int M_i = int.Parse(Console.ReadLine());
			Console.WriteLine();
			// calculo para saber quanto sobra de megabytes por mês
			tot = tot + quota - M_i;
		}
		
		// quota que será utilizada no mês seguinte
		Console.WriteLine(tot + quota);
	}
}