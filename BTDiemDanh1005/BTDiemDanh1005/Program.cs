using System;

namespace BTDiemDanh1005
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr167 = new int[100];
            int i,j;
            Console.Write("Nhap so phan tu trong mang: ");
            int n167 = int.Parse(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n167);
            for (i = 0; i < n167; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr167[i] = int.Parse(Console.ReadLine());
            }

            int max167 = arr167[0];
            int min167 = arr167[0];


            for (i = 1; i < n167; i++)
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

            int tmp167;
            for (i = 0; i < n167; i++)
            {
                for (j = i + 1; j < n167; j++)
                {
                    if (arr167[j] < arr167[i])
                    {
                        //cach trao doi gia tri
                        tmp167 = arr167[i];
                        arr167[i] = arr167[j];
                        arr167[j] = tmp167;
                    }
                }
            }

            Console.WriteLine("In cac phan tu mang theo thu tu tang dan:\n");
            for (i = 0; i < n167; i++)
            {
                Console.Write("  {0}", arr167[i]);
            }


            Console.ReadKey();
        }
    }
}

