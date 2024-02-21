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

        public async Task OnGetAsync()
        {
  
            CarInformation = _context.GetCars();
        }
    }
}
