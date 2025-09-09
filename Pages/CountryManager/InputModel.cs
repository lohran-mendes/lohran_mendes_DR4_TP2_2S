using System.ComponentModel.DataAnnotations;

namespace lohran_mendes_DR4_TP2_2S.Pages.CountryManager;

public class InputModel
{
    [Required(ErrorMessage = "O campo nome do país é obrigatório.")]
    public string? CountryName { get; set; }

    [Required(ErrorMessage = "O campo código do país é obrigatório.")]
    [StringLength(2, MinimumLength = 2, ErrorMessage = "O código do país deve ter exatamente 2 caracteres.")]
    public string? CountryCode { get; set; }
}