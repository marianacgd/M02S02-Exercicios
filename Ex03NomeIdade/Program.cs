internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        int idade;

        Console.Write("Digite o nome do paciente: ");
        nome = Console.ReadLine();

        Console.Write("Digite a idade do paciente: ");
        idade = int.Parse(Console.ReadLine());

         Console.WriteLine($"O nome do paciente é: {nome}");
        
        if (idade < 18) {
            Console.WriteLine("Paciente Menor de idade!");
        } else if(idade >= 18 && idade < 60) {
            Console.WriteLine("Paciente Maior de idade!");
        } else if(idade >= 60){
            Console.WriteLine("Paciente Idoso!");
        } 
        
    }    
}