using System;

namespace Solution
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Spiral 1:");

            int[,] sample = new int[4, 5] { { 1,    2,  3,  4,  5},
                                            { 14,   15, 16, 17, 6},
                                            { 13,   20, 19, 18, 7},
                                            { 12,   11, 10, 9,  8}
                                            };

            PrintSpiral(sample);

            Console.WriteLine("\nSpiral 2:");
            sample = new int[4, 4]   {  { 1,  2,   3,   4,  },
                                        { 12, 13,  14,  5,  },
                                        { 11, 16,  15,  6,  },
                                        { 10, 9,    8,  7,  },
                                        };

            PrintSpiral(sample);

            Console.WriteLine("\nSpiral 3:");
            sample = new int[3, 4]   {  { 1,  2,   3,   4,  },
                                        { 10, 11,  12,  5,  },
                                        { 9,  8,   7,   6,  }
                                        };

            PrintSpiral(sample);

            Console.WriteLine("\nSpiral 4:");
            sample = new int[5, 3]   {  { 1,  2,   3,  },
                                        { 12, 13,  4, },
                                        { 11, 14,  5,  },
                                        { 10, 15,  6,  },
                                        { 9,  8,   7,  }
                                        };

            PrintSpiral(sample);

            Console.WriteLine("\nSpiral 5:");
            sample = new int[,] { };

            PrintSpiral(sample);

            Console.WriteLine("\nSpiral 6:");
            sample = new int[5, 6]   {  { 1,    2,   3,     4,   5,  6,  },
                                        { 18,  19,   20,   21,  22,  7,  },
                                        { 17,  28,   29,   30,  23,  8,  },
                                        { 16,  27,   26,   25,  24,  9,  },
                                        { 15,  14,   13,   12,  11,  10,  },
                                        };

            PrintSpiral(sample);

            Console.WriteLine("\nSpiral 7:");
            sample = new int[2, 6]   {  { 1,    2,   3,     4,   5,  6,  },
                                        { 12,  11,   10,   9,    8,  7,  },
                                        };

            PrintSpiral(sample);

            Console.WriteLine("\nSpiral 8:");
            sample = new int[1, 6]   {  { 1,    2,   3,     4,   5,  6,  }
                                        };

            PrintSpiral(sample);

            Console.WriteLine("\nSpiral 9:");
            sample = new int[5, 1]   {  { 1 },
                                        { 2 },
                                        { 3 },
                                        { 4 },
                                        { 5 },
                                       };

            PrintSpiral(sample);
            Console.Read();
        }

        public static void PrintSpiral(int[,] a)
        {
            if (a.Length == 0)
            {
                Console.WriteLine("Empty Array");
                return;
            }

            //rows goes from top to bottom
            int top = 0;
            int bottom = a.GetLength(0) - 1;

            //columns goes from left to right
            int left = 0;
            int right = a.GetLength(1) - 1;

            bool flag = true;

            while (flag)
            {

                for (int col = left; col <= right; col++)
                {
                    Console.Write("{0} ", a[top, col]);
                }

                for (int row = top + 1; row <= bottom; row++)
                {
                    Console.Write("{0} ", a[row, right]);
                }

                if (top == bottom) break;// to prevent to repeat the print of the previous row
                for (int col = right - 1; col >= left; col--)
                {
                   
                    Console.Write("{0} ", a[bottom, col]);
                }
                
                if (left == right) break;// to prevent to repeat the print of the previous column
                for (int row = bottom - 1; row > top; row--)
                {
                   
                    Console.Write("{0} ", a[row, left]);
                }

                top++;
                bottom--;
                left++;
                right--;

                flag = top <= bottom && left <= right;
            }


        }
    }
}
