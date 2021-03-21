//Enrique Ferre Carbonell
//Practica 7 Polinomio.h
#include <iostream>
#include <string.h>
#include <vector>
#include <math.h>
using namespace std;
#ifndef POLINOMIO_YA_INCLUIDO
#define POLINOMIO_YA_INCLUIDO

class Polinomio{
    
    private:
    vector<double> coeficientes;
    //declaramos el vector

    public:
    Polinomio();
    Polinomio(vector<double> coeficientes);
    int grado();
    double coeficiente( int numero);
    double valor(double numero);
    Polinomio sumar(Polinomio otro);
    Polinomio multiplicar(double numero);
    string aTexto();
};
#endif


