using System;

namespace algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            //jokenPo();
            //calculaImc();
            //contador();
            //contador2();
            //aluguelCarro();
            //somador3();
            //somadorImpar();
            calculaSalario();
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

        static void contador(){
           Console.Clear();
           int i = 30;

           while(i >= 1){
            if(i % 4==0){
                Escreve($"[{i}]");
            }
            else
            {
                Escreve(i);
            }
            
            i--;
           }
            
        }

        static void contador2()
        {
            Console.Clear();
            Escreve("Digite o primeiro numero");
            int n1 = int.Parse(Console.ReadLine());
            Escreve("Digite o ultimo valor");
            int n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                Escreve("Numero final menor que o primeiro");
                Thread.Sleep(1500);
                contador2();
            }

            Escreve("Agora, o incremento");
            int n3 = int.Parse(Console.ReadLine());
            
            Escreve("-----------------------");


            while(n1 <= n2)
            {
                Escreve(n1);
                n1 = n1 + n3;
            }
            Escreve("Acabou!!");
            Console.ReadLine();
        }

        static void aluguelCarro()
        {
            Console.Clear();
            Escreve("Qual tipo do carro?\npopular\nluxo");
            string carro = Console.ReadLine();
            Escreve("Quantos dias foram de aluguel?");
            int dias = int.Parse(Console.ReadLine());
            Escreve("Quantos km foram rodados?");
            double km = double.Parse(Console.ReadLine());
            double aluguel;
            switch(carro)
            {
                case "popular":aluguel=90*dias;
                if(km <= 100)
                {
                   double aluguelFinal=aluguel+(0.20*km);
                   Escreve($"O preço final ficou em {aluguelFinal.ToString("C")}");
                }
                else if(km > 100){
                    double aluguelFinal=aluguel+0.10*km;
                    Escreve($"Preço final ficou em {aluguelFinal.ToString("C")} com descontos");
                }
                    
                ;break;
                case "luxo":aluguel=150*dias;
                if(km <= 200){
                    double aluguelFinal=aluguel+0.30*km;
                    Escreve($"Preço final ficou {aluguelFinal.ToString("C")}");
                }
                else if(km > 200){
                    double aluguelFinal=aluguel+=0.25*km;
                    Escreve($"Preço final ficou em {aluguelFinal.ToString("C")} com descontos");
                }
                ;break;
                default:System.Environment.Exit(0);break;
            }
        }

        static void somador()
        {
            Console.Clear();
            int i = 6;
            int acumulador = 0;
            while(i < 100){
               
                acumulador = acumulador + i;
                i = i + 2;

            }
            Console.WriteLine();
            Console.ReadLine();
        }

        static void somador2()
        {
            Console.Clear();
            int i = 500;
            int acumulador = 0;
            while(i >= 0)
            {
               acumulador += i;
               i -= 50;
            }
            System.Console.WriteLine(acumulador);
        }

        static void somador3()
        {
            Console.Clear();
            int acumulador = 0;
            for(int i = 7; i > 0; i--){
                if(i == 7)
                   Escreve($"Insira 7 números inteiro, aperte ENTER a cada número");
                else
                if(i == 1)
                   Escreve($"Insira o último número inteiro!");
                else
                    Escreve($"Insira mais {i} números inteiros");                                
                int numero = int.Parse(Console.ReadLine());
                acumulador += numero;
            }
            System.Console.WriteLine("Total ficou em " + acumulador);
            

        }

        static void somadorImpar()
        {
            Console.Clear();
            Escreve("Insira um numero");
            int n = int.Parse(Console.ReadLine());
            int acumulador = 0;

            for(int i = 0; i < n; i++)
            {
                if(i % 2 == 1)
                {
                    Console.Write($"{i} ");
                    acumulador += i;                   
                }

            }
            Console.Write(acumulador);
            
 
        }

        static void calculaSalario()
        {
            Escreve("Digite o nome do funcionário");
            string nome = Console.ReadLine();
            Escreve("Qual o salário?");
            float salario = float.Parse(Console.ReadLine());
            if(salario <= 1500) {
                var novoSalario = salario + salario * 0.25;
                Escreve($"{nome}, seu salário atual de {salario} será reajustado para {novoSalario}");
            } else if(salario > 1500 && salario < 3000){
                var novoSalario = salario + salario * 0.20;
                Escreve($"{nome}, seu salário atual de {salario} será reajustado para {novoSalario}");  
            } else if(salario > 3000 && salario < 6000){
                var novoSalario = salario + salario * 0.15;
                Escreve($"{nome}, seu salário atual de {salario} será reajustado para {novoSalario}");  
            } else if(salario > 6000){
                var novoSalario = salario + salario * 0.10;
                Escreve($"{nome}, seu salário atual de {salario} será reajustado para {novoSalario}");  
            }


        }
    
    }
        
}

