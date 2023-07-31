using System;
using System.Diagnostics;

public class DartCalculator
{
    public int CalculateSquare()
    {
        var dartPath = "main.exe"; // Use the executable file name here
        var result = CallDartFunction(dartPath);

        int parsedResult;
        if (int.TryParse(result, out parsedResult))
        {
            return parsedResult;
        }
        else
        {
            throw new Exception("Invalid result from Dart: " + result);
        }
    }

    private string CallDartFunction(string dartPath)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = "dart", // Use the 'dart' command to execute the executable
            Arguments = $"{dartPath}",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (var process = Process.Start(startInfo))
        {
            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            return output.Trim();
        }
    }
}
