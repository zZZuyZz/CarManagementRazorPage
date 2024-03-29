﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO.Models;
using CarManagementService;

namespace CarManagementUI.Pages.CustomerPages
{
    public class EditModel : PageModel
    {
        private readonly ICarInformationService _context;

        public EditModel(ICarInformationService context)
        {
            _context = context;
        }

        [BindProperty]
        public CarInformation CarInformation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carinformation =  _context.GetCarById(id);
            if (carinformation == null)
            {
                return NotFound();
            }
            CarInformation = carinformation;
           ViewData["BrandId"] = new SelectList(_context.GetBrands(), "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                CarInformation.CarStatus = 0;
                var a = HttpContext.Session.GetInt32("Id").Value;
                CarInformation.OwnerId = a;
                _context.UpdateCar(CarInformation);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_context.GetCarById(CarInformation.Id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
