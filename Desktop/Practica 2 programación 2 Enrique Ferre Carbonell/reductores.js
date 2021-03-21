//Ejercicio 3 Practica 2 reducir.js
//Enrique Ferre Carbonell
//Diseño de la funcion
//Lista<T1>,T2,T2 T1--> [reducir()]--> T2  
//

function reducir(lista,f){   //ponemos la funcion reducir con sus valores
    var resultado =0//creamos una variable para almacenar el resultado
    for(var i =0;i<=lista.length-1; i++){
        resultado = f(resultado,lista[i])
    }
    return resultado
    }//function reducir()
    

    //main
    var lista =[1, 2, 3, 4, 5]//la lista del array
    var reducira = reducir(lista,function(a,b) {//la funcion reducir
        return a+b;
    })
    if(reducira==15){
        console.log("esta bien, el resultado es: ")
    } else{
        console.log("esta mal")
    }
    console.log(reducira)