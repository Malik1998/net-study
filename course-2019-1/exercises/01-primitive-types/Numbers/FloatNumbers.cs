﻿/*
    Здесь все то же самое.
*/

using System;

namespace Numbers
{
    public static class FloatNumbers
    {
        /// <summary>
        /// Возвращает вещественнозначное число со значением "не число" (Not a number).
        /// </summary>
        internal static double GetNaN()
        {
            /*
                Необходимо вернуть значение, не используя непосредственно саму константу.
                Для этого подумай, какой смысл в себе несет эта константа и где бы она могла стать результатом операции или вычисления функции.
            */
            return 0.0 / 0.0;
        }

        /// <summary>
        /// Возвращает результат проверки, имеет ли указанное вещественнозначное число значение "не число" (Not a number).
        /// </summary>
        /// <param name="d">Проверяемое вещественнозначное число.</param>
        /// <returns>True, если число имеет значение "не число", иначе false.</returns>
        internal static bool IsNaN(double d)
        {
            // Подсказка: по аналогии с константами типа int, у типа double тоже есть свой набор констант.
            return Double.IsNaN(d); 
        }
        
        /// <summary>
        /// Возвращает результат сравнения двух вещественнозначных чисел.
        /// </summary>
        /// <returns>-1 - первое меньше второго, 0 - значения равны, 1 - первое больше второго.</returns>
        internal static int Compare(double a, double b)
        {
            /*
                Подумай, почему это задание дано в части про вещественнозначные числа. И почему не дана полная сигнатура метода.
                Если сходу идей нет, перестань искать подвох и просто реализуй дословно. Теперь еще раз посмотри на код и подумай в чем может быть проблема, сколько должно быть аргументов.
            */

            if (b - a > Double.Epsilon)
            {
                return -1;
            } else if (a - b > Double.Epsilon)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // и все?!! О_о


        // и все... -_-
    }
}