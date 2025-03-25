namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        
        // Vesão 1: Estrutura básica e entrado do usuário

        static void Main(string[] args)
        {

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("-----------------------------------------------");

                Console.WriteLine("Digite uma letra: ");
                char chute = Console.ReadLine()[0];  // obtém apenas um caractere do que

                Console.WriteLine(chute);

                Console.ReadLine();

            }


        }
    }
}
