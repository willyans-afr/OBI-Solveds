using System;
					
public class Program
{
	public static void Main()
	{
		int jogadorUm = int.Parse(Console.ReadLine());
		int jogadorDois = int.Parse(Console.ReadLine());
		int jogadorTres = int.Parse(Console.ReadLine());
		int jogadorQuatro = int.Parse(Console.ReadLine());
		
		if (jogadorUm <= jogadorDois && jogadorDois <= jogadorTres && jogadorTres <= jogadorQuatro) {
			int duplaUm = jogadorUm + jogadorQuatro;
			int duplaDois = jogadorDois + jogadorTres;
			int diferenca = duplaUm - duplaDois;
			
			Console.WriteLine();
			Console.WriteLine(diferenca);
		} 
	}
}