using System;

namespace MyClassLib
{
    public class SWAG //метод не возвращающий значения
    {
        static public void Pause() //функция
        {
            Console.ReadKey();
        }

        static public void Pause(string str) // пергрузка (функция с тем же названием. но с другими параметрами)
        {
            Console.WriteLine(str);
            Console.ReadKey();

        }
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }//далее добавляем новый проект
}
