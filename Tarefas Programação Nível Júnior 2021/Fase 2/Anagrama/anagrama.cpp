#include <iostream>
#include <string>
using namespace std;

int main () {

    int N; //Número de letras e espaços.    
    string A , B, C;

    cin >> N;
    //Usar cin.ignore antes de qualquer getline.
    cin.ignore();
    //getline permite inserir strings com espaços no C++.
    getline(cin, A);
    getline(cin, B);
    
    for (int iterador1 = 0; iterador1 < N; iterador1++) {
        //cout << A[iterador1];
        for (int iterador2 = 0; iterador2 < N; iterador2++)
        {
            if(A[iterador1] == B[iterador2]){
                C += B[iterador2];                
                iterador2 = N;
            }
        }
    }

    if (A == C){
        cout << "S" << endl;
    } else {
        cout << "N" << endl;
    }
    

    return 0;
    }