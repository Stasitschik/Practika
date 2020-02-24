using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Library lib = null;
            do
            {
                Console.Write("Меню:\n1) Создать новый объект \n2) Установить атрибуты текущего обьекта \n3) Вывести информацию о library \n4) Выйти \n\nВаше решение: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("\n1) Cоздать с помощью пользовательского конструктора \n2) Создать по умолчанию \n\nВаше решение: ");
                            int F = Convert.ToInt32(Console.ReadLine());
                            string name = new string(' ', 20), adr = new string(' ', 20);
                            int year;
                            if (F == 1)
                            {
                                Console.Write("Введите название библиотеки ");
                                name = Console.ReadLine();
                                Console.Write("Введите адресс библиотеки ");
                                adr = Console.ReadLine();
                                Console.Write("Введите год открытия библиотеки ");
                                year = Convert.ToInt32(Console.ReadLine());
                                lib = new Library(name, adr, year);
                                Console.WriteLine("Обьект создан");
                            }
                            else if (F == 2)
                            {
                                lib = new Library();
                                Console.WriteLine("Обьект создан");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (lib != null)
                            {
                                string name = new string(' ', 20), adr = new string(' ', 20);
                                int year;
                                Console.Write("Введите название библиотеки ");
                                name = Console.ReadLine();
                                Console.Write("Введите адресс библиотеки ");
                                adr = Console.ReadLine();
                                Console.Write("Введите год открытия библиотеки ");
                                year = Convert.ToInt32(Console.ReadLine());
                                lib.Name = name;
                                lib.Address = adr;
                                lib.Year = year;
                                Console.WriteLine("Обьект успешно изменен");
                            }
                            else
                            {
                                Console.WriteLine("Вы забыли создать объект");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (lib != null)
                            {
                                lib.GetInfo();
                            }
                            else
                            {
                                Console.WriteLine("Вы забыли создать объект");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Выход...");
                            break;
                        }
                    default:
                        Console.WriteLine("Вы что-то другое нажали...");
                        break;
                }
                Console.Write("\n\nНажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            }
            while (i != 4);
        }
    }
}
