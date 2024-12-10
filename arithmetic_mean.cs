            int[] chisla = new int[4];
            {
                chisla[0] = Convert.ToInt32(Console.ReadLine());
                chisla[1] = Convert.ToInt32(Console.ReadLine());
                chisla[2] = Convert.ToInt32(Console.ReadLine());
                chisla[3] = Convert.ToInt32(Console.ReadLine());
            }


            double arifSred = chisla.Average();

            Console.WriteLine("Среднее арифмитическое : " + arifSred);

            Console.ReadKey();
