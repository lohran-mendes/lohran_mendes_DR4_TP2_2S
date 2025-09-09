using System.ComponentModel.DataAnnotations;

namespace lohran_mendes_DR4_TP2_2S.Pages.CityManager;

public class InputModel
{
    [Required(ErrorMessage = "O campo cidade é obrigatório.")]
    [MinLength(3, ErrorMessage = "O campo cidade deve ter no mínimo 3 caracteres.")]
    public string? CityName { get; set; }
}