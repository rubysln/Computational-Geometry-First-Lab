using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Quest
    {
        private int ax, ay, bx, by, cx, cy, dx, dy;
        private int question;

        public Quest(int question)
        {
            this.question = question;
        }

        public void Start() 
        {
            switch (question)
            {
                case 1:
                    FindAnswerForFirstOrSecondQuestion(question);
                    break;
                case 2:
                    FindAnswerForFirstOrSecondQuestion(question);
                    break;
                case 3:
                    FindAnswerForThirdOrFourthQuestion(question);
                    break;
                default:
                    FindAnswerForThirdOrFourthQuestion(question);
                    break;
            }
        }

        private void FindAnswerForFirstOrSecondQuestion(int numberOfQuestion)
        {
            Console.WriteLine("Введите координаты точки A:");
            string[] lineSplit = Console.ReadLine().Split(',', ' ');
            try
            {
                this.ax = int.Parse(lineSplit[0]);
                this.ay = int.Parse(lineSplit[1]);
            }
            catch
            {
                Console.WriteLine("Вы ввели неккоректные значения!");
                FindAnswerForFirstOrSecondQuestion(numberOfQuestion);
            }
            Console.WriteLine("Введите координаты точки B:");
            lineSplit = Console.ReadLine().Split(',', ' ');
            try
            {
                this.bx = int.Parse(lineSplit[0]);
                this.by = int.Parse(lineSplit[1]);
            }
            catch
            {
                Console.WriteLine("Вы ввели неккоректные значения!");
                FindAnswerForFirstOrSecondQuestion(numberOfQuestion);
            }
            Console.WriteLine("Введите координаты точки C:");
            lineSplit = Console.ReadLine().Split(',', ' ');
            try
            {
                this.cx = int.Parse(lineSplit[0]);
                this.cy = int.Parse(lineSplit[1]);
            }
            catch
            {
                Console.WriteLine("Вы ввели неккоректные значения!");
                FindAnswerForFirstOrSecondQuestion(numberOfQuestion);
            }

            if(numberOfQuestion == 1)
            {
                if (((cy - ay) / (by - ay)) == ((cx - ax) / (bx - ax)))
                {
                    Console.WriteLine("Точки лежат на одной прямой!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Точки не лежат на одной прямой!");
                    Console.ReadKey();
                }
            }
            else
            {
                if(((bx - ax) * (cy - ay) - (cx - ax) * (by - ay)) < 0)
                {
                    Console.WriteLine("Обход по часовой стрелке!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Обход не по часовой стрелке!");
                    Console.ReadKey();
                }
            }
        }

        private void FindAnswerForThirdOrFourthQuestion(int numberOfQuestion)
        {
            Console.WriteLine("Введите координаты точки A:");
            string[] lineSplit = Console.ReadLine().Split(',', ' ');
            try
            {
                this.ax = int.Parse(lineSplit[0]);
                this.ay = int.Parse(lineSplit[1]);
            }
            catch
            {
                Console.WriteLine("Вы ввели неккоректные значения!");
                FindAnswerForThirdOrFourthQuestion(numberOfQuestion);
            }
            Console.WriteLine("Введите координаты точки B:");
            lineSplit = Console.ReadLine().Split(',', ' ');
            try
            {
                this.bx = int.Parse(lineSplit[0]);
                this.by = int.Parse(lineSplit[1]);
            }
            catch
            {
                Console.WriteLine("Вы ввели неккоректные значения!");
                FindAnswerForThirdOrFourthQuestion(numberOfQuestion);
            }
            Console.WriteLine("Введите координаты точки C:");
            lineSplit = Console.ReadLine().Split(',', ' ');
            try
            {
                this.cx = int.Parse(lineSplit[0]);
                this.cy = int.Parse(lineSplit[1]);
            }
            catch
            {
                Console.WriteLine("Вы ввели неккоректные значения!");
                FindAnswerForThirdOrFourthQuestion(numberOfQuestion);
            }
            Console.WriteLine("Введите координаты точки D:");
            lineSplit = Console.ReadLine().Split(',', ' ');
            try
            {
                this.dx = int.Parse(lineSplit[0]);
                this.dy = int.Parse(lineSplit[1]);
            }
            catch
            {
                Console.WriteLine("Вы ввели неккоректные значения!");
                FindAnswerForThirdOrFourthQuestion(numberOfQuestion);
            }

            if(tryABC() && tryBCD() && tryCDA() && tryDAB())
            {
                Console.WriteLine("Четырёхугольник выпуклый! Следовательно AC и BD пересекаются!");
                Console.ReadKey();
            }
            else if(!tryABC() && !tryBCD() && !tryCDA() && !tryDAB())
            {
                Console.WriteLine("Четырёхугольник выпуклый! Следовательно AC и BD пересекаются!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Четырёхугольник впуклый! Следовательно AC и BD не пересекаются!");
                Console.ReadKey();
            }
        }

        private bool tryABC()
        {
            return (bx - ax) * (cy - ay) - (cx - ax) * (by - ay) < 0;
        }

        private bool tryBCD()
        {
            return (cx - bx) * (dy - by) - (dx - bx) * (cy - by) < 0;
        }

        private bool tryCDA()
        {
            return (dx - cx) * (ay - cy) - (ax - cx) * (dy - cy) < 0;
        }

        private bool tryDAB()
        {
            return (ax - dx) * (by - dy) - (bx - dx) * (ay - dy) < 0;
        }
    }
}
