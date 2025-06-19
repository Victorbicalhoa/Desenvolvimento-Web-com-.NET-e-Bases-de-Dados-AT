using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using AgenciaTurismo.Models; 
namespace AgenciaTurismo.Pages.Conta
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario { get; set; } = "";

        [BindProperty]
        public string Senha { get; set; } = "";

        public string? MensagemErro { get; set; }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Usuario == UserCredential.USERNAME && Senha == UserCredential.PASSWORD)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Usuario),
                    new Claim(ClaimTypes.Role, "Administrador")
                };

                var identidade = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identidade);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToPage("/Index");
            }

            MensagemErro = "Usuário ou senha inválidos.";
            return Page();
        }
    }
}
