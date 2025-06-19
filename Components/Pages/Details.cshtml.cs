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
    public class DetailsModel : PageModel
    {
        private readonly BalatroWikiApp.Models.BalatroDBContext _context;

        public DetailsModel(BalatroWikiApp.Models.BalatroDBContext context)
        {
            _context = context;
        }

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
    }
}
