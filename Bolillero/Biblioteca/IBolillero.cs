using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca;

public interface IBolillero
{    List<Bolilla> Bolillas {get; set;}
    void GenerarBolillas(int cantidadBolillas);
    List<Bolilla> GeneradorAzar(int cantidadBolillas);
    bool CompararRespuesta(List<Bolilla> bolillasSacadas, List<Bolilla> jugada);
    bool Jugar(List<int> jugada);
}