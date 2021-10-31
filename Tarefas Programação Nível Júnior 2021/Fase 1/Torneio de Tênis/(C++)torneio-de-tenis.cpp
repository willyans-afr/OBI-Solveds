#include <iostream>

using namespace std;

int main()
{
    char participante;
    int vencedor = 0;
    
    for (int count = 0; count < 6; count++) {
        cout<<"Resultado do jogo: ";
        cin >> participante;
        
        if(participante == 'V' || participante == 'v'){ vencedor = vencedor + 1; }
    }
    
    switch (vencedor) {
        case 1:
            cout << 3;
            break;
        case 2:
            cout << 3;
            break;    
        case 3:
            cout << 2;
            break;
        case 4:
            cout << 2;
            break;
        case 5:
            cout << 1;
            break;
        case 6:
            cout << 1;
            break;
        default:
            cout << -1;
    }

    return 0;
}
