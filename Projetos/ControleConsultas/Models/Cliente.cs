using System.ComponentModel.DataAnnotations;

namespace ControleConsultas.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;
    }
}
