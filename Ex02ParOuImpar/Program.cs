internal class Program
{
    private static void Main(string[] args)
    {
        int numero;

        Console.Write("Digite um número inteiro: ");
        numero = int.Parse(Console.ReadLine());
        
        if (numero % 2 == 0 ) {
            Console.WriteLine("O número " + numero + " é Par!");
        } else {
            Console.WriteLine("O número " + numero + " é Impar!");
        }

    }    
}