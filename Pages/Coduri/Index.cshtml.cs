using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pecolzz.Data;
using Pecolzz.Models;

namespace Pecolzz.Pages.Coduri
{
    public class IndexModel : PageModel
    {
        private readonly Pecolzz.Data.PecolzzContext _context;

        public IndexModel(Pecolzz.Data.PecolzzContext context)
        {
            _context = context;
        }

        public IList<Cod> Cod { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cod != null)
            {
                Cod = await _context.Cod.ToListAsync();
            }
        }
    }
}
