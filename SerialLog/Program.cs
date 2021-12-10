using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;

namespace SerialLog
{
    class Program
    {
        static SerialPort inputPort;
        static string fileName = "eventlog.txt";
        static string COM = "COM3";
        static int BAUD = 115200;
        static int _parity = 0;
        static Parity PARITY;
        static int DATABITS = 8;
        static int _stopbit = 1;
        static StopBits STOPBIT;
        static void Main(string[] args)
        {
            if (args.Length > 4)
            {
                fileName = args[0];
                COM = args[1];
                int.TryParse(args[2], out BAUD);
                int.TryParse(args[3], out _parity);
                int.TryParse(args[4], out DATABITS);
                int.TryParse(args[5], out _stopbit);
            }
            PARITY = (Parity)_parity;
            STOPBIT = (StopBits)_stopbit;

            inputPort = new SerialPort(COM, BAUD, PARITY, DATABITS, STOPBIT);
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