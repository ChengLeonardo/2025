using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca;

public class BolilleroTest : IBolillero
{
    public List<Bolilla> Bolillas {get;set;} = new List<Bolilla>();

    public BolilleroTest(int cantidadBolillasBolillero)
    {
        GenerarBolillas(cantidadBolillasBolillero);
    }

    public void GenerarBolillas(int cantidadBolillas)
    {
        Bolillas.Clear();
        for(int i = 0; i < cantidadBolillas; i++)
        {
            Bolilla bolilla = new Bolilla(i);
            Bolillas.Add(bolilla);
        }
    }

    public List<Bolilla> GeneradorAzar(int cantidadBolillas)
    {
        List<Bolilla> BolillasSacadas = Bolillas.Select(Bolilla => Bolilla).Take(cantidadBolillas).ToList();
        Bolillas = Bolillas.Except(BolillasSacadas).ToList();
        return BolillasSacadas;
    }

    public bool CompararRespuesta(List<Bolilla> bolillasSacadas, List<Bolilla> jugada)
    {
        bool resultado = true;
        if(!bolillasSacadas.SequenceEqual(jugada)){
            resultado = false;
        }

        return resultado;
    }

    public bool Jugar(List<int> jugada)
    {
        List<Bolilla> bolillas = new List<Bolilla>();
        foreach(int numero in jugada)
        {
            bolillas.Add(new Bolilla(numero));
        }
        var lista = GeneradorAzar(jugada.Count());

        bool resultado = CompararRespuesta(lista, bolillas);
        return resultado;
    }

    
}