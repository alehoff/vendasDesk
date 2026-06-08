using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.model.entidade
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [StringLength(8, ErrorMessage = "Cep deve conter 08 caracteres")]
        [Required(ErrorMessage = "Cep deve ser informado!!.")]
        [MaxLength(8)]
        public string Cep { get; set; } = string.Empty;

        [Required(ErrorMessage = "Logradouro deve ser informado!!")]
        [StringLength(120, ErrorMessage = "Logradouro deve conter máximo 120 caracteres")]
        [MaxLength(120)]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Número deve ser informado!!")]
        [StringLength(4, ErrorMessage = "Número deve conter máximo 04 caracteres")]
        [MaxLength(4)]
        public string Numero { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bairro deve ser informado!!")]
        [StringLength(100, ErrorMessage = "Bairro deve conter máximo 100 caracteres")]
        [MaxLength(100)]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Município deve ser informado!!")]
        [StringLength(100, ErrorMessage = "Município deve conter máximo 100 caracteres")]
        [MaxLength(100)]
        public string Municipio { get; set; } = string.Empty;

        [Required(ErrorMessage = "UF deve ser informado!!")]
        [StringLength(2, ErrorMessage = "UF deve conter máximo 2 caracteres")]
        [MaxLength(2)]
        public string Uf { get; set; } = string.Empty;

        [StringLength(180, ErrorMessage = "Localização deve conter máximo 180 caracteres")]
        [MaxLength(180)]
        public string? Localizacao { get; set; } = string.Empty;

        [ForeignKey("empresa_id")]
        public Empresa Empresa { get; set; }


    }
}
