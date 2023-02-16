using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер задания: ");
            int question = Int32.Parse(Console.ReadLine());
            if (question <= 4)
            {
                Quest findAnswer = new Quest(question);
                findAnswer.Start();
            }
            else
            {
                Console.WriteLine("Такого задания не существует!");
                Main();
            }
        }
    }
}
