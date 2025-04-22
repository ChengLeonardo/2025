using System.Numerics; 

namespace Biblioteca;
public class Simulador
{
    public long SimulacionSinHilo(Bolillero bolillero, List<int> jugada, int vecesJugar)
    {
        long resultado = bolillero.JugarNVeces(jugada, vecesJugar);
        return resultado;
    }
    public double SimulacionConHilo(Bolillero bolillero, List<int> jugada, int vecesJugar, int cantidadHilosAUsar)
    {
        Bolillero[] bolilleros = bolillero.ClonarSiMismo(cantidadHilosAUsar);
        int repeticionPorHilo = vecesJugar / cantidadHilosAUsar;

        double acum = 0;

        Task<long>[] simulaciones = new Task<long>[cantidadHilosAUsar];
        for(int i = 0; i < cantidadHilosAUsar; i++)
        {
            var clon = bolilleros[i];
            simulaciones[i] =
                Task.Run(() => clon.JugarNVeces(jugada, repeticionPorHilo));
        }

        Task.WaitAll(simulaciones);

        Array.ForEach(simulaciones, s => acum+=s.Result);
        
        return acum;

    }

    BigInteger Factorial(int n){
        BigInteger resultado = 1;
        for (int i = 2; i <= n; i++){
            resultado *= i;
        }
        return resultado;
    }

    public double Probabilidad(Bolillero bolillero, int longitudJugada){
        int cantidadBolillas = bolillero.Bolillas.Count;
        BigInteger OrdenPosibles = Factorial(cantidadBolillas);

        BigInteger ordenNoNecesitado = Factorial(cantidadBolillas - longitudJugada);

        double OrdenNecesario = (double)(OrdenPosibles/ordenNoNecesitado);

        double resultado =  1 / OrdenNecesario;

        return resultado;
    }
}