using System;
					
public class Program
{
	public static void Main()
	{
		
		// declaração das variáveis
		int r = int.Parse(Console.ReadLine());
		int m = int.Parse(Console.ReadLine());
		int l = int.Parse(Console.ReadLine());
		
		Console.WriteLine();
		
		/* caso o resultado do atleta seja
		maior que a prova mundial e a olímpica */
		if (r >= m && r >= l) {
			Console.WriteLine("*");
			Console.WriteLine("*");
		/* caso o resultado do atleta seja maior que
		a prova mundial e menor que a olímpica */
		} else if (r >= m && r < l) {
			Console.WriteLine("*");
			Console.WriteLine("RO");
		/* caso o resultado do atleta seja menor que
		a prova mundial e maior que a olímpica */
		} else if (r < m && r >= l) {
			Console.WriteLine("RM");
			Console.WriteLine("*");
		/* caso o resultado do atleta seja menor
		que a prova mundial e que a olímpica */
		} else if (r < m && r < l) {
			Console.WriteLine("RM");
			Console.WriteLine("RO");
		}
	}
}