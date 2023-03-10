using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pecolzz.Data;
using Pecolzz.Models;

namespace Pecolzz.Pages.Produse
{
    public class CreateModel : PageModel
    {
        private readonly Pecolzz.Data.PecolzzContext _context;

        public CreateModel(Pecolzz.Data.PecolzzContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CodID"] = new SelectList(_context.Set<Cod>(), "ID", "CodArticol");
            return Page();
        }

        [BindProperty]
        public Produs Produs { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produs.Add(Produs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
