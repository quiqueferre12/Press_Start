//5letras.js
//Enrique Ferre Carbonell

function filtrar(lista,f){//definimos la funcion y la llamamos
    var cincoletras= 0 //creamos una variable para determinar el num. de palabras
    for(i=0;i<lista.length;i++){///recorrer el array
        if(f(lista[i])){
            cincoletras++
        }
    }
    return cincoletras;
}
//main
var palabras = ["Es", "ahora", "tu", "oportunidad", "para", "aprovechar", "este", "día"]
//el array con las palabras sin filtrar
var filtrarPa = filtrar(palabras, function(palabras){// callback
    if(palabras.length>=5){//el if para filtrar nuestro nuevo array
        return true;
    }else{
        return false;
    }
})
console.log(filtrarPa)//comprobamos
