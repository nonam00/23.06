using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._06
{
    internal class Program
    {
        static void Task1(char simbol, int lenghth)
        {
            if (lenghth <= 0)
                throw new ArgumentException("Длина стороны не может быть меньше или равна 0");
            else if (lenghth == 1)
                Console.WriteLine(simbol);
            else
            {
                string res = String.Empty; //создание пустой строковой переменной для вывода результата

                string temp = String.Empty; //создание пустой строковой переменной для хранения строки, необходимой для вывода верней и нижней стороны
                for (int i = 0; i < lenghth; i++) //заполнение переменной, содержащей в себе верхнюю/нижнюю сторону
                    temp += simbol;

                res += temp + "\n"; //добавление верхней стороны

                for(int i=1; i<lenghth-1; i++) //формирование боковых сторон
                {
                    res += simbol; //добавление части левой стороны
                    for(int j=1; j<lenghth-1; j++) //пустое пространство между сторонами
                        res += " ";
                    res += simbol + "\n"; //добавление части правой стороны и перенос строки
                }

                res += temp; //добавление нижней стороны
                Console.WriteLine(res);
            }
        }
        static bool Task2(int number)
        {
            string temp = Convert.ToString(number); //перевод числа в формат строки
            temp.Reverse(); //разворот строки
            return temp == Convert.ToString(number); //сравнение исходной строки и развёрнутой
        }

        static int[] Task3(int[] oldArray, int[] filterArray)
        {
            return oldArray.Where(p => !filterArray.Contains(p)).ToArray(); //про метод услышал на уроке и сразу проверил в visual studio, что он делает;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберете задание:\n");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Task1('*', 6);
                        break;
                    case 2:
                        Console.WriteLine(Task2(121));
                        break;
                    case 3:
                        int[] arr = Task3(new int[] {1,2,3,4,5,6,7}, new int[] { 3, 6 });
                        Array.ForEach(arr, x => { Console.Write(x + " "); }); //вывод для удобства
                        Console.WriteLine();
                        break;
                    default:
                        throw new Exception("Такого задания не существует");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
