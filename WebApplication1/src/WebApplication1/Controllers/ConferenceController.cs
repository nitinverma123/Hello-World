using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ConferenceController : Controller
    {
        IEmployee _employee;
        public ConferenceController(IEmployee employee)
        {
            this._employee = employee;
        }

        public async Task<IActionResult> Index(int id)
        {
            ViewBag.Title = "Conferenece";
            return View( await _employee.GetEmployee(id));
        }
    }
}
