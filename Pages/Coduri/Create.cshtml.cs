using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pecolzz.Data;
using Pecolzz.Models;

namespace Pecolzz.Pages.Coduri
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
            return Page();
        }

        [BindProperty]
        public Cod Cod { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cod.Add(Cod);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
