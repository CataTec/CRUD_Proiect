using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_Proiect.Data;
using CRUD_Proiect.Test;

namespace CRUD_Proiect.Pages.Utilizatori
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_Proiect.Data.CRUD_ProiectContext _context;

        public IndexModel(CRUD_Proiect.Data.CRUD_ProiectContext context)
        {
            _context = context;
        }

        public IList<Utilizator> Utilizator { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Utilizator != null)
            {
                Utilizator = await _context.Utilizator.ToListAsync();
            }
        }
    }
}
