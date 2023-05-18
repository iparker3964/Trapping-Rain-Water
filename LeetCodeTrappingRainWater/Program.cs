using System;

namespace LeetCodeTrappingRainWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;

            int[] testOne = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            value = Trap(testOne);
            Console.WriteLine(value);

            int[] testTwo = { 4, 2, 0, 3, 2, 5 };
            value = Trap(testTwo);
            Console.WriteLine(value);
            Console.ReadLine();
        }
        public static int Trap(int[] height)
        {
            int sum = 0;
            int len = height.Length;

            if (len < 3)
            {
                return 0;
            }

            int maxValueIndex = 0;

            for (int i = 0; i < len; i++)
            {
                if (height[maxValueIndex] < height[i])
                {
                    maxValueIndex = i;
                }
            }

            int leftMaxIndex = 0;

            for (int i = 0; i < maxValueIndex; i++)
            {
                if (height[leftMaxIndex] < height[i])
                {
                    leftMaxIndex = i;
                }

                sum += Math.Min(height[leftMaxIndex],height[maxValueIndex]) - height[i];
            }

            int rightMaxIndex = len - 1;

            for (int i = len - 1; i > maxValueIndex; i--)
            {
                if (height[rightMaxIndex] < height[i])
                {
                    rightMaxIndex = i;
                }

                sum += Math.Min(height[rightMaxIndex],height[maxValueIndex]) - height[i];
            }

            return sum;
        }
    }
}
