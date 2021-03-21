#include <iostream>

using namespace std;

void Ordenanumero(int a,int b,int c){

    int cambio = 0;

    if(a>b){
        cambio=a;
        a=b;
        b=cambio;
    }

    if(a>c){
        cambio=a;
        a=c;
        c=cambio;
    }

    if(b>c){
        cambio=b;
        b =c;
        c=cambio;
    }

}


 int main(){

    int a= 1;
    int b= 2;
    int c= 3;

    Ordenanumero( a, b, c);
    cout<< a;
    cout<< b;
    cout<< c;
  


}
