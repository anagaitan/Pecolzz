using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pecolzz.Data;
using Pecolzz.Models;

namespace Pecolzz.Pages.Coduri
{
    public class EditModel : PageModel
    {
        private readonly Pecolzz.Data.PecolzzContext _context;

        public EditModel(Pecolzz.Data.PecolzzContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cod Cod { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cod == null)
            {
                return NotFound();
            }

            var cod =  await _context.Cod.FirstOrDefaultAsync(m => m.ID == id);
            if (cod == null)
            {
                return NotFound();
            }
            Cod = cod;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodExists(Cod.ID))
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

        private bool CodExists(int id)
        {
          return _context.Cod.Any(e => e.ID == id);
        }
    }
}
