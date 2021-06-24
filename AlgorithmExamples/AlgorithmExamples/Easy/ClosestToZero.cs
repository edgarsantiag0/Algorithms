using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExamples.Easy
{
    public class ClosestToZero
    {
        /*
            GOAL:
            In this exercise, you have to analyze records of temperature to find the closest to zero. 

            RULES:
            Write a program that prints the temperature closest to 0 among input data. 
            If two numbers are equally close to zero, positive integer has to be considered closest 
            to zero (for instance, if the temperatures are -5 and 5, then display 5).

            Your program must read the data from the standard input and write the result on the standard output.

            Display 0 (zero) if no temperatures are provided. Otherwise, display the temperature closest to 0.

            Input                       Output

            5                             1
            1 -2 -8 4 5

         */
        public int GetClosestToZero(int n, string[] inputs)
        {
            if (inputs.Length == 0 || n == 0)
            {
                return 0;
            }
            else
            {
                if (inputs.Length == 0 || n == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    int closest = int.Parse(inputs[0]);

                    if (closest < 0)
                        closest *= -1;

                    Array.Sort(inputs);

                    int result = int.Parse(inputs[0]);

                    for (int i = 0; i < n; i++)
                    {
                        int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526

                        if (t < 0)
                            t *= -1;

                        if (closest >= t)
                        {
                            closest = t;
                            result = int.Parse(inputs[i]);
                        }

                    }

                    return result;



                    /*
                        BEST SOLUTION

                            int tempCount = int.Parse(Console.ReadLine());
                            var temps = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                            var result = temps.Select(int.Parse)
                                .OrderBy(Math.Abs)
                                .ThenByDescending(x => x)
                                .FirstOrDefault();


                     */


                }
            }

            return 0;
        }
    }
}
