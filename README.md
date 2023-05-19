
## ¿String es un tipo por valor o un tipo por referencia?

**string** es un tipo por referencia en C#. Cuando asignamos una cadena de texto a una variable de tipo "string", se crea una referencia a esa cadena en 
la memoria en lugar de copiar directamente el valor de la cadena. Con esto cualquier modificación realizada en una variable "string" se reflejará
en todas las referencias a esa cadena en memoria.

## ¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape que se utilizan para representar caracteres especiales dentro de una cadena de texto para representarlos de manera adecuada.
Algunas de las secuencias de escape más comunes son:

* `\"` : Representa una comilla doble (").
* `\'` : Representa una comilla simple (').
* `\\` : Representa un carácter de barra invertida (\).
* `\n` : Representa un salto de línea.
* `\r` : Representa un retorno de carro.
* `\t` : Representa un tabulador horizontal.
* `\b` : Representa un retroceso.
* `\f` : Representa un avance de página.

## Pregunta 3: ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

- El carácter `@` antes de una cadena de texto la trata como una cadena literal, lo que significa que se toma el texto literal sin interpretar secuencias 
de escape, no se los tiene en cuenta. Esto es útil cuando se necesita incluir una ruta de archivo con barras invertidas sin tener que escaparlas.

- El carácter `$` antes de una cadena de texto permite la interpolación de cadenas. Es decir permite combinar valores de variables dentro de una cadena 
de texto de manera más concisa y legible.
La interpolación de cadenas se realiza utilizando la sintaxis ${variable} dentro de la cadena. En lugar de concatenar manualmente los valores de las
variables utilizando el operador +, puedes simplemente incluir las variables dentro de la cadena utilizando la interpolación.
Al usar la interpolación de cadenas, se puede incluir el valor de una variable directamente dentro de una cadena sin tener que concatenar explícitamente.
Ejemplo Console.WriteLine($"Hola, mi nombre es {0} y tengo {1} años.", nombre, edad);
ó Console.WriteLine($"Hola, mi nombre es {nombre} y tengo {edad} años.");

