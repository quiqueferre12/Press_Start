//Ejercicio 3 MainPorTresAsincrono.js 
//Enrique Ferre Carbonell
//R-->porTres3()-->R
function porTres (a,b){
    setTimeout( function(){//creamos la función con una variable con callback
    b(a*3)//le devolvemos el resultado de la variable multiplicado por 3
    },2000)
}
//main

var a= porTres(2, function(res){

//hacemos la prueba automatica
if(res==6){
    console.log("esta bien");
}else{
    console.log("esta fatal");
}
console.log("2 * 3 = ", res);
});