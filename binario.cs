Console.Write("Digite um número decimal: ");
int numerodecimal = int.Parse(Console.ReadLine());
string numerobinario = decimalparabinario(numerodecimal);
Console.WriteLine($"O numero binario equivale a {numerobinario}");

static string decimalparabinario(int numerodecimal)
{
    if (numerodecimal == 0)
        return "0";
    string binario = "";
    while (numerodecimal > 0)
    {
        int i = numerodecimal % 2;
        binario = i + binario;
        numerodecimal /= 2;

    }
    return binario;
}

 