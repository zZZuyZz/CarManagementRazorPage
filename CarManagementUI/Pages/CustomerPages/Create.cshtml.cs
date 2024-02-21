using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BO.Models;
using CarManagementService;

namespace CarManagementUI.Pages.CustomerPages
{
    public class CreateModel : PageModel
    {
        private readonly ICarInformationService _context;

        public CreateModel(ICarInformationService context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BrandId"] = new SelectList(_context.GetBrands(), "Id", "Id");
        return Page();
        }

        [BindProperty]
        public CarInformation CarInformation { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            CarInformation.OwnerId = HttpContext.Session.GetInt32("Id").Value;
            CarInformation.CarStatus = 0;
            _context.AddCar(CarInformation);
            return RedirectToPage("./Index");
        }
    }
}
