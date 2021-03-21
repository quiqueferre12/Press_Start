//Ejercicio 1 práctica 2 filtrar.js
//Enrique Ferre Carbonell
//Diseño de la funcion 
//  Lista<T>
//  T -> V/F ----> [filtrar()] ---> Lista<T>
//

function filtrar(lista,f){     
    var Listafiltro =[]
    for (var i=0;i<=lista.length-1;i++){//creamos un for para recorrer la lista
        
         if(f(lista[i])){//aqui haremos que si se cumpla la condición de que la palabra contiene x se incluya en la variable Listafiltro[]
         Listafiltro.push(lista[i])
        }
    
    }
    return Listafiltro 

}//filtrar()

//main
var lista=["Patxi","Tomas", "Xavi", "Arnaxa"]//definimos la lista
var filtro = filtrar(lista,function(palabra){//la variable que contenga la funcion filtrar 
    if(palabra.toLowerCase("X").includes("x")){//usamos el include para hacer el filtro y toLowercase para incluir mayusculas y minusculas
        return true
    }
})

//prueba automatica
console.log(filtro)
if(filtro.length=3){
    console.log("Esta bien") 
}else{
    console.log("esta mal")
}