// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;
Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);
*/
//EJERCICIO 1
/*Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
int numero = 0;
bool esNumero ;
string?  numString ="";
string numInvertido ="";

do
{
    Console.WriteLine("\nIngresa un número valido");
    numString = Console.ReadLine();
    esNumero = int.TryParse(numString, out numero);
    if (!esNumero)
    {
        Console.WriteLine(numString + "\nNO es un número válido");
    }
    else
    {
        if (numero > 0)
        {    
            while (numero >= 1)
            {
                numInvertido = numInvertido + (numero % 10);
                numero = numero/10;
            }
            Console.WriteLine(numInvertido);
        }
    }
} while (!esNumero);
*/ 
//================= EJERCICIO 4 =====================
// Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes
// tarea:
/*
string? cadena, cadena2;
Console.Write("Ingrese un texto: ");
cadena = Console.ReadLine();
Console.WriteLine("========== LONGITUD ===========");
// ● Obtener la longitud de la cadena y muestre por pantalla.
if (cadena != null)
{
int longitud = cadena.Length;
Console.WriteLine($"La longitud de la cadena es {longitud}");
}

// ● A partir de una segunda cadena ingresada por el usuario, concatene ambas
// cadenas distintas.
Console.WriteLine("========== CONCATENAR ===========");
Console.Write("Ingrese otro texto: ");
cadena2 = Console.ReadLine();
string concatenada = cadena +" "+cadena2;
Console.WriteLine("Concatenadas: "+ concatenada);

// ● Extraer una subcadena de la cadena ingresada.
Console.WriteLine("========== CONCATENAR ===========");
string? subcadena;
if (cadena != null && cadena.Length > 5)
{
subcadena = cadena.Substring(0,4);
Console.WriteLine("SubCadena: "+ subcadena);
}

// ● Utilizando la calculadora creada anteriormente realizar las operaciones de dos
// números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para
// la suma sería:
// “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
// Donde num1, num2 y resultados son los sumandos y el resultado de la operación
// respectivamente.
// Nota: Busque el comportamiento del Método ToString();
// ● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por
// elemento en pantalla
Console.WriteLine("========== FOREACH ===========");
int num1 = 7;
int num2 = 6;
int resultado = num1 +num2;

//string res = "La suma de "+num1+" y de "+num2+" es igual a : "+resultado+"";
string res = $"La suma de {num1} y de {num2} es igual a : {resultado}";

foreach (char caracter in res)
{
    Console.WriteLine(caracter);
}
// ● Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("========== OCURRENCIA ===========");
int cantOcurrencias = 0;
Console.Write("Ingrese un texto: ");
cadena = Console.ReadLine();
string? palabra;
int indice;
Console.Write("Ingrese la palabra a buscar: ");
palabra = Console.ReadLine();
if (cadena != null && palabra != null)
{
    indice = cadena.IndexOf(palabra);
    while (indice != -1)
    {
        cantOcurrencias ++;
        cadena = cadena.Substring(indice + 1);
        indice = cadena.IndexOf(palabra);
    }    
}
Console.WriteLine($"La cantidad de ocurrencias de '{palabra}' en el texto son: {cantOcurrencias}");
// ● Convierta la cadena a mayúsculas y luego a minúsculas.
Console.WriteLine("========== MAYUS Y MINUS ===========");
Console.Write("Ingrese un texto: ");
cadena = Console.ReadLine();
if (cadena != null)
{
cadena = cadena.ToUpper();
Console.WriteLine(cadena);
cadena = cadena.ToLower();
Console.WriteLine(cadena);
}
// ● Ingrese una cadena separada por caracteres que usted determine y muestre por
// pantalla los resultados (Revisar el comportamiento de split())
Console.WriteLine("========== SEPARAR ===========");
string? aSeparar ="Te,Quiero,Dana";
string []separado = aSeparar.Split(',');
foreach (string minicadena in separado)
{
    Console.WriteLine(minicadena);
    
}
foreach (var minicadena in separado.Select((valor,indice) => new {Valor = valor, Indice = indice} ))
{
    Console.WriteLine($"Índice: {minicadena.Indice}, Valor: {minicadena.Valor}");

}
*/
// ● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
// simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
// por pantalla “582+2” y que le devuelva la suma de 582 con 2
Console.WriteLine("========== ESCRIBIR ECUACION ===========");
string? ecuacion;
char []operadores = {'+','-','*','/','^','#'};
float operando1,operando2;
string aux1, aux2;
char operador;
int indice = -1;
int i = 0;


Console.WriteLine("Ingrese una ecuacion ejemplo (1+1)");
ecuacion = Console.ReadLine();
if (ecuacion != null)
{
    ecuacion = ecuacion.Replace(" ","");
    while (indice == -1 && operadores[i] != '#' )
    {
        indice = ecuacion.IndexOf(operadores[i]);
        i ++;
    }
    
    if (indice != -1 && operadores[i-1]!='#')
    {
        operador = ecuacion[indice];
        aux1 = ecuacion.Substring(0, indice);
        aux2 = ecuacion.Substring(indice+1);
        if (float.TryParse(aux1, out operando1) && float.TryParse(aux2, out operando2))
        {
            switch (operador)
            {
                case '+':
                    Console.Write("= "+ (operando1 + operando2));
                    break;
                case '-':
                    Console.Write("= "+ (operando1 - operando2));
                    break;
                case '*':
                    Console.Write("= "+ (operando1 * operando2));
                    break;
                case '/':
                    if (operando2 != 0)
                    {
                        Console.Write("= "+ (operando1 / operando2));
                    }
                    else
                    {
                        Console.WriteLine("Math error");
                    }
                    break;
                case '^':
                    Console.Write("= "+(Math.Pow(operando1,operando2)));
                break;
            }
        }else
        {
            Console.WriteLine("NO INGRESO CORRECTAMENTE UN OPERANDO");
        }
    }
    else
    {
        Console.WriteLine("NO INGRESO UNA ECUACION CORRECTA");
    }
}

