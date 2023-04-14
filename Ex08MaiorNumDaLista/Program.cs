internal class Program
{
    private static void Main(string[] args)
    {
      int[] numeros = new int[5];

      for (int i = 0; i < 5; i++){
        Console.Write($"Digite o {i+1}º número inteiro: ");
        numeros[i] = int.Parse(Console.ReadLine());
      }

      int numMaior = numeros[0];
      for (int i = 1; i < 5; i++) {
        if (numeros[i] > numMaior){
            numMaior = numeros[i];
        }
      }

      Console.WriteLine($"\nO maior número digitado foi {numMaior}.");

    }    
}