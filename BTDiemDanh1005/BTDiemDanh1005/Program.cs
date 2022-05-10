using System;

namespace BTDiemDanh1005
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr167 = new int[100];

            Console.Write("Nhap so phan tu trong mang: ");
            int n167 = int.Parse(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n167);
            for (int i = 0; i < n167; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr167[i] = int.Parse(Console.ReadLine());
            }

            int max167 = arr167[0];
            int min167 = arr167[0];


            for (int i = 1; i < n167; i++)
            {
                if (arr167[i] > max167)
                {
                    max167 = arr167[i];
                }


                if (arr167[i] < min167)
                {
                    min167 = arr167[i];
                }
            }
            Console.WriteLine("Phan tu lon nhat trong mang la: {0}", max167);
            Console.WriteLine("Phan tu nho nhat trong mang la: {0}\n", min167);

            Console.ReadKey();
        }
    }
}

