using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pecolzz.Data;
using Pecolzz.Models;
using Pecolzz.Models.ViewModels

namespace Pecolzz.Pages.Produse
{
    public class IndexModel : PageModel
    {
        private readonly Pecolzz.Data.PecolzzContext _context;

        public IndexModel(Pecolzz.Data.PecolzzContext context)
        {
            _context = context;
        }

        public IList<Produs> Produs { get;set; } = default!;

        public async Task OnGetAsync()
        {
            {
                Produs = await _context.Produs
                .Include(b => b.Cod)
                .ToListAsync();
            }
        }
    }
}

