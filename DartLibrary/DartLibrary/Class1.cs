using System.Diagnostics;

namespace DartLibrary
{
    public class Class1
    {
        public async Task<int> ExecutarExeDart(List<string> args)
        {
            // Caminho completo para o arquivo executável Dart
            string caminhoExeDart = "";

            // Verifica se o arquivo executável existe
            if (!System.IO.File.Exists(caminhoExeDart))
            {
                return 0;
            }

            // Verifica se exatamente dois argumentos foram fornecidos
            if (args.Count != 2)
            {
                return -1;
            }

            // Configurações do processo
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = caminhoExeDart,
                RedirectStandardOutput = false,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = string.Join(" ", args)
            };

            // Cria e inicia o processo
            using (Process exeProcess = new Process())
            {
                exeProcess.StartInfo = startInfo;
                exeProcess.Start();

                // Aguarda assincronamente o término do processo
                await exeProcess.WaitForExitAsync();

                // Obtém o valor retornado pelo executável Dart a partir da propriedade ExitCode
                return exeProcess.ExitCode;                

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