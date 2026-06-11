
using System.ComponentModel.DataAnnotations;
using WinFormsApp1.model.@enum;

namespace WinFormsApp1.model.entidade
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logradouro", Description = "logradouro cliente")]
        [StringLength(120, MinimumLength = 2, ErrorMessage = "Logradouro deve conter de 2 a 120 caracteres")]
        [Required(ErrorMessage = "Nome Fantasia é obrigatório.")]
        [MaxLength(120)]
        public String NomeFantasia { get; set; } = string.Empty;

        [StringLength(120, ErrorMessage = "Razão Social deve conter de 2 a 120 caracteres")]
        [MaxLength(120)]
        public String? RazaoSocial { get; set; } = string.Empty;

        [StringLength(13, ErrorMessage = "Cnpj deve conter 13 caracteres")]
        [MaxLength(13)]
        public string? Cnpj { get; set; } = string.Empty;

        [StringLength(9, ErrorMessage = "Inscrição Estadual deve conter 9 caracteres")]
        [MaxLength(9)]
        public string? InscricaoEstadual { get; set; } = string.Empty;


        public Contato Contato { get; set; } = new();
       
        public Endereco Endereco { get; set; } = new();

        public Status Status { get; set; } = Status.Ativo;

    }
}
