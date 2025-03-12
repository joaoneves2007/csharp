using POO.Modelo;

public class Moto: Veiculo
{
    // Atributos
    private bool partidaEletrica { get; set; }
    private bool protetorDeCarenagem { get; set; }

    // Construtor
    public Moto(string marca, string modelo, int ano, double velocidadeAtual, bool partidaEletrica, bool protetorDeCarenagem): base (marca, modelo, ano, velocidadeAtual)
    {
        this.partidaEletrica = partidaEletrica;
        this.protetorDeCarenagem = protetorDeCarenagem;
    }

    // Empinar é um método específico da classe Moto.
    public void Empinar()
    {
        Console.WriteLine("Empinando a moto!");
    }
}