// See https://aka.ms/new-console-template for more information
using Biblioteca;
using System.Numerics; // ¡Esta línea es clave!

Task task = Task.Run(() => Console.WriteLine("GoodByeWorld!"));

System.Console.WriteLine("|hoa;sdf|)");

BigInteger Factorial(int n){
    BigInteger resultado = 1;
    for (int i = 2; i <= n; i++){
        resultado *= i;
    }
    return resultado;
}


        BigInteger prueba = Factorial(10);
        Console.WriteLine(prueba); // 30!

        BigInteger ordenNoNecesitado = Factorial(7);
        Console.WriteLine(ordenNoNecesitado); // 24!

        double ordenNecesario = (double)(prueba / ordenNoNecesitado);
        Console.WriteLine(ordenNecesario); // 30! / 24!

        double resultado = 10000 / ordenNecesario;
        Console.WriteLine($"ESTA es la teoria: {resultado }"); // Inver

// BigInteger totalPosibilidades = Factorial(10) / Factorial(10 - 3); // Factorial(7)
// Console.WriteLine($"Total de combinaciones posibles (ordenadas): {totalPosibilidades}");

// double probabilidadEsperada = 10000 / (double)totalPosibilidades;
// Console.WriteLine($"ESTA es la teoria: {probabilidadEsperada }"); // Inver

System.Console.WriteLine("test");
ILogica logica = new LogicaRandom();
Bolillero bolillero = new Bolillero(10, logica);
bool resultado2 = false;
List<int> jugada = new List<int>{1, 2, 3};
int intentos = 0;

while (intentos != 10000)
{
    intentos++;
    resultado2 = bolillero.Jugar(jugada);
    bolillero.ReingresarBolilla();
    if(resultado2 == true)
    {
        resultado2 = false;
        System.Console.WriteLine($"acertado {intentos}");
    }

};