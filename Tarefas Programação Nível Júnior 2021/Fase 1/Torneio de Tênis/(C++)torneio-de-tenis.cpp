#include <iostream>

using namespace std;

int main() {

    //Declarando as variaveis, participantes irá receber V ou P;
    char participante;

    //Vencedor é declarado inicialmente como zero para facilitar na futura iteração (Olhar linha 22);
    int vencedor = 0;
    
    //Laço para ir adicionando V ou P nos participantes de acordo com...
    //a constante 6 proposta no exercício. O maior número de partidas jogadas é 6.
    for (int count = 0; count < 6; count++) {
    //Adiciono o resultado de um participante para cada retorno no laço.
        cin >> participante;

    //Verifico se foi digitado a letra V em caixa alta ou minúscula e itero a variável vencedor...
    //para o resultado de saída.
        if(participante == 'V' || participante == 'v'){ 
            vencedor = vencedor + 1; 
            }
    }
    
    //Switch para verificar e imprimir qual grupo o participante será colocado.
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
