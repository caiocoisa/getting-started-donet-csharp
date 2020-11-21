using System;


namespace desafio1
{
    public class Desafio2
    {
        public Desafio2(){
            Console.WriteLine("Insira quilometros: ");
            var input = Console.ReadLine();
            if(Int32.TryParse(input, out int quilometros))
            {
                int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
                Console.WriteLine(minutos + " minutos");
            }
        }
    }
}