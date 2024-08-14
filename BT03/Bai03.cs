using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03
{
    internal class Bai03
    {
        // Hàm giải bài toán balo sử dụng phương pháp quy hoạch động
        public static int SolveKnapsack(int[] weights, int[] values, int capacity)
        {
            int n = weights.Length;
            int[,] dp = new int[n + 1, capacity + 1];

            // Xây dựng bảng dp
            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= capacity; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        dp[i, w] = 0;
                    }
                    else if (weights[i - 1] <= w)
                    {
                        dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            return dp[n, capacity];
        }

        public static void Main()
        {
            int[] weights = { 1, 2, 3, 8, 7, 4 }; // Khối lượng của các món đồ
            int[] values = { 20, 5, 10, 40, 15, 25 }; // Giá trị của các món đồ
            int capacity = 10; // Khối lượng tối đa của balo

            int maxValue = SolveKnapsack(weights, values, capacity);

            Console.WriteLine("Gia tri toi da co the dat duoc: " + maxValue);
            Console.ReadKey();
        }

    }
}
