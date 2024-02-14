using System;


public class Program
{

    static void Main(string[] args)
        {
            Desafios();            
        }

    private static void Desafios ()
        {
    while(true)
        {
            var desafios = new SomarNumeros.Desafios();
 
            Console.WriteLine("Digite 1 para soma, digite 2 para subtrair, 3 para dividir ou 4 para mutiplicar: ");
            string opcaoString = Console.ReadLine();

            if (int.TryParse(opcaoString, out int opcao))
                {
                    if( opcao ==1 )
                    {
                        desafios.Calcularsoma();
                    }
                    else if (opcao == 2)
                    {
                        desafios.CalcularSubtracao();
                    }
                    else if (opcao == 3)
                    {
                        desafios.CalcularDivisao();
                    }
                    else if (opcao == 4)
                    {
                        desafios.CalcularMutipicacao();
                    }
                }
                else 
                {
                    Console.WriteLine(" Opçao invalida");
                }
            }
        }
}