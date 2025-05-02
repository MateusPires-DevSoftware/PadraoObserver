public class Eletricista : IObservador
{

    private IObservavel objobservavel;
    public Eletricista(Carro _Carro) 
    {
        this.objobservavel = _Carro;
        this.objobservavel.Registrar(this);
    }
    public void Atualzar(IObservavel _IObservavel)
    {
        if(_IObservavel == this.objobservavel)
        {
            Console.WriteLine("[Eletricista] - O carro reportou um erro");
        }
        
    }
}