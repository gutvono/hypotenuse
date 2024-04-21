float side1 = 0, side2 = 0;
int restart = 0;

do
{
    Console.Clear();
    Console.WriteLine("Informe os 2 lados do triangulo para calcular a hipotenusa:");

    Console.Write("Lado A:");
    side1 = float.Parse(Console.ReadLine());

    Console.Write("Lado B:");
    side2 = float.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Hipotenusa = {Math.Sqrt((side1 * side1) + (side2 * side2))}");

    Console.WriteLine("Deseja fazer um novo cálculo?");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("2 - NÃO");
    restart = int.Parse(Console.ReadLine());
} while (restart == 1);