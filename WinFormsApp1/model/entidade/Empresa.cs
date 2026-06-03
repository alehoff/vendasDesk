
using System.ComponentModel.DataAnnotations;
using WinFormsApp1.model.@enum;

namespace WinFormsApp1.model.entidade
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(120)]
        public String NomeFantasia { get; set; } = string.Empty;

        [MaxLength(120)]
        public String? RazaoSocial { get; set; } = string.Empty;

        [MaxLength(13)]
        public string? Cnpj { get; set; } = string.Empty;

        [MaxLength(9)]
        public string? InscricaoEstadual { get; set; } = string.Empty;

        public Contato Contato { get; set; } = new();

        public Endereco Endereco { get; set; } = new();

        public Status Status { get; set; } = Status.Ativo;

    }
}
