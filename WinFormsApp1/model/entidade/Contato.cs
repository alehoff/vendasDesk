using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.model.entidade
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [StringLength(11,  ErrorMessage = "WhatsApp deve conter 11 caracteres")]
        [MaxLength(11)]
        public String? WhatsApp { get; set; } = string.Empty;

        [StringLength(11, ErrorMessage = "Fone Comercial deve conter 11 caracteres")]
        [MaxLength(11)]
        public string? FoneComercial { get; set; } = string.Empty;

        [StringLength(80, ErrorMessage = "Email deve conter 80 caracteres")]
        [MaxLength(80)]
        public string? Email { get; set; } = string.Empty;

        [ForeignKey("empresa_id")]
        public Empresa Empresa = null!;
    }
}
