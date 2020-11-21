using System;

namespace desafio1
{
    public class Desafio
    {
        public Desafio(){
            var input = Console.ReadLine();
            if(Int32.TryParse(input, out Int32 limit))
            {              
                for(int i=0; i<limit; i++)
                {
                    string[] line = Console.ReadLine().Split(" ");
                    if (line.Length == 2)
                    {
                        if(double.TryParse(line[0], out double X) && 
                        double.TryParse(line[1], out double Y))
                        {
                            X = double.Parse(line[0]);
                            Y = double.Parse(line[1]);

                            if (Y == 0)
                            {
                                Console.WriteLine("Divisão impossível!");
                            }else{
                                double divisao = (double)X/Y; // Escreva aqui o cálculo    

                                if(divisao < 0 && (divisao.ToString("N1") == "0.0")) 
                                {
                                    Console.WriteLine("-0.0");
                                }else {
                                    Console.WriteLine(divisao.ToString("N1"));
                                }
                            }
                        }else{
                            Console.WriteLine("Divisão inválida!");
                        }                        
                    }else{
                        Console.WriteLine("Entrada incorreta!");
                    }
                }
            }
        }        
    }
}