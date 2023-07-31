using System.Diagnostics;

namespace DartLibrary
{
    public class Class1
    {
        public void ExecutarExeDart()
        {
            // Caminho completo para o arquivo executável Dart
            string caminhoExeDart = "";

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

                // Lê a saída padrão do processo
                string output = exeProcess.StandardOutput.ReadToEnd();

                // Aguarda o término do processo
                exeProcess.WaitForExit();

                // Faça o que quiser com a saída (nesse exemplo, apenas exibindo no console)
                Console.WriteLine($"Saída do executável Dart: {output}");
            }
        }
    }
}