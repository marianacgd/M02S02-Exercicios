internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        int idade;

        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

         Console.WriteLine("Olá Sr(a) " + nome + " !");
        
        if (idade < 18) {
            Console.WriteLine("Você é Menor de idade!");
        } else if(idade >= 18 && idade < 60) {
            Console.WriteLine("Você é Maior de idade!");
        } else if(idade >= 60){
            Console.WriteLine("Você é Idoso!");
        } 
        
    }    
}