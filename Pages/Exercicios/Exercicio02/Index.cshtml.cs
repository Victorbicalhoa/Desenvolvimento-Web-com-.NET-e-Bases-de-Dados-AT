using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio02
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Mensagem { get; set; } = string.Empty;

        public string LogConsole { get; set; } = string.Empty;
        public string LogArquivo { get; set; } = string.Empty;
        public string LogMemoria { get; set; } = string.Empty;

        private static List<string> MemoriaLog { get; set; } = new();

        public void OnPost()
        {
            Action<string> logDelegate = null!;
            logDelegate += LogToConsole;
            logDelegate += LogToFile;
            logDelegate += LogToMemory;

            logDelegate?.Invoke(Mensagem);
        }

        private void LogToConsole(string msg)
        {
            LogConsole = $"[Console] {msg}";
            Console.WriteLine(LogConsole);
        }

        private void LogToFile(string msg)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Logs", "log.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            var logMsg = $"[Arquivo] {msg}";
            System.IO.File.AppendAllText(path, $"{logMsg}{Environment.NewLine}");
            LogArquivo = logMsg;
        }

        private void LogToMemory(string msg)
        {
            var memMsg = $"[Memória] {msg}";
            MemoriaLog.Add(memMsg);
            LogMemoria = memMsg;
        }
    }
}
