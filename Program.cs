using System;

namespace Formulario
{
    class Form
    {
        static void Main()
        {
            //Formulario Fixa sobre a pessoa

            string nome, sobrenome, cargo, endereco, cpf;
            int idade;
            float altura, peso;

            Console.Write("Qual é seu nome:");
             nome = Console.ReadLine();
            Console.Write("Qual seu sobrenome:");
             sobrenome = Console.ReadLine();
            Console.Write("Qual seu Cargo:");
             cargo = Console.ReadLine();
            Console.Write("Qual seu Endereço:");
             endereco = Console.ReadLine();

            Console.Write("Qual é sua idade:");
              idade = int.Parse(Console.ReadLine());
            Console.Write("Qual é seu CPF:");
              cpf = Console.ReadLine();

            Console.Write("Sua Altura:");
              altura = float.Parse(Console.ReadLine());
            Console.Write("Seu peso:");
              peso = float.Parse(Console.ReadLine());

            Console.WriteLine("\nNome={0} \nSobrenome={1} \nCargo={2} \nEndereço:{3} \nidade={4} \ncpf={5} \naltura={6:f2} \nPeso={7:f2}",nome,sobrenome,cargo,endereco,idade,cpf,altura,peso);

        }
    }
}