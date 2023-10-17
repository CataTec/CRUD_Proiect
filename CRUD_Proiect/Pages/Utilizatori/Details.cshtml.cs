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
    public class DetailsModel : PageModel
    {
        private readonly CRUD_Proiect.Data.CRUD_ProiectContext _context;

        public DetailsModel(CRUD_Proiect.Data.CRUD_ProiectContext context)
        {
            _context = context;
        }

      public Utilizator Utilizator { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Utilizator == null)
            {
                return NotFound();
            }

            var utilizator = await _context.Utilizator.FirstOrDefaultAsync(m => m.ID == id);
            if (utilizator == null)
            {
                return NotFound();
            }
            else 
            {
                Utilizator = utilizator;
            }
            return Page();
        }
    }
}
