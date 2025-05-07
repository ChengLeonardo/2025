namespace Biblioteca;

public abstract class Pelea
{
    public abstract double GetPoderPelea();
    public virtual bool Pelear(Pelea pelea)
    {
        return this.GetPoderPelea() > pelea.GetPoderPelea();
    }
}