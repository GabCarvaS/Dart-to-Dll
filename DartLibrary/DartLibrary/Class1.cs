using System.Diagnostics;

namespace DartLibrary
{
    public class Class1
    {
        public async Task ExecutarExeDart()
        {
            // Caminho completo para o arquivo executável Dart
            string caminhoExeDart = @"";

            // Verifica se o arquivo executável existe
            if (!System.IO.File.Exists(caminhoExeDart))
            {
                Console.WriteLine("O arquivo executável não foi encontrado.");
                return;
            }

            // Configurações do processo
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = caminhoExeDart,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Cria e inicia o processo
            using (Process exeProcess = new Process())
            {
                exeProcess.StartInfo = startInfo;
                exeProcess.Start();

                // Aguarda assincronamente o término do processo
                await exeProcess.WaitForExitAsync();

                // Lê a saída padrão do processo (agora, considerada como uma string)
                string output = exeProcess.StandardOutput.ReadToEnd();

                Console.WriteLine($"Saída do executável Dart: {output}");
            }
        }
    }

    public static class ProcessExtensions
    {
        public static Task WaitForExitAsync(this Process process)
        {
            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(null);
            if (process.HasExited) tcs.TrySetResult(null);
            return tcs.Task;
        }
    }
}