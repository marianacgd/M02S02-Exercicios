internal class Program
{
    private static void Main(string[] args)
    {
       string frase = "A linguagem de programação C# é muito poderosa.";

       List<string> palavras = new List<string>(frase.Split(' '));

       string ultimaPalavra = palavras[palavras.Count-1];

       Console.WriteLine(ultimaPalavra);
    }    
}