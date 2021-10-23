using System;

namespace Laba4._1
{
    class NumberRepetitionException : Exception
    {
        ///<summary>
        /// Выбрасывается при совпадении номеров у 2-х разных обьектов
        ///</summary>
        public NumberRepetitionException()
            {
                Console.WriteLine("Не может быть двух маршрутов с одним номером!");
            }
    }
    class NumberOverflowException : Exception
    {
        ///<summary>
        /// Выбрасывается при введении в поле number числа не лежащего в диапозоне от 1 до 999
        ///</summary>
        public NumberOverflowException()
        {
            Console.WriteLine("Номер маршрута должен лежать в пределах от 1 до 999");
        }
    }
    class NullException : Exception
    {
        ///<summary>
        /// Выбрасывается при введении в поле start или finish пустого значения
        ///</summary>
        public NullException()
        {
            Console.WriteLine("Данное поле не может быть пустым!");
        }
    }
    class TextException : Exception
    {
        ///<summary>
        /// Выбрасывается при введении в поле start или finish пустого значения
        ///</summary>
        public TextException()
        {
            Console.WriteLine("Название не может содержать одного из введенных элементов");
        }
    }
}
