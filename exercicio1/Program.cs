// See https://aka.ms/new-console-template for more information
int idade = 16; // Exemplo de idade
bool temAutorizacao = false; // Exemplo de autorização

if (idade >= 18)
{
    Console.WriteLine("Sua entrada é permitida.");
}
else if (idade <= 18)
{
    if (temAutorizacao )
    {
        Console.WriteLine("Sua entrada é permitida.");
    }
    else 
    {
            Console.WriteLine("Sua entrada não é permitida.");
    }
}
bool possuiPresencaMinima = false; // Exemplo de presença mínima
double media = 7.5; // Exemplo de média

if (possuiPresencaMinima && media > 7)
{
    Console.WriteLine("Aprovado.");
}
else if (!possuiPresencaMinima)
{
    Console.WriteLine("Reprovado por falta de presença mínima.");
}
else
{
    Console.WriteLine("Reprovado por média insuficiente.");
}