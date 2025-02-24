//Estrutura de dados array
int[] meuArray = {0,1,2,3,4,5};

foreach (int num in meuArray)
{
    Console.WriteLine(num);
}
//Estrutura de dados lista
List<string> listaNomes = new List<string>{"Wanderson", "Jeane", "Ryan"};
listaNomes.Add("Maria");

foreach (string nome in listaNomes)
{
    Console.WriteLine(nome);
}
Console.WriteLine("");
//remover

listaNomes.RemoveAt(0);

foreach (string nome in listaNomes)
{
    Console.WriteLine(nome);
}
Console.WriteLine("");

//Estrutura de dados conjunto
HashSet<int> conjunto= new HashSet<int>{1,2,3};
conjunto.Add(4);
Console.WriteLine("");

foreach (int num in conjunto)
{
    Console.WriteLine(num);
}