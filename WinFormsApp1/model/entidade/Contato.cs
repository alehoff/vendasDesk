using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.model.entidade
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(11)]
        public String? WhatsApp { get; set; } = string.Empty;

        [MaxLength(11)]
        public string? FoneComercial { get; set; } = string.Empty;

        [MaxLength(11)]
        public string? Email { get; set; } = string.Empty;

        [ForeignKey("empresa_id")]
        public Empresa Empresa;
    }
}
