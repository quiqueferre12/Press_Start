//Ejercicio 2 MainPorTres2.js 
//Enrique Ferre Carbonell
//R--> porTres2()-->R
function porTres (a,b){//creamos la función con una variable
    var res = a*3;
    b(res);
    }

    //main
    var a = porTres(6,function (resultado){//se incluye el Callback aqui en la funcion resultado
        //hacemos la prueba automatica
        if(resultado==18){
            console.log("esta bien");
        }else{
            console.log("esta fatal");
        }
        console.log("6 * 3 = ", resultado);
    })