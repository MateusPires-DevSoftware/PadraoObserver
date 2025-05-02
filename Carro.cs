public class Carro : IObservavel
{
    private List<IObservador> observadores = new List<IObservador>();

    public string Nome { get; set; }
    public void Notificar()
    {
        foreach(var obj in this.observadores)
        {
            obj.Atualzar(this);
        }
    }

    public void Registrar(IObservador _IObservador)
    {
        this.observadores.Add(_IObservador);
    }

    public void Remover(IObservador _IObservador)
    {
        this.observadores.Remove(_IObservador);    
    }

    public void DefeitoEncontrado()
    {
        this.Notificar();
    }
}