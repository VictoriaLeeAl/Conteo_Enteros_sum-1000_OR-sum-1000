/*6.Realiza el análisis, diseño e implementación de un programa que lea del teclado números enteros y los vaya sumando. 
 * Debe detenerse cuando la suma de los números leídos sea 1000 o más, y mostrar el total de la suma y la cantidad de 
 * números que se sumaron.Realiza el análisis, diseño e implementación de un programa que lea del teclado números enteros 
 * y los vaya sumando. Debe detenerse cuando la suma de los números leídos sea 1000 o más, y mostrar el total de la suma 
 * y la cantidad de números que se sumaron.*/

int suma=0;
int cant = 0;
int num;
while (suma <= 1000)
{
    Console.WriteLine("Ingresa un número: ");
    num=Int32.Parse(Console.ReadLine());
    suma = suma + num;
    cant=cant + 1;

}

Console.WriteLine("El total de números ingresados es: " + cant);
Console.WriteLine("El total de la suma de los números es de: " + suma);