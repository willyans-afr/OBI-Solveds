using System;
					
public class Program
{
	public static void Main()
	{
		// leitura do nível dos jogadores 1, 2, 3 e 4, respectivamente
		int jogadorUm = int.Parse(Console.ReadLine());
		int jogadorDois = int.Parse(Console.ReadLine());
		int jogadorTres = int.Parse(Console.ReadLine());
		int jogadorQuatro = int.Parse(Console.ReadLine());
		
		/* comparação entre o nível dos jogadores sendo o primeiro com o menor nível
		e o quarto jogador com o maior nível entre os jogadores */
		if (jogadorUm <= jogadorDois && jogadorDois <= jogadorTres && jogadorTres <= jogadorQuatro) {
			// primeira dupla formada com o jogador 1 e 4
			int duplaUm = jogadorUm + jogadorQuatro;
			// segunda dupla formada com o jogador 2 e 3
			int duplaDois = jogadorDois + jogadorTres;
			// diferença entre a soma do nível dos jogadores
			int diferenca = duplaUm - duplaDois;
			
			Console.WriteLine();
			Console.WriteLine(diferenca);
		} 
	}
}
