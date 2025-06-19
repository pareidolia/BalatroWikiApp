using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BalatroWikiApp.Models;

namespace BalatroWikiApp.Components.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly BalatroWikiApp.Models.BalatroDBContext _context;

        public DeleteModel(BalatroWikiApp.Models.BalatroDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Card Card { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.Cards.FirstOrDefaultAsync(m => m.Id == id);

            if (card is not null)
            {
                Card = card;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.Cards.FindAsync(id);
            if (card != null)
            {
                Card = card;
                _context.Cards.Remove(Card);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
