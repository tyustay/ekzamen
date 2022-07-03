using NUnit.Framework;
using MyClassLib;

namespace ClassLib
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_10and20_return()
        {
            // настройка переменных
            int x = 10;
            int y = 20;
            int expected = 30; // желаемый результат
            // выполнение действий над тестируемой системой
            SWAG c = new SWAG();
            int actual = c.Sum(x, y);
            // павильность или не правильность выполнения теста
            Assert.AreEqual(expected, actual);
        }
    }
}