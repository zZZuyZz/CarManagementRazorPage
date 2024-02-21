using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BO.Models;
using CarManagementService;

namespace CarManagementUI.Pages.EvaluatorPages
{
    public class IndexModel : PageModel
    {
        private readonly ICarInformationService _context;

        public IndexModel(ICarInformationService context)
        {
            _context = context;
        }

        public IList<CarInformation> CarInformation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            CarInformation = new List<CarInformation>();
            CarInformation = _context.GetCars();
            
        }
        public async Task<IActionResult> OnPostSearchAsync()
        {
            CarInformation = new List<CarInformation>();
            CarInformation = _context.GetCarsByStatus();
            return Page();
        }
        public async Task<IActionResult> OnPostLogoutAsync()
        {

            HttpContext.Session.Clear();
            return RedirectToPage("/Login");
        }

    }
}
