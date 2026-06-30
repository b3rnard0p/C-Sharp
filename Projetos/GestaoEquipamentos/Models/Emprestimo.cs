using System.ComponentModel.DataAnnotations;

namespace TrabalhoFinal.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O equipamento é obrigatório.")]
        public int EquipamentoId { get; set; }
        
        [Required(ErrorMessage = "O e-mail do responsável é obrigatório.")]
        [EmailAddress(ErrorMessage = "O formato do e-mail é inválido.")]
        [RegularExpression(@"^[^;]+$", ErrorMessage = "O e-mail não pode conter ponto e vírgula (;).")]
        public string EmailResponsavel { get; set; } = string.Empty;
        
        public DateTime DataEmprestimo { get; set; }
        
        public bool StatusAtivo { get; set; } = true;
    }
}
