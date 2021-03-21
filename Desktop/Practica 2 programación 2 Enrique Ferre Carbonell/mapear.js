//Ejercicio 2 Practica 2 mapear.js
//Enrique Ferre Carbonell
//Diseño de la funcion
//Lista <T1>
//T1->T2 --> [mapear()]-->Lista<T2>

function mapear(lista,f){     
    var listamapeado =[]//lista para almacenar el resultadocde los numeros
    for (var i=0;i<=lista.length-1;i++){//creamos un for para recorrer tododa la lista
      listamapeado.push(f(lista[i]))
    }
    return listamapeado 
}//function mapear()

//main
var lista=["casa","sal", "pinar", "si"]//definimos la lista
var mapa = mapear(lista,function(palabra){//la funcion mapear
    return palabra.length
})

//prueba automatica para comprobar el funcionamiento
console.log(mapa)
    if(mapa[0]==4 && mapa[1]==3 && mapa[2]==5 && mapa[3]==2){
        console.log("Va bien")
    }

