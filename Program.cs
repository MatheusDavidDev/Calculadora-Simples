using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação que deseja fazer Soma, Subtracao, Multiplicão, Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro Numero");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo Numero");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;
            // if else padrao
            // if(operacao == "Soma"){
            //    resultado = num1 + num2;

            // }else if(operacao == "Subtracao"){

            // }else if(operacao == "Multiplicacao"){

            // }else if(operacao == "Divisao"){
            //     //resultado = num1/num2

            // }else{
            //   Console.WriteLine("Operação inválida!")ç
            // }

            //switch case
            switch(operacao){

                case "Soma":
                    resultado = num1+num2;
                    break;

                case "Subtracao":
                    resultado = num1-num2;
                    break;

                case "Multiplicacao":
                    resultado = num1*num2;
                    break;

                case "Divisao":
                    resultado = num1/num2;
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }


            //Concatenacao 

            //Interpolação

            Console.WriteLine($"Calculo: {num1} e {num2} = Resultado : {resultado}");


            // Control + ponto e Virgula




        }
    }
}
