using System;
using Raspberry.IO.GeneralPurpose;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var led1 = ConnectorPin.P1Pin11.Output();
            var connection = new GpioConnection(led1);
            for (var i = 0; i < 100; i++)
            {
                connection.Toggle(led1);
                System.Threading.Thread.Sleep(250);
            }
            connection.Close();
        }
    }
}
