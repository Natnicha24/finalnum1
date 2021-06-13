using System;

namespace finalnum1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, h,number2;
        
            int[,] number = new int[3, 3];
            for (h = 0; h < 3; h++)
            { 
              for( i = 0; i < 3; i++)
              {
                    Console.Write("{0}{1}:", i,h);
                  number[i,h]= int.Parse(Console.ReadLine());
              }
            }
            for (h = 0; h < 3; h++)
            {
                for (i = 0; i < 3; i++)
                {
                    Console.Write(" {0}",number[i, h]);
                }
                Console.WriteLine();
            }
            number2 = int.Parse(Console.ReadLine());
          
            for (h = 0; h < 3; h++)
            {
                for (i = 0; i < 3; i++)
                {
                    if(number[i, h] != 0)
                    { 
                    Console.Write(" {0}", number[i, h]);
                    }
                    else
                    {
                        number[i, h] = number2;
                        Console.Write(" {0}", number[i, h]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            }


        }
    }