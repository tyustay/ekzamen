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
            // ��������� ����������
            int x = 10;
            int y = 20;
            int expected = 30; // �������� ���������
            // ���������� �������� ��� ����������� ��������
            SWAG c = new SWAG();
            int actual = c.Sum(x, y);
            // ����������� ��� �� ������������ ���������� �����
            Assert.AreEqual(expected, actual);
        }
    }
}