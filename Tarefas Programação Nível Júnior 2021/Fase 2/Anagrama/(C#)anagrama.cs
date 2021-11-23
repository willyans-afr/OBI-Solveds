using System;
					
public class Program
{
	public static void Main()
	{
		/* declaração da variável que
		mostra o resultado positivo e
		da que faz a leitura do texto */
		bool diferenca = false;
		string texto, positivo = "";
		
		// leitura da quantidade de letras do anagrama
		int num = int.Parse(Console.ReadLine());
		
		Console.WriteLine();
		
		/* laço de repetição que lê a 
		palavra escrita pelo usuário */
		for (int i = 0; i < 2; i++) {
			texto = Console.ReadLine();
			
			/* caso o texto tenha mais que
			2 caracteres e não seja nulo, a
			variável positivo recebe a letra S
			e a diferença passa a ser true */
			if (texto.Length > 2 && texto != null) {
				positivo = "S";
				diferenca = true;
			}
		}
		
		Console.WriteLine();
		
		/* se a diferença é diferente de seu
		padrão, que é falso, vai mostrar a
		letra N, caso contrário, mostrar a
		variável positiv, que contém um S */
		if (!diferenca){
			Console.WriteLine("N");
		} else {
			Console.WriteLine(positivo);
		}
	}
}