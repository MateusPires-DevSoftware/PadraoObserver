public class Borracheiro : IObservador
{

    private IObservavel objobservavel;
    public Borracheiro(Carro _Carro) 
    {
        this.objobservavel = _Carro;
        this.objobservavel.Registrar(this);
    }
    public void Atualzar(IObservavel _IObservavel)
    {
        if(_IObservavel == this.objobservavel)
        {
            Console.WriteLine("[Borracheiro] - O carro reportou um erro");
        }
        
    }
}