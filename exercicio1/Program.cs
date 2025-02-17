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