using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace M4Practice4
{
    /// <summary>
    /// Практическое задание 4. Работа с двумерными массивами (матрица)
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка старта
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Практическое работа 4.");
            // Задание 1, создание матрицы и  вывод в консоль значений элементов, а также суммы всех элементов
            Console.WriteLine("Задание 1.Создание случайной матрицы");
            Console.WriteLine("Введите количество строк в матрице");
            int rowsArray = ArrayMechanics.InputNumberCheck();
            Console.WriteLine("Введите количество столбцов в матрице");
            int colArray = ArrayMechanics.InputNumberCheck();

            int[,] firstArray = ArrayMechanics.Array2DGenerator(rowsArray, colArray);

            // рисуем матрицу
            ArrayMechanics.DrawArray(firstArray, out int sumElementsArray);

            // вывод суммы элементов
            Console.WriteLine($"\nСумма элементов матрицы: {sumElementsArray}");
            Console.ReadKey(true);
            Console.Clear();

            // Задание 2 сложение двух матриц
            Console.WriteLine("Практическое работа 4.");
            Console.WriteLine("Задание 2.Сложение матриц");
            Console.WriteLine("Используем размерность и матрицу из первого задания");

            int[,] secondArray = ArrayMechanics.Array2DGenerator(rowsArray, colArray);

            //рисуем матрицы
            Console.WriteLine("\nПервая матрица");
            ArrayMechanics.DrawArray(firstArray);
            Console.WriteLine("\n\nВторая матрица");
            ArrayMechanics.DrawArray(secondArray);
            Console.WriteLine("\n\nРезультирующая матрица:");

            // вывод на экран результат сложения матриц
            for (int rowsIndex = 0; rowsIndex < rowsArray; rowsIndex++)
            {
                Console.WriteLine();
                for (int colIndex = 0; colIndex < colArray; colIndex++)
                {
                    int twoArraySumElements = firstArray[rowsIndex, colIndex] + secondArray[rowsIndex, colIndex];
                    Console.Write($"{twoArraySumElements, 4}");
                }

            }
            Console.ReadKey(true);

        }

        
    }
}