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
    public class DeleteModel : PageModel
    {
        private readonly Pecolzz.Data.PecolzzContext _context;

        public DeleteModel(Pecolzz.Data.PecolzzContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Cod Cod { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cod == null)
            {
                return NotFound();
            }

            var cod = await _context.Cod.FirstOrDefaultAsync(m => m.ID == id);

            if (cod == null)
            {
                return NotFound();
            }
            else 
            {
                Cod = cod;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Cod == null)
            {
                return NotFound();
            }
            var cod = await _context.Cod.FindAsync(id);

            if (cod != null)
            {
                Cod = cod;
                _context.Cod.Remove(Cod);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
