//Enrique Ferre Carbonell
//05-11-2020
//Funci�n contiene: partiendo de introducir una lista, se crea la funci�n contiene para averiguar si un numero en espec�fico est� contenido en esa lista
//Dise�o de la funci�n : [N]-->(Contiene)-->True/False

#include<iostream>
using namespace std;


bool contiene(int*listanumeros, int cuantos, int num){//Implementamos la funci�n contiene y le pasamos un array, su tama�o y el numero para saber si est� contenido
	for(int i=0;i<cuantos;i++){//recorremos el array
		if(num = listanumeros[i]){//comprobamos si el numero est� contenido en el array
			return true;
		}
	}
	return false;
}


//funci�n principal
int main(){
	bool resultado;//creamos la variable para llamar a la funci�n
	int numero = 6;//el numero para saber si est� dentro de la lista
	int listanumeros[] ={2,4,3,5,6};//el array que le pasaremos
	 resultado = contiene(&listanumeros[0],5,numero);//llamamos a la funci�n
	if(resultado==true){//la impresi�n del resultado por pantalla
		cout<<"El numero "<<numero<<" esta contenido en la lista."<<endl;
	}else{
		cout<<"El numero "<<numero<<" no esta contenido en la lista."<<endl;	
	}
	
}
