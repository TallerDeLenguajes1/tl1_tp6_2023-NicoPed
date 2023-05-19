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
bool correctoNum2 = true, correctoNum1 = true;
double radianes;
int parteEntera;
do
{
    correctoNum2 = true; 

    Console.WriteLine("========== MENÚ ==========");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Valor Absoluto");
    Console.WriteLine("6. Cuadrado");
    Console.WriteLine("7. Raiz Cuadrada");
    Console.WriteLine("8. Seno");
    Console.WriteLine("9. Coseno");
    Console.WriteLine("10. Parte entera de un real");
    Console.WriteLine("0. Salir");
    Console.WriteLine("==========================");
    Console.WriteLine("Ingrese una opcion: ");
    auxiliarLeer = Console.ReadLine();
    if (int.TryParse(auxiliarLeer ,out opcion)){
        
        if (opcion > 10 || opcion < 0)
        {
            Console.WriteLine("Ingrese una opcion correcta");
        }
        else if(opcion != 0)
        {
            Console.WriteLine("Ingrese el numero: ");
            auxiliarLeer = Console.ReadLine();
            correctoNum1 = float.TryParse(auxiliarLeer ,out num1);
            if (opcion <= 4)
            {
                Console.WriteLine("Ingrese el otro numero: ");
                auxiliarLeer2 = Console.ReadLine();
                correctoNum2 = float.TryParse(auxiliarLeer2 ,out num2);
            } 
            if (correctoNum1 && correctoNum2)
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
                    case 5:
                            Console.WriteLine("|"+num1+"| = "+ (num1 >= 0? num1 : -num1));
                        break;
                    case 6:
                            Console.WriteLine(num1 +"^2 = "+ (num1 * num1));
                        break;
                    case 7:
                            Console.WriteLine("raiz("+num1+") = "+ Math.Sqrt(num1));
                        break;
                    case 8:
                            radianes = num1 * (Math.PI /180);             
                            Console.WriteLine("Sin("+num1+")= "+ Math.Sin(radianes));
                        break;
                    case 9:
                            radianes = num1 * (Math.PI /180);             
                            Console.WriteLine("Cos("+num1+")= "+ Math.Cos(radianes));
                        break;
                    case 10:
                            parteEntera = (int)num1;
                            Console.WriteLine("Ent("+num1+")= "+ parteEntera);
                        break;
                }
                Console.WriteLine("==========================");
            }
        }
        
    }
    else
    {
        opcion = 9999;
    }
} while (opcion != 0);