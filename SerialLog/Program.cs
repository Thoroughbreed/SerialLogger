using System;
using System.IO;
using System.IO.Ports;

namespace SerialLog
{
    class Program
    {
        static SerialPort inputPort = new SerialPort("COM3", 115200, Parity.None, 8, StopBits.One);
        static string fileName = "eventlog.txt";
        static void Main(string[] args)
        {
            inputPort.Open();
            while (true)
            {
                string serialInput = inputPort.ReadLine();
                if (!string.IsNullOrWhiteSpace(serialInput))
                {
                    Console.WriteLine(serialInput);
                    File.AppendAllText(fileName, serialInput);
                }
            }
        }
    }
}