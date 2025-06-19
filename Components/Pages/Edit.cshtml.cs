using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BalatroWikiApp.Models;

namespace BalatroWikiApp.Components.Pages
{
    public class EditModel : PageModel
    {
        private readonly BalatroWikiApp.Models.BalatroDBContext _context;

        public EditModel(BalatroWikiApp.Models.BalatroDBContext context)
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

            var card =  await _context.Cards.FirstOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }
            Card = card;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Card).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardExists(Card.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CardExists(int id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }
    }
}
