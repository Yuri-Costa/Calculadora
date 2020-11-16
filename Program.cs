using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a operação deseja realizar? soma, subtração ou divisão");
            string operacao = Console.ReadLine();

            //pedir o primeiro número
            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse( Console.ReadLine() );

            //pedir o segundo número
            Console.WriteLine("Digite o segundo número:");
            float num2 = float.Parse( Console.ReadLine() );

             float resultado = 0f;

            switch(operacao){

               case "soma":
               resultado = num1 + num2;
               break;

               case "subtração":
               resultado = num1 - num2;
               break;

               case "divisão":
               resultado = num1 / num2;
               break;

               case "multiplicação":
               resultado = num1 * num2;
               break;

               default:
               Console.WriteLine("operação invalida! :(  ");
               break;


                //interpolaçao
                Console.WriteLine($"calculo: {num1} com {num2} = {resultado} ");






            }
        }
    }
}
