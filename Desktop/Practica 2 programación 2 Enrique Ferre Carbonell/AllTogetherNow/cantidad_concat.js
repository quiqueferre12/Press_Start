//cantidad_concat.js
//Enrique Ferre Carbonell

function reducir(lista,f){//definimos la funcion y la llamamos
    var listaRes=[]
    for(var i=0;i<=lista.length-1;i++){
        if(f(lista[i])){
            listaRes.push(lista[i])
        }
    }
    return listaRes
}

//main
var lista =["Es" , "ahora","tu","oprtunidad","para","aprovechar","este","dia"]//la lista del array
var reducira = reducir(lista,function(palabra) {//la funcion reducir
    if(palabra.length<=3){
        return true;
    }
    
})
console.log(reducira)//prueba automatica