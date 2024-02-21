using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BO.Models;
using CarManagementService;
using CarManagementRepo;

namespace CarManagementUI.Pages.CustomerPages
{
    public class IndexModel : PageModel
    {
        private readonly ICarInformationService _context;

        public IndexModel(ICarInformationService context)
        {
            _context = context;
        }

        public IList<CarInformation> CarInformation { get;set; } = default!;
        [BindProperty]
        public string SearchKey { get; set; }


        public async Task OnGetAsync()
        {
            CarInformation = new List<CarInformation>();
            CarInformation = _context.GetCarsByOwner(HttpContext.Session.GetInt32("Id").Value, null);
        }
        public IActionResult OnPost()
        {
            if (SearchKey == null)
            {
                return RedirectToAction("./index");
            }
            CarInformation = new List<CarInformation>();
            CarInformation = _context.GetCarsByOwner(HttpContext.Session.GetInt32("Id").Value, SearchKey);
            return Page();
        }
        public async Task<IActionResult> OnPostLogoutAsync()
        {

            HttpContext.Session.Clear();
            return RedirectToPage("/Login");
        }
    }
}
