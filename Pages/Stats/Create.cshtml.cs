using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BrodnikProject.Data;
using BrodnikProject.Models;

namespace BrodnikProject.Pages.Stats
{
    public class CreateModel : PageModel
    {
        private readonly BrodnikProject.Data.BrodnikProjectContext _context;

        public CreateModel(BrodnikProject.Data.BrodnikProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Stat Stat { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Stat.Add(Stat);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
