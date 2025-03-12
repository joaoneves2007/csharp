using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Modelo
{
    public class Veiculo
    {
         private string marca;
       private string modelo;
       private int ano;
       private double velocidadeAtual;
      

       //Construtor
       public Veiculo(string marca, string modelo, int ano, double velocidadeAtual)
       {
           this.marca = marca;
           this.modelo = modelo;
           this.ano = ano;
           this.velocidadeAtual = velocidadeAtual;
       }
       
       public string GetMarca()
       {
        return marca;
       }
       public void SetMarca(string marca)
       {
        this.marca = marca;
       }

       public string GetModelo()
       {
        return modelo;
       }
       public void SetModelo(string modelo)
       {
        this.modelo = modelo;
       }

       public int GetAno()
       {
        return ano;
       }
       public void SetAno(int ano)
       {
        this.ano = ano;
       }

       public double GetVelocidadeAtual()
       {
        return velocidadeAtual;
       }
       public void SetVelocidadeAtual(double velocidadeAtual)
       {
        this.velocidadeAtual = velocidadeAtual;
       }
       
        //Métodos Andar e Falar
        public void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} Km/h.");
        }
        public void Freiar(double decremento)
        {
            velocidadeAtual -= decremento;
            Console.WriteLine($"Freiando... Velocidade atual {velocidadeAtual} Km/h.");
        }
    }
}