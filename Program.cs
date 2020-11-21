using System;

namespace desafio1
{
    class Program 
    {
        static void Main() 
        {
            // Esse é o desafio das tartarugas, tbm está salvo na plataforma
            for(int j=0;j<3;j++)
            {
                var qtde = Console.ReadLine();
                
                if(int.TryParse(qtde, out int tartarugas))
                {
                    if(!(1<=tartarugas && tartarugas<=500))
                    {
                        continue;
                    }
                    var vels = Console.ReadLine().Split(" ");
                    
                    if(vels.Length == tartarugas)
                    {
                        var maior = 0;
                        for(int i=0; i<tartarugas; i++)
                        {
                            if(int.TryParse(vels[i], out int vel))
                            {
                                if (vel > maior)
                                {
                                    maior = vel;
                                }
                            }
                        }

                        if(0<maior && maior < 10)
                        {
                            Console.WriteLine("1");
                        }else if(maior < 20)
                        {
                            Console.WriteLine("2");
                        }else if(maior < 50)
                        {
                            Console.WriteLine("3");
                        }else
                        {
                        continue;
                        }
                    }else
                    {
                        continue;
                    }
                }else
                {
                    continue;
                }
            }
        }
    }
}
