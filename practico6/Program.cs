/*Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/
int opcion;
string? auxiliarLeer;
string? auxiliarLeer2;

float num1= 0, num2 = 0;
do
{
    
    Console.WriteLine("========== MENÚ ==========");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("0. Salir");
    Console.WriteLine("==========================");
    Console.WriteLine("Ingrese una opcion: ");
    auxiliarLeer = Console.ReadLine();
    if (int.TryParse(auxiliarLeer ,out opcion)){
        
        if (opcion > 5 || opcion < 0)
        {
            Console.WriteLine("Ingrese una opcion correcta");
        }
        else if(opcion != 0)
        { 
            Console.WriteLine("Ingrese el primer numero: ");
            auxiliarLeer = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero: ");
            auxiliarLeer2 = Console.ReadLine();
            if (float.TryParse(auxiliarLeer ,out num1) && float.TryParse(auxiliarLeer2 ,out num2))
            { 
                Console.WriteLine("==========================");
                switch (opcion)
                {
                    case 0: 
                            Console.WriteLine("Gracias por usarnos :)");
                        break;
                    case 1: 
                            Console.WriteLine(num1+" + "+num2+" = "+ (num1 + num2));
                        break;
                    case 2: 
                            Console.WriteLine(num1+" - "+num2+" = "+ (num1 - num2));
                        break;
                    case 3: 
                            Console.WriteLine(num1+" * "+num2+" = "+ (num1 * num2));
                        break;
                    case 4: 
                            Console.WriteLine(num1+" / "+num2+" = "+ (num1 / num2));
                        break;
                }
                Console.WriteLine("==========================");
            }
        }
        
    }
    else
    {
        opcion = 99999;
    }
} while (opcion != 0);