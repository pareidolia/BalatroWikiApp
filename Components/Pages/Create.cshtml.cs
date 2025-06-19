using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BalatroWikiApp.Models;

namespace BalatroWikiApp.Components.Pages
{
    public class CreateModel : PageModel
    {
        private readonly BalatroWikiApp.Models.BalatroDBContext _context;

        public CreateModel(BalatroWikiApp.Models.BalatroDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Card Card { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cards.Add(Card);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
