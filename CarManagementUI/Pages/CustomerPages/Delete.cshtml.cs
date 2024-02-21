using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BO.Models;
using CarManagementService;

namespace CarManagementUI.Pages.CustomerPages
{
    public class DeleteModel : PageModel
    {
        private readonly ICarInformationService _context;

        public DeleteModel(ICarInformationService context)
        {
            _context = context;
        }

        [BindProperty]
      public CarInformation CarInformation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var carinformation = _context.GetCarById(id);

            if (carinformation == null)
            {
                return NotFound();
            }
            else 
            {
                CarInformation = carinformation;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            _context.DeleteCar(id);

            return RedirectToPage("./Index");
        }
    }
}
