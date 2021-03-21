//Enrique Ferre Carbonell
//Practica 7 Polinomio.cpp
#include <iostream>
#include <string.h>
#include <math.h>
#include "Polinomio.h"
#include <vector>
using namespace std;

Polinomio::Polinomio(){}

Polinomio::Polinomio(vector<double> cof){//definimos el constructor
 coeficientes=cof;//asociamos la variable cof a los coeficientes
}


int Polinomio::grado(){//metodo para obtener el grado máximo del polinomio
    return coeficientes.size()-1;
}

double Polinomio::coeficiente(int numero){//metodo usado para buscar el numero del coeficiente: ej 2x^2 pues se introduciria el 3
  
    if(grado()>=numero){
        return coeficientes[numero];
    }else{
        return 0;//si ponemos un numero mayor al grado del polinomio devolverá 0
    }
}

double Polinomio::valor(double numero){//metodo usado al introducir un numero, este sustituya a todas las x del polinomio generando un numero
    double resultado=0;
    for(int i=0;i<=grado();i++){
       resultado = resultado + (coeficiente(i)*pow(numero,i));
    }
    return resultado;
}

Polinomio Polinomio::multiplicar(double numero){//multiplicar todo el polinomio por un numero
    Polinomio algo;
    double resultado=0;
   
    for(int i=0;i<=grado();i++){
       resultado =(*this).coeficiente(i)*numero;
       algo.coeficientes.push_back(resultado);
    }
    return algo;
} 

Polinomio Polinomio::sumar(Polinomio otro){//sumar 2 polinomios en un polinomio nuevo
    int tamanyo=0;
    Polinomio algo;
    if((*this).grado()>otro.grado()){//comprobamos el tamanyo
        tamanyo=(*this).grado();
    }else{
        tamanyo=otro.grado();
    }
    for( int i=0;i<=tamanyo;i++){//anyadimos los coeficientes del polinomio de ambos polinomios
        if(i<=(*this).grado()){
            algo.coeficientes.push_back(coeficiente(i));
        }//anyadimos todos los del primer polinomio
       if( i<= otro.grado()){//luego los del segundo polinomio
           if(i<= (*this).grado()){
               algo.coeficientes[i]=algo.coeficiente(i)+otro.coeficiente(i);
           }else{//si este es mayor en tamanyo al otro polinomio, se añadirian los restantes
               algo.coeficientes.push_back(otro.coeficiente(i));
           }
        }
    }
     return algo;  //devolvemos el polinomio
    
}
string Polinomio::aTexto(){//metodo para pasar el polinomio a un string
   string resultadoT;
    for(int i = grado();i>=0;i--){
        if(i !=0){
        resultadoT= resultadoT + to_string(coeficiente(i))+"x"+ to_string(i) + "+";
        }else{
            resultadoT= resultadoT + to_string(coeficiente(i));
        }
        
    }
    return resultadoT;
}








