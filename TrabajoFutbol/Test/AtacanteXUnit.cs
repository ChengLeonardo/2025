using Biblioteca;

namespace Test;

public class AtacanteXUnit
{
    Jugador jugador;
    public AtacanteXUnit() => jugador = new Jugador(new Atacante(), 1, 1, 1, 1);
    [Fact]
    public void AplicarEntrenamientoFisico()
    {
        jugador.AplicarEntrenamientoFisico();


        Assert.Equal<double>(2, jugador.Potencia);
        Assert.Equal<double>(1.5, jugador.HabilidadEnLosPases);
    }
    [Fact]
    public void AplicarEntrenamientoLirico()
    {
        jugador.AplicarEntrenamientoLirico();

        Assert.Equal<double>(0.5, jugador.GetPrecision());
        Assert.Equal<double>(2, jugador.HabilidadEnLosPases);
    }

    [Fact]
    public void AplicarEntrenamientoTactico()
    {
        jugador.AplicarEntrenamientoTactico();

        Assert.Equal<double>(1.5, jugador.VisionDelJuego);
        Assert.Equal<double>(1.5, jugador.HabilidadEnLosPases);
        Assert.Equal<double>(1.5, jugador.VisionDeLosCompanieros);
    }
    [Fact]
    public void GetVisionGeneral()
    {
        // Given
        double vision = jugador.GetVisionGeneral();
        
        // When
    
        // Then
        Assert.Equal(2, vision);
    }

}