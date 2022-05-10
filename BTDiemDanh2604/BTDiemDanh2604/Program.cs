using System;

namespace BTDiemDanh2604
{
    class Program
    {
        class PTB2
        {
            public double a167, b167, c167;
            public double x1167, x2167, delta167;


            public PTB2()
            {
                a167 = 10;
                b167 = 5;
                c167 = 4;
            }

            public PTB2(double so1, double so2, double so3)
            {
                a167 = so1;
                b167 = so2;
                c167 = so3;
            }
            public string SoA
            { get; set; }

            public string SoB
            { get; set; }

            public string SoC
            { get; set; }

            public double delta()
            {
                delta167 = b167 * b167 - 4 * a167 * c167;
                return delta167;
            }

            public void Nghiem()
            {
                double d = delta();

                if (d >0 )
                {
                    x1167 = (-b167 + Math.Sqrt(d) / (2 * a167));
                    x2167 = (-b167 - Math.Sqrt(d) / (2 * a167));
                    Console.WriteLine("x1 = {0}  va x2 = {1}", x1167, x2167);
                }
                else if (d == 0)
                {
                    Console.WriteLine("1 nghiem x = {0}", (-b167 / 2 * a167));
                }
                else
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
            }

        }
            static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }
}
