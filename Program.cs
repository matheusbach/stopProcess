using System;
using System.Diagnostics;

namespace stopProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("process name: ");
                Process[] pname = Process.GetProcessesByName(Console.ReadLine());

                Console.WriteLine("Option - 1 killl - 2 close - 3 dispose ");

                switch (Convert.ToInt16(Console.ReadLine()))
                {
                    case 1:
                        {
                            foreach (Process process in pname)
                            {
                                process.Kill(true);
                            }
                        } break;
                    case 2:
                        {
                            foreach (Process process in pname)
                            {
                                process.Close();
                            }
                        }
                        break;
                    case 3:
                        {
                            foreach (Process process in pname)
                            {
                                process.Dispose();
                            }
                        }
                        break;
                }
            }
        }
    }
}
