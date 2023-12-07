using B_E_Task17.DAL;
using B_E_Task17.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B_E_Task17.Controllers
{
    public class ContactController : Controller
    {

        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            ContacIndexVM indexVM = new()
            {
                ContactInfo = _db.ContactInfo.FirstOrDefault(),
                ContactsTypes = _db.ContactsTypes.ToList()
            };
            return View(indexVM);
        }
    }
}
