//reves.js
//Enrique Ferre Carbonell

function mapear(lista,f){     
    var listamapeado =[]//lista para almacenar el resultadocde los numeros
    for (var i=0;i<=lista.length-1;i++){//creamos un for para recorrer tododa la lista
      listamapeado.push(f(lista[i]))
    }
    return listamapeado 
}//function mapear()

function reves(){//definimos la funcion 
    var res = mapear(palabras, function(palabras){//llamamos a mapear
        var resu = [];
        for(var i = palabras.length-1; i >= 0; i--){
            resu = resu + palabras.charAt(i)
        }
        return resu
    })
    return res
}

//main
var palabras =["Es" , "ahora","tu","oprtunidad","para","aprovechar","este","dia"]//definimos el array
var res = reves(palabras)
console.log(res)