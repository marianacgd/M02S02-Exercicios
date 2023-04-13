internal class Program
{
    private static void Main(string[] args)
    {
        string marca, modelo;
        double km;

        Console.Write("Digite a marca do veículo: ");
        marca = Console.ReadLine();

        Console.Write("Digite o modelo do veículo: ");
        modelo = Console.ReadLine();

        Console.Write("Digite os Km rodados : ");
        km = double.Parse(Console.ReadLine());

         Console.WriteLine($"\n Marca: {marca}\n Modelo: {modelo}\n Km rodado: {km}");
        
        if (km > 10000) {
            Console.WriteLine("Está na hora de fazer a Revisão no veículo!");
        } else {
            Console.WriteLine("Está tudo em ordem!" );
        } 
        
    }    
}