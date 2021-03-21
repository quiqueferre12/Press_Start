//total.js
//Enrique Ferre Carbonell

function reducir(lista,f){
    var resultado
    for(var i=0;i<lista.length;i++){
        resultado = f(resultado,lista[i])
    }
    return resultado
}


var lista =["Es","ahora","tu","oprtunidad","para","aprovechar","este","dia"]//la lista del array
var reducira = reducir(lista,function(a,b) {//la funcion reducir
    
    return a+b;
})
console.log("la longitud total es de: "+reducira.length)