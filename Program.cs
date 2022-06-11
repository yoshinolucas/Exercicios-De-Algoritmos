using System;

namespace algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            //jokenPo();
            calculaImc();
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
                case 1:Escreve("Empate! Pedra e Pedra"); break;
                case 2:Escreve("Perdeu!! Pedra e Papel"); break;
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
                case 1:Escreve("Empate! Papel e Papel"); break;
                case 2:Escreve("Perdeu!! Papel contra Tesoura"); break;
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
                case 1: Escreve("Empate! Tesoura e Tesoura"); break;
                case 2: Escreve("Perdeu!! Tesoura e Pedra"); break;
                case 3: Escreve("Ganhou!!!! Tesoura contra Papel!"); break;
            }
            Sair();
        }

        static void Sair(metodo)
        {
            Thread.Sleep(2000);
            Escreve("1 - Continuar | 0 - Sair");
            int opt = int.Parse(Console.ReadLine());
            switch(opt)
            {
                case 1:metodo;break;
                case 0:System.Environment.Exit(0);break;
                default:Escreve("Opção inválida!");
                Sair();break;
            }
        }


        ///////////////////////////////////////

        static void calculaImc(){
            Console.Clear();
            Escreve("Escreve teu peso");
            double peso = double.Parse(Console.ReadLine());
            Escreve("Informe a sua altura");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso /(altura*altura);
            Escreve($"Seu imc é {imc}");
            if(imc < 18.5)
              Escreve("Está abaixo do peso ideal");
            if(imc >= 18.5 && imc < 25)
              Escreve("Está no peso ideal");
            if(imc >= 25 && imc < 30)
              Escreve("Está com sobrepeso");
            if(imc >= 30 && imc < 40);
              Escreve("Está obeso");
            if(imc >= 40)
              Escreve("Obesidade mórbida");
              
        }




    }
        
}

