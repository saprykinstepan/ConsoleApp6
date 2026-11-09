using System;
// Подключаем пространства имен всех двух библиотек (.DLL)
using LabLibrary6_Task1;
using LabLibrary6_Task2;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n=== ЛАБОРАТОРНАЯ РАБОТА № 6 (ВАРИАНТ 3) ===");
                Console.WriteLine("1. Задание 1: Однородная коллекция List<T>.");
                Console.WriteLine("2. Задание 2: Разнородная коллекция List<Teacher>.");
                Console.WriteLine("0. Выход.");
                Console.Write("Выберите номер задания [0-2]: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            UniformListDemo task1 = new UniformListDemo();
                            task1.RunTask1();
                            break;
                        case 2:
                            TeacherCollectionManager task2 = new TeacherCollectionManager();
                            task2.RunTask2();
                            break;
                        case 0:
                            Console.WriteLine("Выход из программы.");
                            break;
                        default:
                            Console.WriteLine("Неверный номер задания. Попробуйте снова.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите число от 0 до 2.");
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }

            } while (choice != 0);
        }
    }
}
