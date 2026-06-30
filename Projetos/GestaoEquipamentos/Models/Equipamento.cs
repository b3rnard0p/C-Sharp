using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoFinal.Models
{
    public class Equipamento : IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição do equipamento é obrigatória.")]
        [MinLength(3, ErrorMessage = "A descrição deve possuir no mínimo 3 caracteres.")]
        [RegularExpression(@"^[^;]+$", ErrorMessage = "A descrição não pode conter ponto e vírgula (;).")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O código interno de patrimônio é obrigatório.")]
        [MinLength(6, ErrorMessage = "O código interno deve possuir no mínimo 6 caracteres.")]
        [RegularExpression(@"^[^;]+$", ErrorMessage = "O código interno não pode conter ponto e vírgula (;).")]
        public string CodigoPatrimonio { get; set; } = string.Empty;

        [Required(ErrorMessage = "A situação do equipamento é obrigatória.")]
        public SituacaoEquipamento? Situacao { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var equipamentos = TrabalhoFinal.Services.DatabaseHelper.CarregarEquipamentos();
            
            if (equipamentos.Any(e => e.Id != Id && e.CodigoPatrimonio == CodigoPatrimonio))
            {
                yield return new ValidationResult(
                    "Este código de patrimônio já está em uso por outro equipamento.",
                    new[] { nameof(CodigoPatrimonio) }
                );
            }
        }
    }
}
