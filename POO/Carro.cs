using POO.Modelo;

public class Carro: Veiculo
{
    //Atributos
    private bool automatico;
    private int numeroDePortas;

    //Construtor
    public Carro(string marca, string modelo, int ano, double velocidadeAtual, bool automatico, int numeroDePortas): base (marca, modelo, ano, velocidadeAtual)
    {
        this.automatico = automatico;
        this.numeroDePortas = numeroDePortas;
    }

    //Métodos Getters e Setters
    public bool GetAutomatico()
    {
        return automatico:
    }
    public void SetMarca(bool automatico)
    {
        this.automatico = automatico;
    }
    //Adicionar Métodos Getter e Setter para o atributo numeroDePortas
    //AbrirPortas é um método específico da classe Carro.
    public void AbrirPortas()
    {
        Console.WriteLine("As portas do carro estão abertas.");
    }
}