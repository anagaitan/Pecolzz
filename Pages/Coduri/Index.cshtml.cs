using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pecolzz.Data;
using Pecolzz.Models;
using Pecolzz.Models.ViewModels

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

        public CodIndexData CodData { get; set; }
        public int CodID { get; set; }
        public int ProdusID { get; set; }
        public async Task OnGetAsync(int? id, int? produsID)
        {

            CodData = new CodIndexData();
            CodData.Coduri = await _context.Cod
            .Include(i => i.Produse)
            .ThenInclude(c => c.Denumire_produs)
            .OrderBy(i => i.CodArticol)
            .ToListAsync();
            if (id != null)
            {
                CodID = id.Value;
                Cod cod = CodData.Coduri
                .Where(i => i.ID == id.Value).Single();
                CodData.Produse = cod.Produse;
            }
        }
    }
}
