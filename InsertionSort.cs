using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class InsertionSort
    {
        public void Sort()
        {
            int[] arr = new int[5] { 6, 10, 91, 54, 72 };
            int val, flag;
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("Initial Array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            for(int i =1; i < arr.Length; i++)
            {
                val = arr[i];
                flag = 0;
                for(int j= i-1;j>= 0&& flag!=1;)
                {
                    if(val  < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j+1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Sorted Array is :");
            for(int i=0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }
}
