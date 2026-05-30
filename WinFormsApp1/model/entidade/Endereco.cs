using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.model.entidade
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(8)]
        public string Cep { get; set; } = string.Empty;

        [MaxLength(120)]
        public string Logradouro { get; set; } = string.Empty;

        [MaxLength(4)]
        public string Numero { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Bairro { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Municipio { get; set; } = string.Empty;

        [MaxLength(2)]
        public string Uf { get; set; } = string.Empty;

        [MaxLength(180)]
        public string Localizacao { get; set; } = string.Empty;

        [ForeignKey("empresa_id")]
        public Empresa Empresa { get; set; }


    }
}
