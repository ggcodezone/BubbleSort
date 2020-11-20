using System;
using System.Threading.Tasks;

namespace Bubblesort
{
    //Name: Bubble Sorter
    //Author: Gwen Kalasky
    //Date: 11/17/20
    //Synopsis: This program uses a bubble sort to organize designated integer values into ascending order
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberarray;//declaring the array
            int temp; //temporary variable used in swapping

            numberarray = new int[9] { 4, 6, 5, 1, 20, 9, 10, 3, 14 }; //set the number of elements using [], set the element values in {}
            for (int i=0;i<numberarray.Length; i++) //loop picks element of array
            {
                for(int k=0; k<numberarray.Length; k++) //second loop to access the next element
                {
                    //comparing the values
                    if (numberarray[i] < numberarray[k])
                    {
                        //if the first value is greater than the second, elements are swapped
                        temp = numberarray[i];
                        numberarray[i] = numberarray[k];
                        numberarray[k] = temp;
                    }
                }
            }
            //print sorted list
            for(int i=0; i < numberarray.Length; i++)
            {
                Console.WriteLine(numberarray[i]);
      
            }
        }
    }
}
