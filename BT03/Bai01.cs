

//using System;

//public class Bai01
//{
//    public static int TinhToHop(int n, int k)
//    {
//        if (k == 0 || k == n)
//            return 1;
//        else
//            return TinhToHop(n - 1, k - 1) + TinhToHop(n - 1, k);
//    }

//    public static int tinhToHop_DP(int n, int k)
//    {
//        int[,] C = new int[n + 1, n + 1];

//        C[0, 0] = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            C[i, 0] = 1;
//            C[i, i] = 1;
//            for (int j = 1; j < i; j++)
//                C[i, j] = C[i - 1, j - 1] + C[i - 1, j];
//        }

//        return C[n, k];
//    }

//    public static int tinhToHop_DP_CaiTien(int n, int k)
//    {
//        int[] V = new int[n + 1];
//        int p1, p2;

//        V[0] = 1;
//        V[1] = 1;
//        for (int i = 2; i <= n; i++)
//        {
//            p1 = V[0];
//            for (int j = 1; j < i; j++)
//            {
//                p2 = V[j];
//                V[j] = p1 + p2;
//                p1 = p2;
//            }
//            V[i] = 1;
//        }

//        return V[k];
//    }

//    public static void Main(string[] args)
//    {
//        int n, k;
//        Console.Write("Nhap n: ");
//        n = int.Parse(Console.ReadLine());
//        Console.Write("Nhap k: ");
//        k = int.Parse(Console.ReadLine());

//        Console.WriteLine($"So Hop C({n}, {k}) (De quy) = {TinhToHop(n, k)}");
//        Console.WriteLine($"So Hop C({n}, {k}) (DP) = {tinhToHop_DP(n, k)}");
//        Console.WriteLine($"So Hop C({n}, {k}) (DP Cai tien) = {tinhToHop_DP_CaiTien(n, k)}");
//    }

//}