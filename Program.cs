using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Algoritimo para calculos simples");


           Console.WriteLine("Digite o primeiro Numero: ");
           int num1 = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite o segundo Numero: ");
           int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o tipo de operação: [-] para subtração | [+] para adição | [*] para multiplicação | [/] para divisão");
            int escolha =char.Parse(Console.ReadLine());

            int resultado =0; 
            

            switch(escolha){
                case'-':
                    resultado = num1 - num2;
                    break;

                case'+':
                    resultado = num1 + num2;
                    break;

                case'*':
                    resultado = num1 * num2;
                    break;

                case'/':
                    resultado = num1 / num2;
                    break;
            }

            Console.WriteLine("O Resulltado da sua operação é: " + resultado);
        }
    }
}
