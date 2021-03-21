//Enrique Ferre Carbonell
//Practica 7 Main pruebas.cpp
#include <iostream>
#include "Polinomio.h"
#include <string.h>
#include <math.h>
#include <vector>
using namespace std;

void probarGrado(){
    int resultado=0;
    Polinomio p1 ({1,2,3});
    resultado = p1.grado();
    cout<<"El grado del polinomio es: "<<resultado<<endl;
    if(resultado!=2){
        cout<<"resultado va mal"<<endl;
    } else{
        cout<<"resultado va bien"<<endl;
    }
}

void probarCoeficiente(){
   double resultado=0;
   Polinomio p1({1,24.2,3,9});
   resultado = p1.coeficiente(1);
    cout<<"El coeficiente del polinomio es: "<<resultado<<endl;
    if(resultado!=24.2){
        cout<<"coeficiente va mal"<<endl;
    } else{
        cout<<"coeficiente va bien"<<endl;
    }

}
void probarValor(){
    double resultado;
    Polinomio p1({1,2,3});
    resultado = p1.valor(2);
    cout<<"El valor del polinomio es: "<<resultado<<endl;
    if(resultado!=17){
        cout<<"valor va mal"<<endl;
    } else{
        cout<<"valor va bien"<<endl;
    }

}

void probarMultiplicar(){
   Polinomio resultado; 
   Polinomio p1({1,2,3});
   resultado= p1.multiplicar(2);
   string comprov = resultado.aTexto();
    cout<<"El polinomio es: "<<comprov<<endl;

  
   
}
void probarSumar(){
    Polinomio p1({1,2,3});
    Polinomio p2({1,2});
    Polinomio p3=p1.sumar(p2);
    string comprov = p3.aTexto();
    cout<<"El polinomio es: "<<comprov<<endl;

}

int main(){
    probarGrado();
    probarCoeficiente();
    probarValor();
    probarMultiplicar();
    probarSumar();
   
}

