namespace SomarNumeros;

    class Desafios
    {
       
        public void Calcularsoma()
        {
            Console.WriteLine("Você escolheu soma");

            Console.Write("Digite um numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var soma = num1 + num2;

            Console.WriteLine("Resultado: " + soma);

        
        }

        public void CalcularSubtracao()
        {  
            Console.WriteLine("Você escolheu subtração");

            Console.Write("Digite um numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var Subtracao = num1 - num2;

            Console.WriteLine("Resultado: " + Subtracao);
        
        }
        public void CalcularDivisao()
        {
   
            Console.WriteLine("Você escolheu divisão");

            Console.Write("Digite um numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var dividir = num1 / num2;

            Console.WriteLine("Resultado: " + dividir);

        
        }
        public void CalcularMutipicacao()
        {
   
            Console.WriteLine("Você escolheu mutiplicação");

            Console.Write("Digite um numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var mutiplicar = num1 * num2;

            Console.WriteLine("Resultado: " + mutiplicar);
        }
    }
