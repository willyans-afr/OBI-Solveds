#include <iostream>

using namespace std;

int main ()
{
  //Definindo as variáveis.
  int idade1, idade2, idade3;

  //Inserindo as variáveis.
  cin >> idade1 >> idade2 >> idade3;

  //Verificando se a Idade 1 é menor que idade 3 e maior que idade 2 ou...
  //se idade 1 é menor que idade 2 e maior que idade 3.
  if ((idade2 <= idade1 && idade1 <= idade3) || (idade3 <= idade1 && idade1 <= idade2))
    {
  //Imprimindo idade 1 caso se verdade.
      cout << idade1;
    }
  //Verificando se a Idade 2 é menor que idade 3 e maior que idade 1 ou...
  //se idade 2 é menor que idade 1 e maior que idade 3.
  else if ((idade1 <= idade2 && idade2 <= idade3) || (idade3 <= idade2 && idade2 <= idade1))
    {
  //Imprimindo idade 2 caso se verdade.
      cout << idade2;
    } else {
  //Caso não seja idade 1 ou 2 que seja a do meio, então teremos a certeza que é a idade 3.
      cout << idade3;
    }

  return 0;
}
