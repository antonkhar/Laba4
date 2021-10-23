using System;

namespace Laba4._1
{
    /*Описать структуру с именем MARSH, содержащую следующие поля:
    • название начального пункта маршрута;
    • название конечного пункта маршрута;
    • номер маршрута.
    Написать программу, выполняющую следующие действия:
    • ввод с клавиатуры данных в массив, состоящий из восьми элементов типа MARSH (записи
    должны быть упорядочены по номерам маршрутов);
    • вывод на экран информации о маршруте, номер которого введен с клавиатуры (если таких
    маршрутов нет, вывести соответствующее сообщение).*/
    class Program
    {
        static void Main(string[] args)
        {
            int tempNomber; //Временная переменная для поля number
            string tempStart; //Временная переменная для поля start
            string tempFinish; //Временная переменная для поля finish
            bool ColorChek = false; //Переменная для поочередной смены цвета текста
            bool ChekNumber = false; // Переменная для проверки появления или непоявления существующего у одного из обьектов номера
            MARSH[] array = new MARSH[4]; // Обьявление массива из 8-ми обьектов структуры MARSH

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < array.Length; i++) // Поочередный ввод параметров всех обьектов массива
                {
                    Console.WriteLine("Введите номер маршрута (от 1 до 999)");
                    array[i].Number = int.Parse(Console.ReadLine());
                    if (i > 0)
                    {
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (array[j].Number == array[i].Number)
                            {
                                throw new NumberRepetitionException();
                            }
                        }
                    }
                    Console.WriteLine("Введите начальный пункт маршрута");
                    array[i].Start = Console.ReadLine();
                    Console.WriteLine("Введите конечный пункт маршрута");
                    array[i].Finish = Console.ReadLine();

                    if (ColorChek == false) //Проверка смены цвета
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        ColorChek = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        ColorChek = false;
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i].Number > array[j].Number)
                        {
                            tempNomber = array[i].Number;
                            tempStart = array[i].Start;
                            tempFinish = array[i].Finish;

                            array[i].Number = array[j].Number;
                            array[i].Start = array[j].Start;
                            array[i].Finish = array[j].Finish;

                            array[j].Number = tempNomber;
                            array[j].Start = tempStart;  
                            array[j].Finish = tempFinish;
                        }
                    }
                }
                Console.WriteLine("Отсортированный список маршрутов");
                for (int i = 0; i < array.Length; i++) // Сортировка обьектов по номерам в порядке возрастания
                {
                    Console.WriteLine(array[i].Number);
                    Console.WriteLine(array[i].Start);
                    Console.WriteLine(array[i].Finish);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите номер маршрута, информацию о котором вы хотите получить");
                tempNomber = int.Parse(Console.ReadLine());

                for (int i = 0; i < array.Length; i++) //Выведение информации о маршруте, или сообщения об отсутствии такого маршрута
                {
                    if (array[i].PrintInfo(tempNomber))
                    {
                        ChekNumber = true;
                    }
                }
                if (ChekNumber == false)
                {
                    Console.WriteLine("Маршрута с таким номером не существует!");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
