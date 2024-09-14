using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FedotkinNE.Sprint0.Task7.V0.Lib;
namespace Tyuiu.FedotkinNE.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема:  Создания итогового решения по спринту                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Федоткин Никита Евгеньевич | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длине                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] ArrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение Элементов массива номер 1");
            for (int i = 0; i < ArrayNums1.Length; i++)
            {
                Console.WriteLine(ArrayNums1[i] + ", ");
            }
            Console.WriteLine();
            int[] ArrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива номер 2");
            for (int i = 0;i < ArrayNums2.Length; i++)
            {
                Console.WriteLine(ArrayNums2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (ArrayNums1.Length == ArrayNums2.Length)
            {
                int[] ResultArray = DataService.AdditionArrays(ArrayNums1, ArrayNums2 );
                Console.WriteLine("Сумма Элементов Массива равна: ");
                for (int i = 0; i < ResultArray.Length; i++)
                {
                    Console.WriteLine(ResultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}
