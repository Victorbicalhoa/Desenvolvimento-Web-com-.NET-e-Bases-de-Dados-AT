using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio08
{
    public class ViewNotesModel : PageModel
    {
        private readonly string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");

        [BindProperty]
        [Required(ErrorMessage = "O título da nota é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z0-9_\-]+$", ErrorMessage = "Título inválido. Use apenas letras, números, _ ou -")]
        public string FileName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "O conteúdo da nota não pode ser vazio.")]
        public string Content { get; set; }

        public string Mensagem { get; set; }

        public List<string> Files { get; set; } = new List<string>();

        public string SelectedFile { get; set; }
        public string SelectedContent { get; set; }

        public void OnGet(string filename)
        {
            LoadFiles();

            if (!string.IsNullOrEmpty(filename))
            {
                SelectedFile = filename;
                var fullPath = Path.Combine(folderPath, filename);
                if (System.IO.File.Exists(fullPath))
                {
                    SelectedContent = System.IO.File.ReadAllText(fullPath);
                }
                else
                {
                    SelectedContent = "Arquivo não encontrado.";
                }
            }
        }

        public IActionResult OnPost()
        {
            LoadFiles();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var safeFileName = FileName.EndsWith(".txt") ? FileName : FileName + ".txt";
            var fullPath = Path.Combine(folderPath, safeFileName);

            System.IO.File.WriteAllText(fullPath, Content);

            Mensagem = $"Nota '{safeFileName}' salva com sucesso.";

            // Atualiza a lista e limpa os campos
            LoadFiles();
            FileName = string.Empty;
            Content = string.Empty;

            return Page();
        }

        private void LoadFiles()
        {
            if (Directory.Exists(folderPath))
            {
                Files = Directory.GetFiles(folderPath, "*.txt")
                    .Select(Path.GetFileName)
                    .OrderByDescending(f => f)
                    .ToList();
            }
            else
            {
                Files = new List<string>();
            }
        }
    }
}
