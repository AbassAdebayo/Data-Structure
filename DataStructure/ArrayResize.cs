using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class ArrayResize
    {
        public int[] ResizeArray(int[] numbers)
        {
            int count = 0;

            while (true)
            {
                if (count >= numbers.Length)
                {
                    int[] newArray = new int[numbers.Length * 2];
                    Array.Copy(numbers, newArray, numbers.Length);
                    numbers = newArray;

                }

                if (numbers.Length - 1 == -1)
                {
                    break;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number[{i}]: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                count++;
            }      

            return numbers;
        }
    }
}
