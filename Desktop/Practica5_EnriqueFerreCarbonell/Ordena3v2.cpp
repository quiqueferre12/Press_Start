#include <iostream>
using namespace std;
//lista<R>--> ordenanum()

void ordennum (int *lista, int cuantos){//recibe una lista y su tamanyo

    int i=0;
    
    int cambio;//declaramos una variable auxuliar para almacenar el cambio de posiciones dado el caso
        for( i;i<cuantos;i++){//para recorrer la lista al completo
            for(int j=i;j<cuantos-1;j++){ //para ir posicion por posicion ordenando todo
        
                if(lista[i]>lista[i+1]){//dado el caso en que se cumpla esta condición
                    cambio=lista[i];
                    lista[i]=lista[j];
                    lista[j]=cambio;

                }
            }
        }
}   //ordenanum()


int main(){

int lista[]={2,1,3};//creamos una lista
ordennum (& lista[0],3);//llamamos a la funcion

for (int i = 0; i < 3; i++)//imprimimos el resultado utilizando un bucle
{
    cout<< lista[i]<< endl;
}

}//main()