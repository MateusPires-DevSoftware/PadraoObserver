public interface IObservavel
{

    public void Registrar(IObservador _IObservador);

    public void Remover(IObservador _IObservador);

    public void Notificar();

}