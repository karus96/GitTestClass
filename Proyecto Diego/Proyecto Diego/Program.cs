// Calculadora

Console.Write("Ingrese el primer numero: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicacion");
Console.WriteLine("4. Division");
Console.Write("Seleccione una operacion: ");
double operacion = Convert.ToDouble(Console.ReadLine());
if (operacion == 1)
{
    double result = numero1 + numero2;
    Console.WriteLine("La suma es: " + result);
}
else if (operacion == 2)
{
    double result = numero1 - numero2;
    Console.WriteLine("La resta es: " + result);
}
else if (operacion == 3)
{
    double result = numero1 * numero2;
    Console.WriteLine("La multiplicacion es: " + result);
}
else if (operacion == 4)
{
    if (numero2 == 0)
    {
        Console.WriteLine("No se puede dividir por cero");
    }
    else
    {
        double result = numero1 / numero2;
        Console.WriteLine("La division es: " + result);
    }
}
    