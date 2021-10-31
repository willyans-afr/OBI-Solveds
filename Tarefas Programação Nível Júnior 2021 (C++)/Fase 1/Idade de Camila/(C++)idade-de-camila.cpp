#include <iostream>

using namespace std;

int
main ()
{
  int idade1;
  int idade2;
  int idade3;

  cout << "Coloque a primeira idade: ";
  cin >> idade1;

  cout << "Coloque a segunda idade: ";
  cin >> idade2;

  cout << "Coloque a terceira idade: ";
  cin >> idade3;

  //idade 1
  if ((idade2 <= idade1 && idade1 <= idade3)
      || (idade3 <= idade1 && idade1 <= idade2))
    {
      cout << idade1;
    }
  //idade 2
  else if ((idade1 <= idade2 && idade2 <= idade3)
	   || (idade3 <= idade2 && idade2 <= idade1))
    {
      cout << idade2;
    }
  //idade 3 caso nC#o sejam as outras idades
  else
    {
      cout << idade3;
    }

  return 0;
}
