// See https://aka.ms/new-console-template for more information
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


        BigInteger prueba = Factorial(30);
        Console.WriteLine(prueba); // 30!

        BigInteger ordenNoNecesitado = Factorial(24);
        Console.WriteLine(ordenNoNecesitado); // 24!

        double ordenNecesario = (double)(prueba / ordenNoNecesitado);
        Console.WriteLine(ordenNecesario); // 30! / 24!

        double resultado = 1 / ordenNecesario;
        Console.WriteLine(resultado); // Inver