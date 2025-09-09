using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lohran_mendes_DR4_TP2_2S.Pages.CountryManager;

public class CreateCountry : PageModel
{
    [BindProperty] public InputModel Input { get; set; } = new();
    public Country? Country { get; set; }
    
    
    public void OnPost()
    {
        if (ModelState.IsValid)
        {
            Country = new Country
            {
                CountryName = Input.CountryName!,
                CountryCode = Input.CountryCode!
            };
        }
    }
}