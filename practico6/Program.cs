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
*/
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