using System;
using System.IO.Ports;

namespace SerialLog
{
    class Program
    {
        public SerialPort inputPort = new SerialPort("COM3", 115200, Parity.None, 8, StopBits.None);
        public void Main(string[] args)
        {
            if (inputPort == null) return;
            inputPort.ReadTimeout = 2000;
            inputPort.Open();
            while (true)
            {
                string serialInput = inputPort.ReadLine();
                if (!string.IsNullOrWhiteSpace(serialInput))
                {
                    Console.WriteLine(serialInput);
                }
            }
        }
    }
}