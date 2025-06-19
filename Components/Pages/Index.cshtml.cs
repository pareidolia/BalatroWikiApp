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
    public class IndexModel : PageModel
    {
        private readonly BalatroWikiApp.Models.BalatroDBContext _context;

        public IndexModel(BalatroWikiApp.Models.BalatroDBContext context)
        {
            _context = context;
        }

        public IList<Card> Card { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Card = await _context.Cards.ToListAsync();
        }
    }
}
