using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		// declaração do iterador e do boolean
		int i = 0;
		bool asterisco = false;
		
		/* leitura da quantidade de 
		Estados que vão ser comparados */
		int qtd = int.Parse(Console.ReadLine());		
		Console.WriteLine();
		
		/* enquanto o iterador é menor que 
		a qtd de estados, essa linha vai rodar*/
		while (i < qtd) {
			i++;
			Console.WriteLine();
			
			/* leitura da sigla do Estado,
			preço do álcool e gasolina,
			respectivamente */
			string[] info = Console.ReadLine().Split(' ');
			string estado = info[0];
			double alcool = double.Parse(info[1], CultureInfo.InvariantCulture);
			double gasolina = double.Parse(info[2], CultureInfo.InvariantCulture);
			Console.WriteLine();
			
			/* se o preço do álcool é menor
			ou igual a 70% do preço da
			gasolina, mostrar a sigla do
			Estado na tela e alterar o boolean
			para verdadeiro */
			if (alcool <= gasolina * 0.7) {
				Console.WriteLine(estado);
				asterisco = true;
			}
		}
		
		/* só vai mostrar o asterisco se
		nenhum Estado tiver o preço do
		álcool menor que o da gasolina */
		if (!asterisco) {
			Console.WriteLine("*");
		}
	}
}