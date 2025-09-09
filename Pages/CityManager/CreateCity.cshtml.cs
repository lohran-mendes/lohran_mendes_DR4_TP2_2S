using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lohran_mendes_DR4_TP2_2S.Pages.CityManager;

public class CreateCity : PageModel
{
    [BindProperty]
    public string? CityName { get; set; }

    public void OnGet()
    {
    }
    
}