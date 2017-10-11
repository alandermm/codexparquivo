using System;
using System.IO;
namespace Aula5_2
{
    class Program
    {
        static void Main(string[] args) {
            FileInfo fi = new FileInfo("Arquivo.txt");       
            if (fi.Exists){
                Console.WriteLine("Tamanho: " + fi.Length + " bytes");
                Console.WriteLine("Extensão " + fi.Extension);
                Console.WriteLine("Caminho: " + fi.FullName);
            } else {            
                Console.WriteLine("Arquivo não existe");    
            }

            StreamWriter sw = new StreamWriter("Arquivo.txt", true);
            sw.WriteLine("Teste 1");
            sw.WriteLine("Teste 2");
            sw.WriteLine("_____________________________");
            sw.Close();
        }
    }
}