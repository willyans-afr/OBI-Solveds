#include <iostream>

using namespace std;

int main()
{
    int X, N, M_i, quota_anterior;

    //X é quota, N é número de meses, M_i é quantidade usada no mês atual...
    // e quota_anterior guardamos o valor do mês anterior.
    
    //A quota do mês anterior ainda é inexistente pois não começamos a...
    //contar ainda, como em toda conta de internet.
    quota_anterior = 0;

    //Inserindo a quota e o número de meses.
    cin >> X >> N;
    
    for (int count = 1; count <= N; count++){
        //Inserindo a quota usada no mês atual.
        cin >> M_i;

        if(quota_anterior == 0){
            quota_anterior = X;
            X = quota_anterior + (X - M_i);
        } else {
            X = quota_anterior + (X - M_i);
        }        
    }
      
    cout<<X;

    return 0;
}
