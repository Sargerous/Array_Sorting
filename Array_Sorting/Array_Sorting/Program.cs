using System;

namespace Array_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Массив из кода
            //int[] arr = new int[7] {2, 1, 3, 55, 21, 44, 8};
            #endregion

            #region Массив с клавиатуры
            // Считывание массива с клавиатуры. Проверок нету, но и по условию они не нужны.
            Console.Write("Введите ширину массива: "); 
            int x = int.Parse(Console.ReadLine());
            int[] arr = new int[x];
            Console.WriteLine("Введите числа в массиве: ");
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            #endregion

            // Показ массива и счёт нечётных чисел.
            Console.Write("Введённый массив: ");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                if (arr[i] % 2 != 0)
                    count++;
            }




            // Сортировка массива по двум массивам: чётный и нечётный.
            int[] oddArr = new int[count];
            int[] evenArr = new int[arr.Length - count];
            int oddCount = 0;
            int evenCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[evenCount] = arr[i];
                    evenCount++;
                }
                if (arr[i] % 2 != 0)
                {
                    oddArr[oddCount] = arr[i];
                    oddCount++;
                }
            }

            // Сортировка двух массивов.
            Array.Sort(evenArr);
            Array.Sort(oddArr);
            // Переворот массива с нечётными числами.
            Array.Reverse(oddArr);

            // Соеднинение двух массивов в один.
            for (int i = 0; i < evenArr.Length; i++)
                arr[i] = evenArr[i];
            for (int i = 0; i < oddArr.Length; i++)
                arr[evenArr.Length + i] = oddArr[i];

            // Вывод полученного массива.
            Console.WriteLine();
            Console.Write("Вывод массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
