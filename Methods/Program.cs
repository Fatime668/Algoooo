using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addElement(num));
        }
        public static int addElement(int num)
        {
            int number = num;
            int remainder = 0;
            int newElement = 3;
            while (num>0)
            {
                remainder = num % 10;
                num /= 10;
                newElement *= 10;

            }
            return newElement + number;
        }
       
    }
}
