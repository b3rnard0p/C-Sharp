using System.ComponentModel.DataAnnotations;

namespace ControleConsultas.Models
{
    public class Atendimento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O paciente é obrigatório.")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O horário é obrigatório.")]
        public DateTime? Horario { get; set; }

        [Required(ErrorMessage = "O status é obrigatório.")]
        public StatusAtendimento Status { get; set; }

        [Required(ErrorMessage = "A especialidade é obrigatória.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string Especialidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, 99999.99, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal? Preco { get; set; }
    }
}
