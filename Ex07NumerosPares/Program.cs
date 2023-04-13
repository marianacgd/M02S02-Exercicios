internal class Program
{
    private static void Main(string[] args)
    {
      int numero;

      do {
        Console.Write("Digite um número inteiro positivo: ");
        numero = int.Parse(Console.ReadLine());

        if (numero <= 0) {
            Console.WriteLine("Erro! o número deve ser positivo e diferente de zero.");
        }
      } while (numero <= 0);

      Console.WriteLine($"Números pares até {numero}:");

      for (int i = 0; i <= numero; i += 2){
        Console.Write(i + " ");
      }

      Console.WriteLine();

    }    
}