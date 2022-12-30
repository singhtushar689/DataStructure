using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BubbleSort
    {
        public void Sort()
        {
            int[] array = { 34, 73, 54, 23, 64, 86, 46 };
            int temp;
            for(int j = 0; j <= array.Length-2; j++)
            {
                for(int i = 0; i <= array.Length -2; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        temp = array[i + 1];
                        array[i+1] = array[i];
                        array[i] = temp; 
                    }
                }
            }
            Console.WriteLine("Ascending order of the array is given");
            foreach(int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
