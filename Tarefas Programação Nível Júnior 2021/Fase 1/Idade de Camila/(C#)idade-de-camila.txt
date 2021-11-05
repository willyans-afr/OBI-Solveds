using System;
					
public class Program
{
	public static void Main()
	{
		
		int camila;
		
		// Leitura das idades inseridas
		int idade1 = int.Parse(Console.ReadLine());
		int idade2 = int.Parse(Console.ReadLine());
		int idade3 = int.Parse(Console.ReadLine());
		
		/* A linha a seguir trata que a maior, media e menor idade,
		respectivamente, seja: idade1; idade3; idade2. Onde a idade3
		é a Camila. */
		if (idade1 > idade2 && idade2 < idade3) {
			camila = idade3;
			Console.WriteLine();
			Console.WriteLine(camila);
		/* A linha a seguir trata que a maior, media e menor idade,
		respectivamente, seja: idade2; idade3; idade1. Onde a idade3
		é a Camila. */
		} else if (idade1 < idade2 && idade2 > idade3) {
			camila = idade3;
			Console.WriteLine();
			Console.WriteLine(camila);
		} else {
			camila = idade2;
			Console.WriteLine();
			Console.WriteLine(camila);
		}
	}
}
