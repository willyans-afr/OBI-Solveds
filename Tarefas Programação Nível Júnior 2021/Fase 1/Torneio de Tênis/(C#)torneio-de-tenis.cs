using System;
					
public class Program
{
	public static void Main()
	{
		// contador de vitórias
		int contV = 0;
		// contador de derrotas
		int contP = 0;
		
		for (int i = 0; i < 6; i++) {
			// leitura do resultado da partida
			char partidas = char.Parse(Console.ReadLine());
			
			// se a pessoa ganhar, o contador de vitória sobe
			if (partidas == 'v') {
				contV++;
			// se a pessoa perder, o contador de derrota desce
			} else {
				contP++;
			}
		}
		
		// se a pessoa ganhou entre 5 a 6 jogos, faz parte do grupo 1
		Console.WriteLine();
		if (contV > 4 && contV < 7) {
			Console.WriteLine("1");
		// se a pessoa ganhou entre 3 a 4 jogos, faz parte do grupo 2
		} else if (contV > 2 && contV < 5) {
			Console.WriteLine("2");
		// se a pessoa ganhou entre 1 a 2 jogos, faz parte do grupo 3
		} else if (contV > 0 && contV < 3) {
			Console.WriteLine("3");
		// se a pessoa perdeu todos os jogos, faz parte do grupo -1
		} else {
			Console.WriteLine("-1");
		}
	}
}