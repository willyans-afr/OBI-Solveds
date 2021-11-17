using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		// declara��o do iterador e do boolean
		int i = 0;
		bool asterisco = false;
		
		/* leitura da quantidade de 
		Estados que v�o ser comparados */
		int qtd = int.Parse(Console.ReadLine());		
		Console.WriteLine();
		
		/* enquanto o iterador � menor que 
		a qtd de estados, essa linha vai rodar*/
		while (i < qtd) {
			i++;
			Console.WriteLine();
			
			/* leitura da sigla do Estado,
			pre�o do �lcool e gasolina,
			respectivamente */
			string[] info = Console.ReadLine().Split(' ');
			string estado = info[0];
			double alcool = double.Parse(info[1], CultureInfo.InvariantCulture);
			double gasolina = double.Parse(info[2], CultureInfo.InvariantCulture);
			Console.WriteLine();
			
			/* se o pre�o do �lcool � menor
			ou igual a 70% do pre�o da
			gasolina, mostrar a sigla do
			Estado na tela e alterar o boolean
			para verdadeiro */
			if (alcool <= gasolina * 0.7) {
				Console.WriteLine(estado);
				asterisco = true;
			}
		}
		
		/* s� vai mostrar o asterisco se
		nenhum Estado tiver o pre�o do
		�lcool menor que o da gasolina */
		if (!asterisco) {
			Console.WriteLine("*");
		}
	}
}