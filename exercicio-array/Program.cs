// See https://aka.ms/new-console-template for more information
int[] numeros = { 1, 2, 3, 4, 5 };
int soma = numeros.Sum();
{
    Console.WriteLine($"Soma dos elementos: {soma}");
}
List<string> nomes = new List<string> { "Jeane", "Ryan", "Jeane" };
int contagem = nomes.Count(n => n.Equals("Jeane", StringComparison.OrdinalIgnoreCase));
{
    Console.WriteLine($"O nome Jeane aparece {contagem} vezes");
}
List<int> numeros = new List<int> { 1, 2, 2, 3, 4, 5 };
List<int> semDuplicatas = numeros.Distinct().ToList();
{
    Console.WriteLine("Lista sem duplicatas: " + string.Join(", ", semDuplicatas));
}
HashSet<string> frutas = new HashSet<string> { "Maçã", "Banana", "Laranja" };
{
    Console.WriteLine(frutas.Contains("Banana") ? "Banana está no conjunto" : "Banana não encontrada");
}
List<int> numeros = new List<int>();
for (int i = 1; i <= 5; i++)
    numeros.Add(i);
{
    Console.WriteLine("Elementos da lista: " + string.Join(", ", numeros));
}
