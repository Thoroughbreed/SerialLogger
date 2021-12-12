using System;
using System.IO;
using System.IO.Ports;

namespace SerialLog
{
    class Program
    {
        private static ConsoleKeyInfo inputKey;
        private static bool brk;
        private static string fileName = "eventlog.txt";
        private static string C = "COM3";
        private static int B = 115200;
        private static int _p;
        private static int D = 8;
        private static int _s = 1;
        private static Parity P;
        private static StopBits S;

        static void Main(string[] args)
        {
            if (!args.IsNullOrEmpty())
            {
                if (args.Length > 0) fileName = args[0];
                if (args.Length > 1) C = "COM" + args[1];
                if (args.Length > 2) int.TryParse(args[2], out B);
                if (args.Length > 3) int.TryParse(args[3], out _p);
                if (args.Length > 4) int.TryParse(args[4], out D);
                if (args.Length > 5) int.TryParse(args[5], out _s);
            }

            P = (Parity)_p;
            S = (StopBits)_s;

            try
            {
                var inputPort = new SerialPort(C, B, P, D, S);
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Continue()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Filename\tPort\tBAUD\tParity\tData- \tStop bit");
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", fileName, C, B, P, D, S);
                Console.WriteLine("Do you want to continue with those values?");
                Console.WriteLine("[Y]es or [N]o");
                inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Y || inputKey.Key == ConsoleKey.N) brk = true;
            } while (brk == false);
        }

        static void ChangeValues()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Which attribute do you wish to change?");
                Console.WriteLine("(Press X to leave values as is)");
                Console.WriteLine(
                    "[F]ilename ({0})\n[C]OM-port ({1})\n[B]AUD-rate ({2})\n[P]arity bit ({3})\n[D]ata bits ({4})\n[S]top bit ({5})"
                    , fileName, C, B, P, D, S);
                inputKey = Console.ReadKey(true);
                switch (inputKey.Key)
                {
                    case ConsoleKey.F:
                        Console.WriteLine("Enter new filename (leave blank to keep it)");
                        string _input = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(_input))
                        {
                            fileName = _input;
                        }
                        break;
                    case ConsoleKey.C:
                        break;
                    case ConsoleKey.B:
                        break;
                    case ConsoleKey.P:
                        break;
                    case ConsoleKey.D:
                        break;
                    case ConsoleKey.S:
                        break;
                    case ConsoleKey.X:
                        brk = true;
                        break;
                }
            } while (brk == false);
        }
    }
}