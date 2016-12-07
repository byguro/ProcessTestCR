using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = Problem1();
            Console.WriteLine("RESUT -1\n"+result1);

            var result2 = Problem2();
            Console.WriteLine("RESUT -2\n"+result2);
        }

        public static string Problem1()
        {
            ProcessStartInfo _startInfo = new ProcessStartInfo();
            Process p = new Process();
            StringBuilder outputStringBuilder = new StringBuilder();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\PC-KIMMO\pckimmo32.exe";
            var file = new FileInfo(filePath);

            p.StartInfo = _startInfo;
            _startInfo.UseShellExecute = false;
            _startInfo.RedirectStandardOutput = true;
            _startInfo.RedirectStandardInput = true;
            _startInfo.WorkingDirectory = file.Directory.FullName;
            _startInfo.FileName = file.FullName;
            p.OutputDataReceived += (sender, eventArgs) => outputStringBuilder.AppendLine(eventArgs.Data);
            p.Start();
            p.BeginOutputReadLine();
            var myWriter = p.StandardInput;
            myWriter.AutoFlush = true;
            myWriter.WriteLine("synthesize kitap +Noun +A3sg +P2sg +Loc");
            myWriter.Close();

            p.WaitForExit();
            var output = outputStringBuilder.ToString();

            return output;
        }

        public static void Display(DataReceivedEventArgs nes)
        {
            Console.WriteLine(nes.Data);
        }

        public static string Problem2()
        {
            ProcessStartInfo _startInfo = new ProcessStartInfo();
            Process p = new Process();
            StringBuilder outputStringBuilder = new StringBuilder();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\RTest\bin\debug\RTest.exe";
            var file = new FileInfo(filePath);

            p.StartInfo = _startInfo;
            _startInfo.UseShellExecute = false;
            _startInfo.RedirectStandardOutput = true;
            _startInfo.RedirectStandardInput = true;
            _startInfo.WorkingDirectory = file.Directory.FullName;
            _startInfo.FileName = file.FullName;
            p.OutputDataReceived += (sender, eventArgs) => outputStringBuilder.AppendLine(eventArgs.Data);
            p.Start();
            p.BeginOutputReadLine();
            var myWriter = p.StandardInput;
            myWriter.AutoFlush = true;
            //myWriter.WriteLine("synthesize kitap +Noun +A3sg +P2sg +Loc");
            myWriter.Close();

            p.WaitForExit();
            var output = outputStringBuilder.ToString();

            return output;
        }
    }
}
