public class Mecanico : IObservador
{

    private IObservavel objobservavel;
    public Mecanico(Carro _Carro) 
    {
        this.objobservavel = _Carro;
        this.objobservavel.Registrar(this);
    }
    public void Atualzar(IObservavel _IObservavel)
    {
        if(_IObservavel == this.objobservavel)
        {
            Console.WriteLine("[Mecanico] - O carro reportou um erro");
        }
        
    }
}