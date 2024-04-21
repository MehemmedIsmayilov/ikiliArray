using System;

namespace arrayRowColmn
{
    class Program
    {
        static void Main(string[] args)
        {




            //int[,] arr1 =
            //{
            //    {100,200,300 },
            //    {10,20,30 }
            //};


            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int y = 0; y < arr1.GetLength(1); y++)              // print etmek
            //    {
            //        Console.Write(arr1[i,y] + " ");
            //    }
            //}


            //int sum = 0;
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)             // toplamaq
            //    {
            //        sum += arr1[i, j];

            //    }
            //}
            //Console.WriteLine(sum);


            //int sum1 = 0;

            //for (int i = 0; i < arr1.GetLength(0); i++)                  // column toplama
            //{

            //    sum1 += arr1[i, 0];

            //}
            //Console.WriteLine(sum1);


            int[,] arr2 =
{
                {-100,200,300 },
                {10,20,-33 }
            };



            //int sum2 = 0;

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)                  // menfi ededleri tapmaq
            //    {
            //        if (0 > arr2[i, j])
            //        {
            //            sum2 += arr2[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine(sum2);





            //int boyuk = 0;
            //int kicik = 0;

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{

            //    for (int l = 0; l < arr2.GetLength(1); l++)
            //    {
            //        if (i==0)
            //        {                                                             // en boyuk ve en kicik ededler
            //            boyuk = arr2[i,l];
            //            kicik = arr2[i,l];
            //        }
            //        if (arr2[i,l] > boyuk)
            //        {
            //            boyuk = arr2[i, l];

            //        }
            //        if (arr2[i, l] < kicik)
            //        {
            //            kicik = arr2[i, l];
            //        }
            //    }
            //}



            //Console.WriteLine(boyuk+" "+kicik);




            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        if (arr2[i, j] > 0)
            //        {
            //            if (arr2[i, j] % 2 == 0)
            //            {
            //                arr2[i, j] = 2;

            //            }
            //            else if (arr2[i, j] % 2 == 1)                             // menfi musbet ededlerin 2 ve 1 e cevrilmesi
            //            {
            //                arr2[i, j] = 1;
            //            }
            //        }
            //        else if (arr2[i,j] == 0)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            if (arr2[i, j] % 2 == 0)
            //            {
            //                arr2[i, j] = -2;

            //            }
            //            else if (arr2[i, j] % 2 == -1)
            //            {
            //                arr2[i, j] = -1;
            //            }
            //        }


            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}






            int[,] arrx =
            {
                {2,3,4,8},
                {5,6,7,9},
                {6,3,8,1 },
                {7,9,3,2 }
            };


            //for (int i = 0; i < arrx.GetLength(0); i++)                 // ucuncu sutunu sifira cevirmek
            //{
            //    arrx[i, 2] = 0;
            //    for (int j = 0; j < arrx.GetLength(1); j++)
            //    {
            //        Console.Write(arrx[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}




            //for (int i = 0; i < arrx.GetLength(0); i++)
            //{

            //    for (int j = 0; j < arrx.GetLength(1); j++)                  // ikinci setiri sifira cevirme
            //    {
            //        if (i==1)
            //        {
            //            arrx[i, j] = 0;

            //        }

            //    }
            //}
            //for (int i = 0; i < arrx.GetLength(0); i++)
            //{

            //    for (int j = 0; j < arrx.GetLength(1); j++)
            //    {
            //        Console.Write(arrx[i,j] + " ");

            //    }
            //    Console.WriteLine();
            //}



            int[,] diagonal =
            {
                {10,20,30 },
                {40,50,60 },
                {70,80,90 }
            };

            int sum = 0;
            int sum2 = 0;

            for (int i = 0; i < diagonal.GetLength(0); i++)
            {
                for (int j = 0; j < diagonal.GetLength(1); j++)
                {
                    sum += diagonal[i, j];
                    
                   

                }
                Console.WriteLine(sum);
            }
            









        }
    }
}
