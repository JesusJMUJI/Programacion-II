# Septimo entregable

1. Resuelve el ejercicio 3.2 de las diapositivas de clase del tema 3 (objetos y estructuras).

2. Escribir una clase Pelota que permita construir objetos con un radio (double) y color (String). También debe poder construirse un objeto de esa clase sin suministrarle esos valores (en este caso asociar los valores por defecto: a radio el valor 1.5 y a color el valor “Blanco”). Incorporarle también un método denominado Descripción que devuelva una cadena con la descripción de los valores de sus atributos (por ejemplo, si radio vale 3.4 y color es “Azul”, la cadena devuelta debería ser “Soy una pelota de radio 3.4 y de color Azul”.

    Escribir una secuencia de código en C# que construya dos objetos de la clase Pelota: p1 (con radio 3.2 y color “Rojo”) y p2 (con los valores por defecto). Luego construye un nuevo objeto p3 de la clase Pelota cuyo radio sea la multiplicación de los radios de los objetos p1 y p2 y cuyo color sea “Verde”. Finalmente, muestra por pantalla la descripción de los objetos p1, p2 y p3.

    Escribir otra secuencia de código diferente que cree un array de 10 objetos Pelota. Cada objeto de ese array será de color “Rojo” si está en posiciones pares y “Verde” si está en las impares; el radio de cada objeto de ese array será de valor igual a la posición del objeto en el array + 2 (por ejemplo, para el objeto que ocupa la posición 3 del array el valor de su radio será 5). Mostrar en consola todas las descripciones de los objetos Pelota del array que sean de color “verde”.

    Escribir un método que reciba un array de objetos Pelota y un color. Este método ha de devolver otro array formado solo por los elementos del array que sean de ese color.
