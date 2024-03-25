using System;//Biblioteca com os comandos padrões do C#. Obs.: No .Net 5 ela não é mais necessária.

namespace HelloWorldCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");//Console.WriteLine(); É um comando de impressão
            Console.ReadLine();//Console.ReadLine(); Lê a linha e "congela" a tela até que o usuário pressione uma tecla
        }
    }
}
