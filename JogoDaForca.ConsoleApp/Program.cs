namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        
        // Vesão 4: Exibir desenho da forca

        static void Main(string[] args)
        {

            while (true) 
            {
                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                {
                    // acessar o array no indice 0

                    letrasEncontradas[caractere] = '_';
                }

              

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;   
                bool jogadorAcertou = false;

                do
                {
                    string dicaDaPalavra = string.Join("", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("-----------------------------------------------");

                    if (quantidadeErros == 0)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 1)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 2)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 3)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 4)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");

                    }


                    else if (quantidadeErros == 5)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |        ---       ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");

                    }


                



                

                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Quantidade de erros: " + quantidadeErros);
                    Console.WriteLine("-----------------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0]!.ToUpper()[0];

                    
                    bool letraFoiEncontrada = false;
 
                    for (int contador = 0; contador < palavraSecreta.Length; contador++)
                    {
                        char letraAtual = palavraSecreta[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                       
                    }

                   
                    if (letraFoiEncontrada == false)
                        quantidadeErros++;


                    dicaDaPalavra = string.Join("", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavraSecreta;
                    jogadorEnforcou = quantidadeErros > 5;

                    

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Você acertou a palavra secreta!! Era:" + palavraSecreta);
                        Console.WriteLine("-----------------------------------------------");
                    }
                  
                    else if (jogadorEnforcou)
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Jogo da Forca");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |        ---       ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Que azar! A palavra secreta!! Era:" + palavraSecreta);
                        Console.WriteLine("-----------------------------------------------");
                    }



                } while (jogadorAcertou == false && jogadorEnforcou == false); // || = OU

                Console.ReadLine();

            }

        }
    }
}
