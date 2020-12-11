using System;
using POO_Polimorfismo_Sobrecarga.classes;

namespace POO_Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();

            fun.Mostrar();

            fun.Mostrar();

            fun.Mostrar("Tsuka");

            Console.WriteLine("fim do programa");

        }
    }
}
