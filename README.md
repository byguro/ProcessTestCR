
I have been trying to read process output for parsing morphological analysis. But I can't read pckimmo32.exe output.

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
I can read another text exe file output.

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
        myWriter.Close();

        p.WaitForExit();
        var output = outputStringBuilder.ToString();

        return output;
    }
Problem2 Method is success read output, I want read output Problem1 method.

I believe I am on the right track but just need a couple pointers.

http://stackoverflow.com/questions/41011813/c-sharp-process-output-unreadable-pckimmo
