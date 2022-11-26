using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4Practice4
{
    /// <summary>
    /// Предоставляет функционал для работы с матрицами
    /// </summary>
    internal class ArrayMechanics
    {
        /*
         * Данный метод не относится к работе с матрицами и по-хорошему его 
         * необходимо выделять в отдельный класс
         */
        /// <summary>
        /// Проверяет корректность ввода целого числа и возвращает его значение
        /// </summary>
        /// <returns>Целочисленный результат пользовательского ввода</returns>
        public static int InputNumberCheck()
        {
            bool userInputCheck;
            int correctInput;

            do
            {
                Console.WriteLine("Введите целое число: ");
                string userInput = Console.ReadLine().ToString();
                userInputCheck = int.TryParse(userInput, out correctInput);

            } while (!userInputCheck);

            return correctInput;
        }

        /// <summary>
        /// Создание и наполнение матрицы целыми числами
        /// </summary>
        /// <param name="rowNumbers">Количество строк</param>
        /// <param name="colNumbers">Количество столбцов</param>
        /// <returns>Возвращает матрицу заполненную целыми числами в диапазоне от -100 до 100</returns>
        public static int[,] Array2DGenerator(int rowNumbers, int colNumbers)
        {
            // Random random = new Random(); // VS 2022 предложил более простую конструкцию ниже
            Random random = new();
            int[,] array = new int[rowNumbers, colNumbers];

            for (int rowIndex = 0; rowIndex < rowNumbers; rowIndex++)
            {
                for (int colIndex = 0; colIndex < colNumbers; colIndex++)
                {
                    array[rowIndex, colIndex] = random.Next(-100, 101);
                }
            }

            return array;
        }

        /// <summary>
        /// Выводит в консоль значения матрицы
        /// </summary>
        /// <param name="arrayToDraw">Матрица для отображения</param>
        public static void DrawArray(int[,] arrayToDraw)
        {

            for (int rowIndex = 0; rowIndex < arrayToDraw.GetLength(0); rowIndex++)
            {
                Console.WriteLine();
                for (int colIndex = 0; colIndex < arrayToDraw.GetLength(1); colIndex++)
                {
                    Console.Write($"{arrayToDraw[rowIndex, colIndex],4}");
                }

            }
        }

        /// <summary>
        /// Выводит в консоль значения матрицы и возвращает сумму элементов
        /// </summary>
        /// <param name="arrayToDraw">Матрица для отображения</param>
        /// <param name="sum">Сумма всех элементов матрицы</param>
        public static void DrawArray(int[,] arrayToDraw, out int sum)
        {
            sum = 0;

            for (int rowIndex = 0; rowIndex < arrayToDraw.GetLength(0); rowIndex++)
            {
                Console.WriteLine();
                for (int colIndex = 0; colIndex < arrayToDraw.GetLength(1); colIndex++)
                {
                    Console.Write($"{arrayToDraw[rowIndex, colIndex],4}");
                    sum += arrayToDraw[rowIndex, colIndex];
                }

            }
        }

    }
}
