//Enrique Ferre Carbonell
//05-11-2020
//Función contiene: partiendo de introducir una lista, se crea la función contiene para averiguar si un numero en específico está contenido en esa lista
//Diseño de la función : [N]-->(Contiene)-->True/False

#include<iostream>
using namespace std;


bool contiene(int*listanumeros, int cuantos, int num){//Implementamos la función contiene y le pasamos un array, su tamaño y el numero para saber si está contenido
	for(int i=0;i<cuantos;i++){//recorremos el array
		if(num = listanumeros[i]){//comprobamos si el numero está contenido en el array
			return true;
		}
	}
	return false;
}


//función principal
int main(){
	bool resultado;//creamos la variable para llamar a la función
	int numero = 6;//el numero para saber si está dentro de la lista
	int listanumeros[] ={2,4,3,5,6};//el array que le pasaremos
	 resultado = contiene(&listanumeros[0],5,numero);//llamamos a la función
	if(resultado==true){//la impresión del resultado por pantalla
		cout<<"El numero "<<numero<<" esta contenido en la lista."<<endl;
	}else{
		cout<<"El numero "<<numero<<" no esta contenido en la lista."<<endl;	
	}
	
}
