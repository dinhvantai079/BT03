//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BT03
//{
//    internal class Bai02
//    {
//        private static int INF = int.MaxValue / 2; // Đại diện cho chi phí vô hạn
//        private static int n = 4; // Số lượng điểm (bao gồm cả điểm xuất phát)
//        private static int[,] dist = new int[,]
//        {
//        { 0, 10, 15, 20 },
//        { 10, 0, 35, 25 },
//        { 15, 35, 0, 30 },
//        { 20, 25, 30, 0 }
//        };
//        private static int[,] dp = new int[1 << n, n];

//        static void Main()
//        {
//            // Khởi tạo bảng DP với giá trị lớn (INF)
//            for (int i = 0; i < (1 << n); i++)
//                for (int j = 0; j < n; j++)
//                    dp[i, j] = INF;

//            // Bắt đầu từ điểm xuất phát (0) với chỉ có điểm xuất phát được phục vụ
//            dp[1, 0] = 0;

//            // Cập nhật bảng DP
//            for (int mask = 1; mask < (1 << n); mask++)
//            {
//                for (int u = 0; u < n; u++)
//                {
//                    if ((mask & (1 << u)) == 0) continue; // Điểm u chưa được phục vụ
//                    for (int v = 0; v < n; v++)
//                    {
//                        if ((mask & (1 << v)) != 0) continue; // Điểm v đã được phục vụ
//                        int newMask = mask | (1 << v);
//                        dp[newMask, v] = Math.Min(dp[newMask, v], dp[mask, u] + dist[u, v]);
//                    }
//                }
//            }

//            // Tìm chi phí tối ưu để quay trở về điểm xuất phát
//            int ans = INF;
//            for (int u = 1; u < n; u++)
//            {
//                ans = Math.Min(ans, dp[(1 << n) - 1, u] + dist[u, 0]);
//            }

//            Console.WriteLine("Chi phi toi uu la: " + ans);
//            Console.ReadLine();
//        }

//    }
//}
