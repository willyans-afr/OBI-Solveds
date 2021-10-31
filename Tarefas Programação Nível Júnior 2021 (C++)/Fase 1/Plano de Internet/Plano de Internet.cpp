#include <iostream>

using namespace std;

int main()
{
    int X; //quota
    int N; //número de meses
    int M_i; //quantidade usada no mês atual
    int quota_anterior; //quota do mês anterior
    
    quota_anterior = 0;
    
    cout<<"Insira a quota: ";
    cin >> X;
    
    cout<<"Insira o número de meses: ";
    cin >> N;
    
    for (int count = 1; count <= N; count++){
        
        if(quota_anterior == 0){
            quota_anterior = X;
        }
        
        cout<<"Insira a quota usada do mês "<<count<<": ";
        cin >> M_i;
        
        //Verificador de quota mês a mês
        //quota_anterior = quota_anterior - M_i;
        //cout<<"cota mes "<<count<<" é "<<quota_anterior<< endl;
    }
    
    if (quota_anterior != 0){
        X = (X+quota_anterior)+X;
    }
    
    cout<<"Cota do próximo mês é "<<X<<".";

    return 0;
}
