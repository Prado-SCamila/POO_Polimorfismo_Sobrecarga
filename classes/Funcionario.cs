using System;
namespace POO_Polimorfismo_Sobrecarga.classes
{
    public class Funcionario
    {
        public string[] lista = {"Paulo", "Tsuka", "Mila", "Susy"};

        public void Mostrar(){
            foreach (var item in lista){
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(item);
                Console.ResetColor();

            }
        }
        public void Mostrar(int indice){

             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.WriteLine(lista[indice]);
             Console.ResetColor();
        }
        public void Mostrar( string busca){
            foreach (var item in lista){
                if(item ==busca){
                    Console.WriteLine("REsultado da busca: "+ item);
                }
                Console.ResetColor();
                }
            }
        }
        
    }
