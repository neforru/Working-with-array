        static public void Main()
        {

            int[] chisla = new int[4];
            {
                chisla[0] = Convert.ToInt32(Console.ReadLine());
                chisla[1] = Convert.ToInt32(Console.ReadLine());
                chisla[2] = Convert.ToInt32(Console.ReadLine());
                chisla[3] = Convert.ToInt32(Console.ReadLine());
            }

            int max = Int32.MinValue;
            
            for (int i = 0; i < chisla.Length; i++)
            {
                if (chisla[i] > max)
                {
                    max = chisla[i];
                }
            }
            
            Console.WriteLine("Максимальное число : " + max);

            foreach (int item in chisla)
            {
                Console.WriteLine("Числа из массива : " + item);
            }

            Console.ReadKey();

        }
