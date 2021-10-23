using System;
using System.Text.RegularExpressions;

namespace Laba4._1
{
    ///<summary>
    /// Структура, позволяющая описать обьект, имеющий номер, начальный пункт и конечный пункт
    ///</summary>
    ///<returns>
    /// Object
    ///</returns>
    ///<code>
    /// <see cref="MARSH"/> bus
    /// bus.<see cref="start"/> = Кемерово
    /// bus.<see cref="finish"/> = Новгород
    /// bus.<see cref="number"/> = 109
    ///</code>
    ///<param>
    /// <see cref="start"/> - начальный пункт маршрута
    /// <see cref="finish"/> - конечный пункт маршрута 
    /// <see cref="number"/> - номер
    ///</param>
    struct MARSH
    {
        private string start; //Начальный пункт маршрута
        private string finish; //Конечный пункт маршрута
        private int number; //Номер маршрута

        public string Start
        {
            get
            {
                return start;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new NullException();
                }
                else if (Regex.IsMatch(value, @"^[\*\-\\\=\%\$\#\@\!\|\?]+$"))
                {
                    throw new TextException();
                }
                else
                {
                    start = value;
                }
                
            }
        }
        public string Finish
        {
            get
            {
                return finish;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new NullException();
                }
                else if (Regex.IsMatch(value, @"^[\*\-\\\=\%\$\#\@\!\|\?]+$"))
                {
                    throw new TextException();
                }
                else
                {
                    finish = value;
                }

            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value > 999 || value < 1)
                {
                    throw new NumberOverflowException();
                }
                else
                {
                    number = value;
                }

            }
        }
        ///<summary>
        /// Функция для вывода информации об обьекте структуры (по номеру) <see cref="MARSH"/>, а так же для проверки на совпадение номера в массиве элементов
        ///</summary>
        ///<returns>
        /// bool: true - если значение выведено, false - если значение не выведено
        ///</returns>
        ///<param>
        /// Номер обьекта, информацию по которому необходимо получить
        ///</param>
        public bool PrintInfo(int NomberKey)
        {
            if (number == NomberKey)
            {
                Console.WriteLine($"Начальный пункт: {Start}  Конечный пункт: {Finish}  Номер: {Number}");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
