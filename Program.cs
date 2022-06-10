using System;

namespace algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            jokenPo();
        }

        static void Escreve(object msg)
        {
            Console.WriteLine(msg);
        }

        static void jokenPo()
        {
            Console.Clear();
            Escreve("Escolha: \n\n 1-Pedra\n 2-Papel\n 3-Tesoura\n\n0-Sair\n");
            int ppt = int.Parse(Console.ReadLine()); 

            switch(ppt)
            {
                case 1: Pedra(); break;
                case 2: Papel(); break;
                case 3: Tesoura(); break;
                case 0: System.Environment.Exit(0); break;
                default: jokenPo(); break;
            }

        }

        static void Pedra()
        {
            Random randNum = new Random();
            int valor = randNum.Next(0, 4);
            switch(valor)
            {
                case 1:Escreve("Empate Pedra e Pedra"); break;
                case 2:Escreve("Perdeu! Pedra e Papel"); break;
                case 3:Escreve("Ganhou!!!! Pedra contra Tesoura"); break;
            }
            Sair();
            
        }

        static void Papel()
        {
              Random randNum = new Random();
            int valor = randNum.Next(0, 4);
            switch(valor)
            {
                case 1:Escreve("Empate Papel e Papel"); break;
                case 2:Escreve("Perdeu! Papel contra Tesoura"); break;
                case 3:Escreve("Ganhou!!!! Papel contra Pedra!"); break;
            }
           Sair();
        }

        static void Tesoura()
        {
             Random randNum = new Random();
            int valor = randNum.Next(0, 4);
            switch(valor)
            {
                case 1: Escreve("Empate Tesoura e Tesoura"); break;
                case 2: Escreve("Perdeu! Tesoura e Pedra"); break;
                case 3: Escreve("Ganhou!!!! Tesoura contra Papel!"); break;
            }
            Sair();
        }

        static void Sair()
        {
            Thread.Sleep(2000);
            Escreve("1 - Continuar | 0 - Sair");
            int opt = int.Parse(Console.ReadLine());
            switch(opt)
            {
                case 1:jokenPo();break;
                case 0:System.Environment.Exit(0);break;
                default:Escreve("Opção inválida!");
                Sair();break;
            }
        }
    }        
}

