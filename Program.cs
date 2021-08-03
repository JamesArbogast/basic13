using System;

namespace basic13
{
    class Program
    {



        public static void PrintNumbers()
        {
            for (var i = 0; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (var i = 0; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {

            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;

            for (var i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }

        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (int num in numbers) 
            {
                Console.WriteLine(num);
            }
        }
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int maxInt = 0;
            foreach(int num in numbers)
            {
                if(num > maxInt) {
                    maxInt = num;
                }
                Console.WriteLine(maxInt);
            }
            Console.Write(maxInt);
            return maxInt;
        }

        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            foreach(int num in numbers) 
            {
                sum += num;
            }
            float avg = (float)(sum / numbers.Length);
            Console.WriteLine(avg);
        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the  program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int[] newArray = new int[256];
            for (var i = 0; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    newArray[i] = i;
                    Console.WriteLine(newArray[i]);
                }
            }
            return newArray;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {

            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).

            int numOfVals = 0;
            foreach (int num in numbers) 
            {
                if(num > y)
                {
                    numOfVals++;
                }
            }
            return numOfVals;
        }
        static void Main(string[] args)
        {
            int[] testArray = new int[] {1, -2, 3 ,4 ,10};
            int y = 2;
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(testArray);
            // FindMax(testArray);
            // GetAverage(testArray);
            // OddArray();
            GreaterThanY(testArray, y);
        }
        
    }
}
