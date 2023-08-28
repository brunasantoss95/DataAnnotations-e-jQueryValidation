
using System.ComponentModel.DataAnnotations;
namespace WebApplication7.Models
{
   
        public class Pessoa
        {
        [Required(ErrorMessage ="Nome deve ser preenchido")]
            public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage =
            "Campo deve ter pelo menos 5 caracteres")]

        public string Observacao { get; set; }
            [Range(18,100, ErrorMessage =
                "A idade da pessoa deve ter idade entre 18 e 100")]

            public int idade { get; set; }

            public string Email { get; set; }

            public string Login { get; set; }

            public string Senha { get; set; }
        [Compare("Senha", ErrorMessage = "As senhas não conferem")]

            public string ConfirmarSenha { get; set; }

        
    }
}
