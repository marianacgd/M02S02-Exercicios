internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, soma;

        Console.Write("Digite um número inteiro: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro número inteiro: ");
        num2 = int.Parse(Console.ReadLine());
        
        soma = num1 + num2;

        Console.WriteLine("A soma das números " + num1 + " + " + num2 + " = " + soma);

    }    
}