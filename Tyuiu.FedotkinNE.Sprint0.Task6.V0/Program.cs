using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FedotkinNE.Sprint0.Task6.V0.Lib;
namespace Tyuiu.FedotkinNE.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма Элементов Массива = " +  DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность Элементов Массива = " + DataService.SubstractionArray(arraynums));
            Console.WriteLine("Произведение Элементов Массива = " + DataService.MultiplicationArray(arraynums));
            Console.ReadKey();

        }
    }
}
