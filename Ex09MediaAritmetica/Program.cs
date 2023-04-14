internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de números que você deseja calcular a média: ");
        int quantidade = int.Parse(Console.ReadLine());

        double[] numeros = new double[quantidade];

        for (int i = 0; i < quantidade; i++) {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        double soma = 0;
        foreach (double numero in numeros) {
            soma += numero;
        }

        double media = soma / quantidade;
        Console.WriteLine($"A média aritmética dos números digitados é: {media}");

    }    
}