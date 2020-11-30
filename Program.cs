using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Array ou Vetor");
            Console.ResetColor();
            Console.WriteLine("------------------------------------");
            
            string [] nomes = new string[5];
            int [] idades = new int[5];

            // nomes[0] = "Yan0";
            // nomes[1] = "Yan1";
            // nomes[2] = "Yan2";
            // Console.WriteLine("Nome: "+nomes[2]);

            for(var contador = 0; contador < 5; contador++){
                Console.WriteLine($"Digite o nome do {contador + 1}º nome: ");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine($"Digite a idade do {contador + 1}º usuario: ");
                idades[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nome e idade cadastrada com sucesso!");
                Console.ResetColor();
                Console.WriteLine("------------------------------------");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("         Nomes Cadastrados          ");
            Console.ResetColor();
            Console.WriteLine("------------------------------------");

            for(var contador = 0; contador < 5; contador++){
                
                Console.WriteLine("Nome: "+nomes[contador]);
                Console.WriteLine("Idade: "+idades[contador]);
                Console.WriteLine("---------");
        }
    }
}
